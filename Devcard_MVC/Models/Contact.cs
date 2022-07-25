using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Devcard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="این فیلد اجباری است.")]
        [MaxLength(100,ErrorMessage ="حداکثر تعاد کارکتر 100 می باشد.")]
        [MinLength(3 ,ErrorMessage ="حداقل تعداد کاراکتر 3 می باشد.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="پر کردن این فیلد اجباری است.")]
        [EmailAddress(ErrorMessage ="مقدار ایمیل را صحیح وارد نمایید.")]
        public string Email { get; set; }
        public string Message { get; set; }
        public string Service { get; set; }
    }
}
