using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using jsonconvert.Models;
using System.Web.Script .Serialization;


namespace jsonconvert
{
    public class jsonController : Controller
    {
        // GET: json
      //  public String Index()
      //  {
           
              //  using (WebClient wc = new WebClient())
             //   {
                 //   var json = new WebClient().DownloadString("https://jsonplaceholder.typicode.com/photos");



                 //   return json.ToString();

              //  JavaScriptSerializer js = new JavaScriptSerializer();
              //  jsonfield[] album = js.Deserialize<jsonfield[]>(json);


               // }
            public ActionResult Index()
            {

                using (WebClient wc = new WebClient())
                {
                    var json = new WebClient().DownloadString("https://jsonplaceholder.typicode.com/photos");




                    JavaScriptSerializer js = new JavaScriptSerializer();
                    jsonfield[] album = js.Deserialize<jsonfield[]>(json);


                ViewBag.album = album;

                return View();
                }


           


            }
    }
}