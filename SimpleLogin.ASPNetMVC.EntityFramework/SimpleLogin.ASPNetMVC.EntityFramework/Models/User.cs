using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleLogin.ASPNetMVC.EntityFramework.Models
{
    public class User
    {
        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}