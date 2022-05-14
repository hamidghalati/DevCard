using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [MinLength(3,ErrorMessage = "حداقل طول نام 3 کاراکتر می باشد")]
        [MaxLength(100,ErrorMessage = "حداکثر طول نام 100 کاراکتر می باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        [EmailAddress(ErrorMessage = "مقدار وارد شده ایمیل صحیح نیست")]
        public string Email { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        [NotNull]
        public string Message { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        [NotNull]
        public string Service { get; set; }
    }
}
