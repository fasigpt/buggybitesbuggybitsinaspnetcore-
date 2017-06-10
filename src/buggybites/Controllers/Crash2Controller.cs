using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace buggybites.Controllers
{
    public class Crash2Controller : Controller
    {

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string emailid)
        {
            BuggyMail mail = new BuggyMail();
            mail.SendEmail(emailid, "whocares-at-buggymail");

            return View();
        }
    }
}
