using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace buggybites.Controllers
{
    public class Hang1Controller : Controller
    {
        // GET: /<controller>/

        public IActionResult Index()
        {
          

            return View("Index1");
        }


        [HttpPost]
        public IActionResult Index(string button)
        {
            System.DateTime start = System.DateTime.Now;

            DataLayer layer = new DataLayer();
            layer.GetFeaturedProducts();
            System.DateTime end = System.DateTime.Now;

            return View("Index",end.Subtract(start).Seconds + "." + end.Subtract(start).Milliseconds);
        }
    }
}
