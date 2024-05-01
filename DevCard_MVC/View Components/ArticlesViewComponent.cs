using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.View_Components
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Article> articles = new List<Article>()
            {
                new Article(1,"Top 3 JavaScript Frameworks" , "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean\r\n" +
                "commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis\r\n" +
                "parturient...","blog-post-thumb-card-1.jpg"),
                new Article(2,"About Remote Working", "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean\r\n" +
                "commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis\r\n" +
                "parturient...","blog-post-thumb-card-2.jpg"),
                new Article(3,"A Guide To Becoming a Full-Stack Developer", "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean\r\n" +
                "commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis\r\n" +
                "parturient...","blog-post-thumb-card-3.jpg"),
                new Article(4,"آموزش Docker", "کامل ترین آموزش داکر به زبان فارسی!","blog-post-thumb-card-4.jpg")
            };
            return View("_articles", articles);
        }
    }
}

