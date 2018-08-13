using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {

        public StatusCodeResult Index() =>
            StatusCode(StatusCodes.Status404NotFound); //NotFound()

        //public VirtualFileResult Index()
        //     => File("lib/bootstrap/dist/css/bootstrap.css", "text/css");

        public ViewResult Result() => View((object)"Hello World");

        public RedirectToActionResult Redirect() =>
            RedirectToAction(nameof(HomeController.Index), nameof(HomeController));
    }
}