using DevCard_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Mime;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly List<Service> _services = new List<Service>()
        {
            new Service(1,"نقره‌ای"),
            new Service(2,"طلایی"),
            new Service(3,"پلاتین"),
            new Service(4,"الماس"),
        };

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            Contact model = new Contact()
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            return View(model);
        }


        //public JsonResult Contact(IFormCollection form)
        //{
        //    //string text = form["message"];
        //    //System.IO.File.WriteAllText("wwwroot/message.txt", text);
        //    //return File("message.txt", MediaTypeNames.Text.Html, "message.txt");
        //    return Json(Ok());
        //}

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            model.Services = new SelectList(_services, "Id", "Name");
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نمی‌باشد، لطفا دوباره تلاش کنید.";
                return View(model);
            }

            ModelState.Clear();
            model = new Contact() { Services = new SelectList(_services, "Id","Name") };
            ViewBag.success = "پیام شما با موفقیت ارسال شد.";
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
