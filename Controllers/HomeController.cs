using Intex_group1_8.Models;
using Microsoft.AspNetCore.Authorization;
using Intex_group1_8.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Intex_group1_8.Controllers
{
    public class HomeController : Controller
    {
        private IBurialmainRepository repo;
        private intex2Context context;

        // Constructor
        public HomeController(IBurialmainRepository temp, intex2Context temp2)
        {
            repo = temp;
            context = temp2;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BurialSummary(string sex, string depth, string age, string dir, string burialid, string hair, string bundle, string color, string structure, string function, int pageNum = 1)
        {

            int pageSize = 40;

            int TotalCount = 0;

            //var burialList =
            //    from b in repo.Burialmains
            //    join bt in repo.BurialmainTextiles
            //    on b.Id equals bt.MainBurialmainid
            //    join t in repo.Textiles
            //    on bt.MainTextileid equals t.Id
            //    select new
            //    {
            //        BMid = b.Id 
            //    };


            //TotalCount = burialList.Count();

            var returnList = new BurialmainViewModel
            {
                // Grabbing Burialmains from DB for each page

            // -- Changing Filtering --
                Burialmains = repo.Burialmains
                    .Where(b => (b.Sex == sex || sex == null)
                        && (b.Depth == depth || depth == null)
                        && (b.Ageatdeath == age || age == null)
                        && (b.Headdirection == dir || dir == null)
                        //&& (b.Burialid == long.Parse(burialid) || burialid == null)
                        && (b.Haircolor == hair || hair == null)
                        && (b.Facebundles == bundle || bundle == null))
                    .OrderByDescending(b => b.Id)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),

                Colors = repo.Colors
                    .Where(c => c.Value == color || color == null),
                Structures = repo.Structures
                    .Where(s => s.Value == structure || structure == null),
                Textilefunctions = repo.Textilefunctions
                    .Where(f => f.Value == function || function == null),

                BurialmainTextiles = repo.BurialmainTextiles,
                Textiles = repo.Textiles,
                TextilefunctionTextiles = repo.TextilefunctionTextiles,
                ColorTextiles = repo.ColorTextiles,
                StructureTextiles = repo.StructureTextiles,

                // Creating PageInfo for BurialmainViewModel
                PageInfo = new PageInfo
                {
                    // Insert Filtering stuff
                    TotalNumResults = repo.Burialmains
                    .Where(b => (b.Sex == sex || sex == null)
                        && (b.Depth == depth || depth == null)
                        && (b.Ageatdeath == age || age == null)
                        && (b.Headdirection == dir || dir == null)
                        //&& (b.Burialid == long.Parse(burialid) || burialid == null)
                        && (b.Haircolor == hair || hair == null)
                        && (b.Facebundles == bundle || bundle == null)).Count(),
                    //TotalNumResults = TotalCount,
                    ResultsPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(returnList);
        }

        [Authorize(Policy = "RequireAdministratorRole")]
        public IActionResult Admin()
        {
            return View();
        }

        [Authorize(Policy = "RequireResearcherRole")]
        public IActionResult Privacy()
        {
            return View();
        }

        // Burial Details
        [HttpGet]
        public IActionResult BurialDetails(long Id)
        {
            Burialmain bm = repo.Burialmains.Single(b => b.Id == Id);

            var burialList =
                // Join Burialmain => Textiles
                from b in repo.Burialmains
                join bt in repo.BurialmainTextiles on b.Id equals bt.MainBurialmainid into btGroup
                from btLeft in btGroup.DefaultIfEmpty()
                join t in repo.Textiles on (btLeft != null ? btLeft.MainTextileid : -1) equals t.Id into tGroup
                from tLeft in tGroup.DefaultIfEmpty()

                // Join Textiles => Colors
                join ct in repo.ColorTextiles on (tLeft != null ? btLeft.MainTextileid : -1) equals ct.MainTextileid into ctGroup
                from ctLeft in ctGroup.DefaultIfEmpty()
                join c in repo.Colors on (ctLeft != null ? ctLeft.MainColorid : -1) equals c.Id into cGroup
                from cLeft in cGroup.DefaultIfEmpty()

                // Join Textiles => Structures
                join st in repo.StructureTextiles on (tLeft != null ? btLeft.MainTextileid : -1) equals st.MainTextileid into stGroup
                from stLeft in stGroup.DefaultIfEmpty()
                join s in repo.Structures on (stLeft != null ? stLeft.MainStructureid : -1) equals s.Id into sGroup
                from sLeft in sGroup.DefaultIfEmpty()

                // Join Textiles => Functions
                join tft in repo.TextilefunctionTextiles on (tLeft != null ? btLeft.MainTextileid : -1) equals tft.MainTextileid into tftGroup
                from tftLeft in tftGroup.DefaultIfEmpty()
                join tf in repo.Textilefunctions on (tftLeft != null ? tftLeft.MainTextilefunctionid : -1) equals tf.Id into tfGroup
                from tfLeft in tfGroup.DefaultIfEmpty()

                where b.Id == Id
                select new
                {
                    description = tLeft.Description,
                    color = cLeft.Value,
                    structure = sLeft.Value,
                    function = tfLeft.Value,
                };

            //List<string> tList = new List<string>();

            foreach (var item in burialList)
            {
                ViewBag.description = item.description;
                ViewBag.color = item.color;
                ViewBag.structure = item.structure;
                ViewBag.function = item.function;
                break;
            }

            //ViewBag.tdList = tdList;
            return View(bm);
        }

        // Add BurialRecord
        [HttpGet]
        public IActionResult AddBurialRecord()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBurialRecord(Burialmain bm)
        {
            context.Add(bm);
            context.SaveChanges();

            return View("Confirmation");
        }


        // Update BurialRecord
        [HttpPost]
        public IActionResult EditBurialRecord(Burialmain bm)
        {
            context.Update(bm);
            context.SaveChanges();
       
            return RedirectToAction("BurialSummary");
        }


        // Delete BurialRecord
        [HttpGet]
        public IActionResult DeleteBurialRecord(int Id)
        {
            Burialmain bm = repo.Burialmains.SingleOrDefault(b => b.Id == Id);

            return View(bm);
        }

        [HttpPost]
        public IActionResult DeleteBurialRecord(Burialmain bm)
        {
            Burialmain existingBurialMain = repo.Burialmains.SingleOrDefault(b => b.Id == bm.Id);

            context.Remove(existingBurialMain);
            context.SaveChanges();

            return RedirectToAction("BurialSummary");
        }

        public IActionResult UpdateBurialId()
        {
            foreach (Burialmain bm in repo.Burialmains)
            {
                bm.Burialid = (bm.Squarenorthsouth + " " + bm.Northsouth + " " + bm.Squareeastwest + " " + bm.Eastwest + " " + bm.Area + " " + bm.Burialnumber);
                context.Update(bm);
                context.SaveChanges();
            }

            return View("BurialSummary");
        }

        public IActionResult Supervised()
        {
            return View();
        }

        public IActionResult Unsupervised()
        {
            return View();
        }
    }
}
