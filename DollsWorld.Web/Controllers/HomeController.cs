using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using DollsWorld.Core.Services.Interfaces;

namespace DollsWorld.Web.Controllers
{
    public class HomeController : Controller
    {
        private IUserService _userService;
        private ICourseService _courseService;

        public HomeController(IUserService userService, ICourseService courseService)
        {
            _userService = userService;
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            var popular = _courseService.GetPopularCourse();
            ViewBag.PopularCourse = popular;
            return View(_courseService.GetCourse().Item1);
        }

     

        [Route("OnlinePayment/{id}")]
        public IActionResult onlinePayment(int id)
        // بانک به ما یک سری پارامتر میدهد که برای کار کردن با آن پارامتر ها نیاز به وری فای کردن داریم === VERIFY
        {
            // چک کردن اطلاعات و پارامتر های بانک
            if (HttpContext.Request.Query["Status"] != "" &&
                HttpContext.Request.Query["Status"].ToString().ToLower() == "ok"
                && HttpContext.Request.Query["Authority"] != "")
            {
                string authority = HttpContext.Request.Query["Authority"];  // آتوریتی را پس می گیریم 

                var wallet = _userService.GetWalletByWalletId(id);
                // id == این آیدی همان است که به عنوان ورودی برای این اکشن ارسال شده است 

                var payment = new ZarinpalSandbox.Payment(wallet.Amount); // باید به بانک بگوییم که من کاربر را گرفتم وگرنه پول به حساب کاربر برمیگردد
                var res = payment.Verification(authority).Result; // در این جا به بانک اطلاع می دهیم و ویرفای می کنیم .
                if (res.Status == 100)
                {
                    ViewBag.code = res.RefId;
                    //code == کد پیگیری
                    ViewBag.IsSuccess = true;
                    wallet.IsPay = true;
                    _userService.UpdateWallet(wallet);
                }

            }

            return View();
        }

        public IActionResult GetSubGroups(int id)
        {
            List<SelectListItem> list=new List<SelectListItem>()
            {
                new SelectListItem(){Text = "انتخاب کنید",Value = ""}
            };
            list.AddRange(_courseService.GetSubGroupForManageCourse(id));
            return Json(new SelectList(list, "Value", "Text"));
        }


        [HttpPost]
        [Route("file-upload")]
        public IActionResult UploadImage(IFormFile upload, string CKEditorFuncNum, string CKEditor, string langCode)
        {
            if (upload.Length <= 0) return null;

            var fileName = Guid.NewGuid() + Path.GetExtension(upload.FileName).ToLower();



            var path = Path.Combine(
                Directory.GetCurrentDirectory(), "wwwroot/MyImages",
                fileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                upload.CopyTo(stream);

            }



            var url = $"{"/MyImages/"}{fileName}";


            return Json(new { uploaded = true, url });
        }
    }
}