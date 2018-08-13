using ControllersAndActions.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace ControllersAndActions.Tests
{
    public class ActionTests
    {
        //[Fact]
        //public void ViewSelected()
        //{
        //    HomeController controller = new HomeController();

        //    ViewResult result = controller.ReceiveForm("Max", "London");

        //    Assert.Equal("Result", result.ViewName);
        //}

        //[Fact]
        //public void ModelObjectType()
        //{
        //    ExampleController controller = new ExampleController();

        //    ViewResult result = controller.Index();

        //    Assert.IsType<string>(result.ViewData["Message"]);
        //    Assert.Equal("Hello", result.ViewData["Message"]);
        //    Assert.IsType<DateTime>(result.ViewData["Date"]);
        //}


        //[Fact]
        //public void JsonActionMethod()
        //{
        //    ExampleController controller = new ExampleController();
        //    JsonResult result = controller.Index();

        //    Assert.Equal(new[] {"Alice","Bob","Joe" }, result.Value);
        //}

        [Fact]
        public void NotFoundActionMethod()
        {
            ExampleController controller = new ExampleController();

            StatusCodeResult result = controller.Index();

            Assert.Equal(404, result.StatusCode);
        }
        [Fact]
        public void Redirect()
        {
            ExampleController controller = new ExampleController();

            RedirectToActionResult result = controller.Redirect();

            Assert.Equal("HomeController", result.ControllerName);
            Assert.Equal("Index", result.ActionName);
            Assert.False(result.Permanent);
        }

    }
}
