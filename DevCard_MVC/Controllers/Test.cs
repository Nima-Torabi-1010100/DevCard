using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Mime;

namespace DevCard_MVC.Controllers
{
    public class Test : Controller
    {
        //public IActionResult Index()
        //{
        //    return PartialView("Footer");
        //}
        //public PartialViewResult Index()
        //{
        //    return PartialView("Footer");
        //}

        //public IActionResult Index()
        //{
        //    return Content("<h1 style=\"color: red;\">Hello</h1><script>confirm('Do You Want to Continue?')</script>","text/html");
        //}

        //public IActionResult Index()
        //{
        //    return new EmptyResult();
        //}

        public FileResult Index()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes("wwwroot/Video.mp3");
            string fileName = "Music.mp3";
            return File(fileBytes, "audio/mpeg", fileName);
        }

        //public FileResult Index()
        //{
        //    //return File("~/Video.mp3", "audio/mpeg");
        //    byte[] fileBytes = System.IO.File.ReadAllBytes("wwwroot/Video.mp3");
        //    string fileName = "Music.mp3";
        //    return File(fileBytes, MediaTypeNames., fileName);

        //}

        //public JsonResult Index()
        //{
        //    return Json(new
        //    {
        //        Id = 7,
        //        Name = "Nima",
        //        Family = "Torabi"
        //    });
        //}

        //public JavaScriptResult Index()
        //{
        //    return new JavaScriptResult("alert('salam salam!')");
        //}

        //Redirection Result
        //public RedirectResult Index2()
        //{
        //    return Redirect("https://google.com");
        //}
        //public RedirectToActionResult RedirectTo()
        //{
        //    return RedirectToAction("Contact","Home");
        //}


        //HTTP Status Code Result
        public IActionResult IndexHTTP()
        {
            //return new NotFoundResult();
            //return new OkResult();
            //return Unauthorized();
            return StatusCode(505);
        }

    }
    //public class JavaScriptResult : ContentResult
    //{
    //    public JavaScriptResult(string data)
    //    {
    //        Content = data;
    //        ContentType = "text/javascript";
    //    }
    //}
}
