using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_MVC.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var _articles = new List<Article>()
            {
                new Article(1,"Top 3 JavaScript Frameworks","Lorem ipsum dolor sit amet.","blog-post-thumb-card-1.jpg"),
                new Article(2,"About Remote Working","Lorem ipsum dolor sit amet.","blog-post-thumb-card-2.jpg"),
                new Article(3,"A Full Guide to Becoming a Full-Stack Developer","Lorem ipsum dolor sit amet.","blog-post-thumb-card-3.jpg"),
                new Article(4,"A Guide to Becoming a Web Developer","Lorem ipsum dolor sit amet.","blog-post-thumb-card-4.jpg"),
            };
            return View("_Articles", _articles);
        }
    }
}
