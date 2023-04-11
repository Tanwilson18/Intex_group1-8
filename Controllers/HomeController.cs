using Intex_group1_8.Models;
<<<<<<< HEAD
using Microsoft.AspNetCore.Authorization;
=======
using Intex_group1_8.Models.ViewModels;
>>>>>>> WIN32_Exception
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

            List<Burialmain> returnList = new List<Burialmain>();
            returnList = repo.Burialmains.ToList();

            //var returnList = new BurialmainViewModel
            //{
            //    // Grabbing Burialmains from DB for each page
            //    Burialmains = repo.Burialmains,
            //    // Insert Filtering stuff

            //    // Creating PageInfo for BurialmainViewModel
            //    PageInfo = new PageInfo
            //    {
            //        // Insert Filtering stuff
            //        ResultsPerPage = pageSize,
            //        CurrentPage = pageNum
            //    }
            //};

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
