﻿using Intex_group1_8.Models;
using Microsoft.AspNetCore.Authorization;
using Intex_group1_8.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Intex_group1_8.Controllers
{
    public class HomeController : Controller
    {
        private IBurialmainRepository repo;

        // Constructor
        public HomeController(IBurialmainRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BurialSummary(int pageNum = 1)
        {

            int pageSize = 10;

            int TotalCount = 0;

            //var l =
            //    from b in repo.Burialmains
            //    from bt in repo.BurialmainTextiles.Where(bt => b.Id == bt.MainBurialmainid)
            //    .DefaultIfEmpty()
            //    from t in repo.Textiles.Where(bt)
            //        on bt.MainTextileid equals t.Id
            //    select new
            //         { }

            //    from users in Repo.T_User
            //    from mappings in Repo.T_User_Group
            //         .Where(mapping => mapping.USRGRP_USR == users.USR_ID)
            //         .DefaultIfEmpty() // <== makes join left join
            //    from groups in Repo.T_Group
            //         .Where(gruppe => gruppe.GRP_ID == mappings.USRGRP_GRP)
            //         .DefaultIfEmpty()
            TotalCount = repo.Burialmains
                .OrderBy(b => b.Area)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize)
                .Count();

            var returnList = new BurialmainViewModel
            {
                // Grabbing Burialmains from DB for each page

                // -- Changing Filtering --
                Burialmains = repo.Burialmains
                .OrderBy(b => b.Burialnumber)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                BurialmainTextiles = repo.BurialmainTextiles,
                Textiles = repo.Textiles,
                TextilefunctionTextiles = repo.TextilefunctionTextiles,
                Textilefunctions = repo.Textilefunctions,
                ColorTextiles = repo.ColorTextiles,
                Colors = repo.Colors,
                Structures = repo.Structures,
                StructureTextiles = repo.StructureTextiles,

                // Creating PageInfo for BurialmainViewModel
                PageInfo = new PageInfo
                {
                    // Insert Filtering stuff
                    TotalNumResults = repo.Burialmains.Count(),
                    //TotalNumResults = TotalCount,
                    ResultsPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(returnList);
        }


        public IActionResult Supervised()
        {
            return View();
        }

        public IActionResult Unsupervised()
        {
            return View();
        }

        //[Authorize(Policy = "RequireAdministratorRole")]
        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
