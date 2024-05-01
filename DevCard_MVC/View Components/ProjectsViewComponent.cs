using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.View_Components
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Project> projects = new List<Project>()
            {
                new Project(1,"موزیک","سایتی برای گوش دادن و دانلود جدید ترین موزیک های ایران و جهان","Spotify","project-1.jpg"),
                new Project(2,"فودشاپ","درخواست آنلاین غذا از سراسر کشور","Snapp","project-2.jpg"),
                new Project(3,"دانشگاه","سیستم مدیریت یکپارچه دانشگاه ها","SADA","project-3.jpg"),
                new Project(4,"فیلم","سایتی برای تماشا و دانلود جدید ترین فیلم های ایران و جهان","TinyMovies","project-4.jpg")
            };
            return View("_projects", projects);
        }
    }
}
