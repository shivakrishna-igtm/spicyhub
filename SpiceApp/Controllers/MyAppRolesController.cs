using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SpiceApp.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpiceApp.Controllers
{
    public class MyAppRolesController : Controller
    {
        public UserManager<IdentityUser> UserManager;
        public RoleManager<IdentityRole> RoleManager;

        public MyAppRolesController(RoleManager<IdentityRole> _RoleManager,
         UserManager<IdentityUser> _userManager)
        {
            UserManager = _userManager;
            RoleManager = _RoleManager;

        }


        public async Task<IActionResult> Index()
        {
            IdentityUser user2 = await UserManager.FindByEmailAsync("admin@gmail.com");
            IdentityResult  result = await UserManager.AddToRoleAsync(user2, SD.ManagerUser);

            return (View());
        }
    }
}
