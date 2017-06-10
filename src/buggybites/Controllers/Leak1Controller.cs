using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace buggybites.Controllers
{
    public class Leak1Controller : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(string Product)
        {
           
            DataLayer dl = new DataLayer();
            Product p = dl.GetProductInfo(Product);
            return View("Index", p.shippingInfo.DaysToShip.ToString() + " days");
        }
    }
}
