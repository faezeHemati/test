using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DollsWorld.Core.DTOs;
using DollsWorld.Core.Security;
using DollsWorld.Core.Services.Interfaces;

namespace DollsWorld.Web.Pages.Admin.Users
{
    [PermissionChecker(3)]
    public class CreateUserModel : PageModel
    {
        private IUserService _userService;
        private IPermissionService _permissionService;

        public CreateUserModel(IUserService userService, IPermissionService permissionService)
        {
            _userService = userService;
            _permissionService = permissionService;
        }

        
        [BindProperty]  // این صفت باعث می شود که اگر هر کدام از مقادیر
        // CreateUserViewModel
        // تغییر کند ، ویو متوجه شود
        public CreateUserViewModel CreateUserViewModel { get; set; }

        public void OnGet()
        {
            // رول ها را در ویو دیتایی به نام رول قرار  می دهیم .
            ViewData["Roles"] = _permissionService.GetRoles();
        }

        public IActionResult OnPost(List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
                return Page();

            int userId = _userService.AddUserFromAdmin(CreateUserViewModel);

            //Add Roles
            _permissionService.AddRolesToUser(SelectedRoles,userId);


            return Redirect("/Admin/Users");

        }
    }
}