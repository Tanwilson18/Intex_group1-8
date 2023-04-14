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
            string password4all = "Medellin";

            if (await roleManager.FindByNameAsync(asdminRole) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(asdminRole));
            }

            if (await roleManager.FindByNameAsync(researcherRole) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(researcherRole));
            }

            if (await userManager.FindByNameAsync("admin@admin.com") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "admin@admin.com",
                    Email = "admin@admin.com",
                    PhoneNumber = "6902341234"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password4all);
                    await userManager.AddToRoleAsync(user, asdminRole);
                }
            }

            if (await userManager.FindByNameAsync("rr@mm.mm") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "rr@mm.mm",
                    Email = "rr@mm.mm",
                    PhoneNumber = "1112223333"
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