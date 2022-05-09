

using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1,"سی شارپ","آموزش سی شارپ"),
                new Article(2,"دلفی","آموزش دلفی"),
                new Article(3,"asp","آموزش asp"),
                new Article(4,"آفیس","آموزش آفیس"),
            };
            return View("_Articles",articles);
        }
    }
}
