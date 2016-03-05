using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleLogin.ASPNetMVC.EntityFramework.Models
{
    public class User
    {
        public int UserID { get; set; }

        [Required(ErrorMessage ="Please, type your Name!")]
        [Display(Name ="First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please, type your Last Name!")]
        [Display(Name ="Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please, type a valid User Name!")]
        [Display(Name ="Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please, insert a valid Password!")]
        [MinLength(6, ErrorMessage ="Password must have at least 6 characters!")]
        [MaxLength(10, ErrorMessage ="Password must have at most 10 characters!")]
        [Display(Name ="Password")]
        public string Password { get; set; }
    }
}