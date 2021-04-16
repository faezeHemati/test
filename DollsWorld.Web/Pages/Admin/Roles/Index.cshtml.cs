using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DollsWorld.Core.DTOs;
using DollsWorld.Core.Security;
using DollsWorld.Core.Services.Interfaces;
using DollsWorld.DataLayer.Entities.User;

namespace DollsWorld.Web.Pages.Admin.Roles
{
    [PermissionChecker(1002)]
    public class IndexModel : PageModel
    {
        private IPermissionService _permissionService;

        public IndexModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        public List<DataLayer.Entities.User.Role> RolesList { get; set; }

       
        public void OnGet()
        {
            RolesList = _permissionService.GetRoles();
        }

       
    }
}