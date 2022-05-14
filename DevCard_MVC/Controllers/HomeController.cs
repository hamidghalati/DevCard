using System;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mime;


namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        

        public HomeController()
        {
           
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var model = new Contact();
            return View();
        }

        [HttpPost]
        public JsonResult Contact(Contact form)
        {
            Console.WriteLine(form.ToString());
            return Json(Ok());
        }

        public FileResult test()
        {
            var fileByte = System.IO.File.ReadAllBytes("wwwroot/test.txt");
            const string fileName = "testFile.txt";
            return File(fileByte, MediaTypeNames.Text.Plain, fileName);
        }

        public IActionResult Result()
        {
            return new StatusCodeResult(401);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
