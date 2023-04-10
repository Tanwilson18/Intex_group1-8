using Intex_group1_8.Models;
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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BurialSummary()
        {
            return View();
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
    }
}
