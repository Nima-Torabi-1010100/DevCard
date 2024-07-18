using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var _projects = new List<Project>()
            {
                new Project(1,"Taxi","Lorem ipsum dolor sit amet.","SNAPP","project-1.jpg"),
                new Project(2,"University","Lorem ipsum dolor sit amet.","TAU","project-2.jpg"),
                new Project(3,"Airport","Lorem ipsum dolor sit amet.","Turkish Airlines","project-3.jpg"),
                new Project(4,"Gym","Lorem ipsum dolor sit amet.","Mola Gym","project-4.jpg"),
            };
            return View("_Projects",_projects);
        }
    }
}
