using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Intex_group1_8.Models.ViewModels
{
    public class UserPageViewModel
    {
        public List<IdentityUser> UsersInfo { get; set; }
        public List<IdentityRole> UserJoin { get; set; }

        public string UserRole { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
    }
}