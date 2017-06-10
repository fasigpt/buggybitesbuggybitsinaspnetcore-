using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace buggybites.Controllers
{
    public class HangCPUController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            DataLayer datalayer = new DataLayer();
            System.Collections.Generic.Dictionary<int,int> dict= datalayer.GetAllProducts();

            string ProductsTable = "<table><tr><td><B>Product ID</B></td><td><B>Product Name</B></td><td><B>Description</B></td></tr>";

            foreach (var item in dict)
            {
                ProductsTable += "<tr><td>" + item.Key + "</td><td>" + item.Value + "</td><td>";
            }
            ProductsTable += "</table>";

            //tblProducts.Text = ProductsTable;

            return View();
        }
    }
}
