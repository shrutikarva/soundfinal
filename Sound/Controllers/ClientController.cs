using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sound.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult profile()
        {
            return View();

        }
        public ActionResult editprofile()
        {
            return View();

        }
        public ActionResult searchtalent() {
            return View(); 
        }
        public ActionResult calendar()
        {
            return View();

        }
        public ActionResult groups() {
            return View();
        }

        public ActionResult SearchFunctions() {
            return View(); ;
        }

        public ActionResult account()
        {
            return View();
        }
        public ActionResult logout()
        {
            return View();    
        }
    }
}