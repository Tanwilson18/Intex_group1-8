//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Identity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using ReportPortal.Client.Abstractions.Models;

//namespace Intex_group1_8.Controllers
//{
//    public class AdminController : Controller
//    {
//        private readonly RoleManager<IdentityRole> roleManager;
//        public AdminController(RoleManager<IdentityRole> roleManager)
//        {
//            this.roleManager = roleManager;
//        }

//        public IActionResult Index()
//        {
//            return View();
//        }

//        public IActionResult Create()
//        {
//            return View();
//        }

//        [HttpPost] 
//        public async Task<IActionResult> Create(User role)
//        {
//            var roleExist = await roleManager.RoleExistsAsync(role.Role);
//            if(!roleExist)
//            {
//                var result = await roleManager.CreateAsync(new IdentityRole(role.RoleName));
//            }
//            return View();
//        }
//    }
//}
