using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCController2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Blogs()
        {
            return Content("Hi");
        }
        public ViewResult About()
        {
            return View();
        }
        public ContentResult Contact()
        {
            return Content("Hello");
        }
        public RedirectResult redirect()
        {
            return Redirect("https://www.google.com/");
        }
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult RedirectWithId()
        {
            return RedirectToRoute(new { controller = "Home", action = "Details", id = 1 });
        }
        public FileResult Index2()
        {
            return File(Url.Content(@"C:\Users\gangothri.a\Downloads\ADO.Net.txt"), "text/plain");
        }
        public FileResult Index3()
        {
            return File(Url.Content("~/Files/abc.txt"), "text/plain");
        }
        public JsonResult Getemp(int id)
        {
            var emp = new { Id = id, name = "gangu", sal = 12345 };
            return Json(emp, JsonRequestBehavior.AllowGet);
        }
        public JavaScriptResult msg()
        {
            string msg = "Hello";
            return JavaScript(msg);
        }
        public ActionResult login()
        {
            return View();
        }
        public ActionResult loginlist()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
        public ActionResult Registerhelper()
        {
            ViewBag.States =new SelectList(new List<string>
            {
                "Select",
                "Telangana",
                "Andhra Pradesh",
                "Kerala",
                "Tamil Nadu"
            });
            return View();
        }
        
    }
}