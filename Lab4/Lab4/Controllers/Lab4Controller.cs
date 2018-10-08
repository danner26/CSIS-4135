using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab4.Controllers {
    public class Lab4Controller : Controller {
        // GET: /<controller>/
        public IActionResult Index() {
            ViewData["TimePhrase"] = GetTimePhrase();

            return View("Index");
        }
        public IActionResult Waffles() {
            return View("Waffles");
        }


        public string GetTimePhrase() {
            if (DateTime.Now.Hour < 12) {
                return "Good Morning";
            } else if (DateTime.Now.Hour < 18) {
                return "Good Afternoon";
            } else {
                return "Good Evening";
            }
        }
    }
}
