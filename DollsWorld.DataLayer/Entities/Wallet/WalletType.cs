using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DollsWorld.DataLayer.Entities.Wallet
{
    public class WalletType
    {
        public WalletType()
        {
            
        }

        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeId { get; set; }

        [Required]
        [MaxLength(150)]
        public string TypeTitle { get; set; }  // بدهکار یا بستانکار بودن با کد مربوطه

        public virtual List<Wallet> Wallets { get; set; }  // هر توع تایپی که واریزی هست یا برداشتی می تواند هر مقدار تراکنش داشته باشد 
    }
}
