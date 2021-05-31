using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Web_App.Entities
{
    public class SendMessage
    {
        [Key]
        public int SendId { get; set; }
        [Display(Name ="نام کاربر")]
        [Required(ErrorMessage ="لطفا نام کاربری را وارد کنید")]
        public string FullName { get; set; }
        [Display(Name ="ایمیل")]
        [EmailAddress(ErrorMessage ="لطفا ایمیل را در ست وارد کنید")]
        public string Email { get; set; }
        [Display(Name ="متن ایمیل")]
        [Required(ErrorMessage = "لطفا یک متن وارد کنید")]
        public string Text { get; set; }
    }
}
