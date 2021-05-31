using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Web_App.Entities
{
    public class Productt
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name = "نام محصول")]
        [Required(ErrorMessage = "لطفا نام محصول وارد کنید")]
        public string ProductName { get; set; }
        [Display(Name = "عکس")]
        public string ImageName { get; set; }
        [Display(Name = "قیمت محصول")]
        [Required (ErrorMessage = "لطفا قیمت وارد کنید")]
        public int Price { get; set; }
        [Display(Name = "توضیح محصول")]
        [Required(ErrorMessage = "لطفا توضیحات وارد کنید")]
        public string Description { get; set; }
        [Display(Name = "تاریخ ثبت")]
        [Required(ErrorMessage ="لطفا تاریخ را انتخاب کنید")]
        public DateTime createdate { get; set; }

    }
}
