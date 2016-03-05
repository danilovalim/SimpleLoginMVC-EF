using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleLogin.ASPNetMVC.EntityFramework.Models;

namespace SimpleLogin.ASPNetMVC.EntityFramework.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            if(Session["FirstName"]!=null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User u)
        {
            if(ModelState.IsValid)
            {
                try{
                    using (LoginContext db = new LoginContext())
                    {
                        db.user.Add(u);
                        db.SaveChanges();
                        return RedirectToAction("Login");
                    }
                }
                catch
                {
                    ViewBag.message = "Error, please try again!";
                    return View(u);
                }
            }
            else
            {
                return View(u);
            }
            
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User u)
        {
                using (LoginContext db = new LoginContext())
                {
                    User visitant = db.user.Where(x => x.UserName.Equals(u.UserName) && x.Password.Equals(u.Password)).FirstOrDefault();

                    if (visitant != null)
                    {
                        Session["FirstName"] = visitant.FirstName;
                        Session["LastName"] = visitant.LastName;
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(u);
                    }
                }
        }
    }
}