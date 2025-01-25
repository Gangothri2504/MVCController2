//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace MVCController2.Controllers
//{
//    public class RegisterController : Controller
//    {

//        public ActionResult Formcontroller()
//        {
//            ViewBag.states = new SelectList(new List<string> 
//            { 
//                "Select",
//                "Andhra Pradesh", 
//                "Telangana", 
//                "Kerala" 
//            });
//            return View();
//        }
//        [HttpPost]
//        public ActionResult Formcontroller(FormCollection fobj)
//        {
//            Response.Write("name:" + fobj["namelabel"]);
//            Response.Write("username:" + fobj["userlabel"]);
//            Response.Write("mail:" + fobj["maillbl"]);
//            Response.Write("pws:" + fobj["pwdlabel"]);
//            Response.Write("gender:" + fobj["genderlbl"]);
//            Response.Write("state:" + fobj["statelabel"]);
//            //Response.Write("robot:" + fobj["check"] == "true, false");
//            if (fobj["check"] == "true")
//            {
//                Response.Write("Registration successful.<br>");
//            }
//            else
//            {
//                Response.Write("Please confirm you are not a robot.<br>");
//            }

//            return View();
//        }   
//    }
//}

using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCController2.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Formcontroller
        public ActionResult Formcontroller()
        {
            ViewBag.states = new SelectList(new List<string>
            {
                "Select",
                "Andhra Pradesh",
                "Telangana",
                "Kerala"
            });

            return View();
        }

        [HttpPost]
        public ActionResult Formcontroller(FormCollection fobj)
        {
            string name = fobj["name"];
            string username = fobj["uname"];
            string email = fobj["mail"];
            string password = fobj["pwd"];
            string gender = fobj["gender"];
            string state = fobj["statelabel"];
            bool isRobot = fobj["checkbox"] == "true,false";

            Response.Write($"Name: {name}<br>");
            Response.Write($"Username: {username}<br>");
            Response.Write($"Email: {email}<br>");
            Response.Write($"Password: {password}<br>");
            Response.Write($"Gender: {gender}<br>");
            Response.Write($"State: {state}<br>");

            if (isRobot)
            {
                Response.Write("Registration successful.<br>");
            }
            else
            {
                Response.Write("Please confirm you are not a robot.<br>");
            }

            return View();
        }
    }
}
