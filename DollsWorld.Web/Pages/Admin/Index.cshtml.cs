using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DollsWorld.Core.Security;

namespace DollsWorld.Web.Pages.Admin
{ // هر پیج کدی پشن خودش دارد که مدل آن پیج هست که متد های گت و پست هم دارد و هم چنین متد آپدیت که برای عملیات مورد استفاده قرار می گیرد .
   // هر ویژگی که در سطح مدل یعنی اینجا تعریف میشود ، در ویو به آن دسترسی داریم.
    //[PermissionChecker(1)]
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}