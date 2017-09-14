using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DjWr.Web.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.test = "test";
            var models = new
            {
                name = "jx",
                age = 28
            };
            return View(models);
        }
    }
}