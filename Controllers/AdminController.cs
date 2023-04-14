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
using Intex_group1_8.Data;

namespace Intex_group1_8.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;



        private ApplicationDbContext context;


        public AdminController(ILogger<AdminController> logger, ApplicationDbContext temp)
        {
            _logger = logger;
            context = temp;


        }

        ////////////////////
        /////   USERS
        ////////////////////
        ///
        [Authorize(Policy = "RequireAdministratorRole")]
        public IActionResult Users()
        {
            var UserJoin = (from u in context.Users
                            join link in context.UserRoles
                            on u.Id equals link.UserId
                            join r in context.Roles
                            on link.RoleId equals r.Id
                            select new UserPageViewModel
                            {
                                UserRole = r.Name,
                                UserName = u.UserName,
                                UserId = u.Id
                            })
                                  .ToList();



            return View(UserJoin);
        }
    }
}