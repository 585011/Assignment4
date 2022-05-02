using BookRoom.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookRoom.Models;

namespace BookRoom.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Customers login)
        {
            if (ModelState.IsValid)
            {
                oblig4Entities9 db = new oblig4Entities9();
                var user = (from userlist in db.Customers
                            where userlist.CustomersID == login.CustomersID && userlist.pass == login.pass
                            select new
                            {
                                userlist.CustomersID
                            }).ToList();
                if (user.FirstOrDefault() != null)
                {
                    Session["CustomersID"] = user.FirstOrDefault().CustomersID;
                    return Redirect("/bookings/index");
                }
                

                else
                {
                    ModelState.AddModelError("", "Feil informasjon, prøv på nytt!");
                }
            }
            return View(login);
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}