using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DollsWorld.DataLayer.Entities.Wallet
{
    public class Wallet
    {
        public Wallet()
        {
            
        }
        [Key]
        public int WalletId { get; set; }  //کد شناسایی تراکنش

        [Display(Name = "نوع تراکنش")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int TypeId { get; set; }  //واریزی است یا برداشتی 

        [Display(Name = "کاربر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int UserId { get; set; }  // این تراکنش متعلق به کدام کاربر هست

        [Display(Name = "مبلغ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int Amount { get; set; }  // مبلغ تراکنش

        [Display(Name = "شرح")]
        [MaxLength(500, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Description { get; set; }

        [Display(Name = "تایید شده")]
        public bool IsPay { get; set; }  // وضعیت پرداخت

        [Display(Name = "تاریخ و ساعت")]
        public DateTime CreateDate { get; set; }

        // یک کاربر می تواند هر مقدار تراکنش داشته باشد ولی هر تراکنش می تواند متعلق به یک کاربر باشد
        // پس رابطه شان یک به چند هست 

        // برای فعال سازی lazy loading entity (virtual ) به cunstructor  نیاز داریم

        public virtual User.User User { get; set; }
        public virtual WalletType WalletType { get; set; }


    }
}
