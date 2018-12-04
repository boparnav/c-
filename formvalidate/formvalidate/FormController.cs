using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace formvalidate
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enrollment()
        {
            return View();
        }
        public Boolean isValidated()
        {
            return false;
        }
        [HttpPost]
        //   public String login()
        public ActionResult login()
        {
            var fname = Request["fname"];
            var lname = Request["lname"];
            var phonr = Request["tel"];
            var add = Request["Address"];
            var eml = Request["email"];
            var prog = Request["pgm"];
            var msg = "";
            bool isValidate = false;

            if (fname == "" || lname == "" || phonr == "" || add == "" || eml == "" || prog == "")
            {
                // return("Please enter valid info..");
                msg = "Validation error: please enter valid data";
                isValidate = false;
            }
            else
            {
                //  return("Information submitted successfully..");

                msg = "Validation successfull";
                isValidate = true;


            }
            ViewData["error_msg"] = msg;
            ViewBag.isValidate = isValidate;

            return View();

        }
    }
}