using DevCard_MVC.Data;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Diagnostics;

namespace DevCard_MVC.Controllers
{
    //[Route("/inventory/products")]
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new List<Service>()
        {
            new Service(1,"نقره‌ای"),
            new Service(2,"طلایی"),
            new Service(3,"پلاتین"),
            new Service(4,"الماس"),
        };

        //[Route("HomePage/{name:maxlength(5)}")]
        //[Route("HomePage")]
        public IActionResult Index(string name)
        {
            return View();
        }
        public IActionResult ProjectDetails(long id)
        {
            Project project = ProjectStore.GetProjectBy(id);
            if (project == null)
                return NotFound();
            return View("ProjectDetails", project);
        }

        //[HttpGet("ContactPage")]
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
            model = new Contact() { Services = new SelectList(_services, "Id", "Name") };
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
