using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Devcard_MVC.Controllers
{
    public class TestController : Controller
    {
        //public IActionResult Index()
        //{
        //    return PartialView("footer");
        //}
        //public PartialViewResult Index()
        //{
        //    return PartialView("footer");
        //}
        //public IActionResult Index()
        //{
        //    return View("footer");
        //}
        //public ContentResult Index()
        //{
        //    //return Content("<h1>Hello Asp.net core MVC student</h1>" ,"text/html");
        //    return Content($"<h1>Hello Asp.net core MVC student</h1><script> confirm('این سوال من است؟');</script>","text/html");
        //}
        //public IActionResult Index()
        //{
        //    //return Content("<h1>Hello Asp.net core MVC student</h1>" ,"text/html");
        //    return Content($"<h1>Hello Asp.net core MVC student</h1><script> confirm('این سوال من است؟');</script>", "text/html");
        //}
        //public EmptyResult Index()
        //{
        //    return new EmptyResult();
        //    //return null;
        //}
        //public FileResult Index()
        //{
        //    //return File("~/text.txt", "text/html");
        //    var filebyte = System.IO.File.ReadAllBytes("wwwroot/text.txt");
        //    const string filename = "textfile.txt";
        //    return File(filebyte, MediaTypeNames.Text.Plain, filename);


        //}

        //public JsonResult Index()
        //{
        //    return Json(new
        //    {
        //        id = 1,
        //        name = "mahin",
        //        site = "Shabani.com",
        //        job = "programmer"
        //    });
        //}
        //public JavascriptResult Index()
        //{
        //    return new JavascriptResult("alert('salam!!!')");
        //}
        //public RedirectResult Index()
        //{
        //    return Redirect("/*http://www.atriya.com*/");
        //}
        //public RedirectToActionResult Index()
        //{
        //    return RedirectToAction("Contact","home");
        //}

        public IActionResult Index()
        {
            //return new OkResult();
            //return new NotFoundResult();
            //return new BadRequestResult();
            //return new NoContentResult();
            return new StatusCodeResult(510);
        }

    }

    //public class JavascriptResult:ContentResult
    //{
    //    public JavascriptResult(string data)
    //    {
    //        Content = data;
    //        ContentType = "application/javascript";
    //    }
    //}
}
