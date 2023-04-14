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
using Microsoft.AspNetCore.Identity;

namespace Intex_group1_8.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;



        private ApplicationDbContext context;
        private UserManager<IdentityUser> userManager;


        public AdminController(ILogger<AdminController> logger, ApplicationDbContext temp, UserManager<IdentityUser> usrMgr)
        {
            _logger = logger;
            context = temp;
            userManager = usrMgr;

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

            [Authorize(Roles = "RequireAdministratorRole")]
            public async Task<IActionResult> Update(string Id)
            {
                IdentityUser user = await userManager.FindByIdAsync(Id);
                if (user != null)
                    return RedirectToAction("Users");
                else
                    return RedirectToAction("Users");
            }
            [HttpPost]
            public async Task<IActionResult> Update(string Id, string Role)
            {
                IdentityUser user = await userManager.FindByIdAsync(Id);
                var link = context.UserRoles.Single(x => x.UserId == user.Id);
                var rolerow = context.Roles.Single(x => link.RoleId == x.Id);
                rolerow.Name = Role;
                //IdentityRole role = await manage.   RManager.FindByIdAsync(Id)
                if (user != null)
                {

                    IdentityResult result = await userManager.UpdateAsync(user);

                    if (result.Succeeded)
                        return RedirectToAction("Users");
                    else
                        Errors(result);
                }
                else
                    ModelState.AddModelError("", "User Not Found");
                return RedirectToAction("Users");
            }
            private void Errors(IdentityResult result)
            {
                foreach (IdentityError error in result.Errors)
                    ModelState.AddModelError("", error.Description);
            }
        
    }
}