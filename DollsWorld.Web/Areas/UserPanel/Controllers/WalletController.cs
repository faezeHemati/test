using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DollsWorld.Core.DTOs;
using DollsWorld.Core.Services.Interfaces;

namespace DollsWorld.Web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class WalletController : Controller
    {
        private IUserService _userService;

        public WalletController(IUserService userService)
        {
            _userService = userService;
        }


        
        [Route("UserPanel/Wallet")]
        public IActionResult Index()
        {
            ViewBag.ListWallet = _userService.GetWalletUser(User.Identity.Name);
            // کیف پول کاربری را که خواسته شده ( از آیدنتیتی  گرفتی ) را به صورت لیست از یوزر سرویس  بگیر
            return View();
        }

        [Route("UserPanel/Wallet")]
        [HttpPost]
        public ActionResult Index(ChargeWalletViewModel charge)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ListWallet = _userService.GetWalletUser(User.Identity.Name);
                return View(charge);
            }

            int walletId = _userService.ChargeWallet(User.Identity.Name,charge.Amount,"شارژ حساب");

            #region Online Payment

            var payment = new ZarinpalSandbox.Payment(charge.Amount);  // قیمتی که باید انجام شود را به عنوان ورودی بگیرد 

            // در مرحله بعد باید به درگاه این مقدار را بفرستیم که درگاه به ما اوکی دهد و بعد ما را برگرداند . 

            var res =  payment.PaymentRequest("شارژ کیف پول", "https://localhost:44345/OnlinePayment/" + walletId, "f.studentcomputer@gmail.com", "09197070750");

            // PaymentRequest == یعنی باید به بانک اطلاه دهیم
            // https://localhost:44325/OnlinePayment == یعنی کارش که در درگاه تمام شد من را به اینجا بفرست یا برگردان
            // walletId == زمانی که کاربر به آنلاین پی منت برگردانده شد ، آیدی کیف پول مربوطه را هم به من بده که بدانیم مربوط به کدام تراکنش هست
            if (res.Result.Status == 100)  // با توجه به مستند بانک این کد نوشته میشود
            {
                // در خط بعد باید کاربر به بانک هدایت شود
                return Redirect("https://sandbox.zarinpal.com/pg/StartPay/" + res.Result.Authority);
            }

            #endregion


            return null;
        }
    }
}