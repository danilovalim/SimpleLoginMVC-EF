using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleLogin.ASPNetMVC.EntityFramework.Models
{
    public class LoginContext : DbContext
    {
        public DbSet<User> user { get; set; }
    }
}