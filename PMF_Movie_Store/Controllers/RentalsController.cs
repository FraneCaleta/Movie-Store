using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMF_Movie_Store.Controllers
{
    public class RentalsController : Controller
    {
        // GET: Rentals/New
        public ActionResult New()
        {
            return View();
        }
    }
}