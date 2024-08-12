using DevCard_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace DevCard_MVC.Data
{
    public class ProjectStore
    {
        private static List<Project> _projects = new List<Project>
        {
            new Project(1,"Taxi","Lorem ipsum dolor sit amet.","SNAPP","project-1.jpg"),
            new Project(2,"University","Lorem ipsum dolor sit amet.","TAU","project-2.jpg"),
            new Project(3,"Airport","Lorem ipsum dolor sit amet.","Turkish Airlines","project-3.jpg"),
            new Project(4,"Gym","Lorem ipsum dolor sit amet.","Mola Gym","project-4.jpg"),
        };
        public static List<Project> GetProjects()
        {
            return _projects;
        }
        public static Project GetProjectBy(long id)
        {
            return GetProjects().FirstOrDefault(i => i.Id == id);
        }
    }
}
