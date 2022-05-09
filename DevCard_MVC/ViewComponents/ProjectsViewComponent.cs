
using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Projects>
            {
                new Projects(1, "تاکسی", "درخواست خودرو درون شهری", "اسنپ"),
                new Projects(2, "زودفود", "درخواست خودرو درون شهری", "ZoodFood"),
                new Projects(3, "مدارس", "درخواست خودرو درون شهری", "MONOP"),
                new Projects(4, "فضاپیما", "درخواست خودرو درون شهری", "Nasa"),
            };
            return View("_Projects",projects);
        }
    }
}
