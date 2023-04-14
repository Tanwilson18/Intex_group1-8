using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Intex_group1_8.Data
{
    public class IdentitySeedData
    {
        public static async Task Initialize(ApplicationDbContext context,
        UserManager<IdentityUser> userManager,
        RoleManager<IdentityRole> roleManager)
        {

            context.Database.EnsureCreated();

            string asdminRole = "Admin";
            string researcherRole = "Researcher";
            string password4all = "IntexRootbeerSpencer";

            if (await roleManager.FindByNameAsync(asdminRole) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(asdminRole));
            }

            if (await roleManager.FindByNameAsync(researcherRole) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(researcherRole));
            }

            if (await userManager.FindByNameAsync("admin@mummy.com") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "admin@mummy.com",
                    Email = "admin@mummy.com",
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password4all);
                    await userManager.AddToRoleAsync(user, asdminRole);
                }
            }

            if (await userManager.FindByNameAsync("ta@ta.ta") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "ta@ta.ta",
                    Email = "ta@ta.ta",
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password4all);
                    await userManager.AddToRoleAsync(user, researcherRole);
                }
            }
        }
    }
}