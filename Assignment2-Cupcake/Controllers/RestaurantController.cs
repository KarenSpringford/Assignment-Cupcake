using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment2_Cupcake.Models;

namespace Assignment2_Cupcake.Controllers
{
    public class RestaurantController : Controller
    {
        //
        // GET: /Restaurant/
        public string Index()
        {
            return "Hello from Restaurant.Index()";
        }
        //
        // GET: /Restaurant/Browse
        public string Browse(string dessert)
        {
            string message = HttpUtility.HtmlEncode("Restaurant.Browse, Dessert " + dessert);

            return message;
        }
        //
        // GET: /Restaurant/Details
        public ActionResult Details(int id)
        {
            var dessert = new Dessert ("Desert " + id );
            return View(dessert);
        }
    }
}