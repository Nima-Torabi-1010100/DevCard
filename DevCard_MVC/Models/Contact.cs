using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است"),]
        [MinLength(3, ErrorMessage = "حداقل باید سه کاراکتر داشته باشد")]
        [MaxLength(20, ErrorMessage = "حداکثر باید بیست کاراکتر داشته باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        [EmailAddress(ErrorMessage = "ایمیل به درستی وارد نشده است")]
        public string Email { get; set; }
        public int Service { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        public string Message { get; set; }

        public SelectList Services;
    }
}
