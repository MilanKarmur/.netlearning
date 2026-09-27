using practical6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace practical6.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            Product p1 = new Product();
            p1.Product_Id = 1;
            p1.Product_Name = "Iphune 18 duo";
            p1.Product_Price = 450000;
            p1.Product_Desc = "Not for 9 to 5 Peoples "+"Hafte nay Male Bhai" +"No Discount";
            p1.Product_Category = "Electronics";

            return View(p1);
        }
    }
}