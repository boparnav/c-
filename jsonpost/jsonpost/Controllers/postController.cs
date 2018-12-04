using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using jsonpost.Models;
using System.Web.Script.Serialization;

namespace jsonpost.Controllers
{
    public class postController : Controller
    {
        // GET: post
        public ActionResult Index()
        {
            using (WebClient wc = new WebClient())
            {
                var json = new WebClient().DownloadString("https://jsonplaceholder.typicode.com/posts");




                JavaScriptSerializer js = new JavaScriptSerializer();
                Blogpostm[] body = js.Deserialize<Blogpostm[]>(json);


                ViewBag.body = body;


                return View();
            }
        }

        [HttpGet]
        public string Index1 ()
        {
          var id= Request["id"];
            
            var json = new WebClient().DownloadString("https://jsonplaceholder.typicode.com/posts"+id);
                return json;

            }





        }




    }
