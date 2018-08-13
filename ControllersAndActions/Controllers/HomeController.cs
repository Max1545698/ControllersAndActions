using ControllersAndActions.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View("SimpleForm");

        [HttpPost]
        public RedirectToActionResult ReceiveForm(string name, string city)
        {
            TempData["name"] = name;
            TempData["city"] = city;
            return RedirectToAction(nameof(Data));
        }

        public ViewResult Data()
        {
            string city = TempData.Peek("city") as string;
            string name = TempData["name"] as string;
            return View("Result", $"{name} lives in {city}");
        }
    }
}
