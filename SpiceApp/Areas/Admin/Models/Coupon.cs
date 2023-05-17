using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SpiceApp.Areas.Admin.Models
{
    [Table("Coupon_UKSARMA")]
    public class Coupon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CouponId { get; set; }

        [Required]
        public string CouponName { get; set; }

        [Required]
        public double DiscountAmount { get; set; }

       
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }
    }
}
