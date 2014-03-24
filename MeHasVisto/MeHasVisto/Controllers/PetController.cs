using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeHasVisto.Controllers
{
    public class PetController : Controller
    {
        //
        // GET: /Pet/

        public ActionResult Index()
        {
            return View();
        }

        public string Display()
        {
            
            var name = (string)RouteData.Values["id"];
           
           //var model = //PetManagement.GetByName(name);
            //if (model == null)
             //return RedirectToAction("NotFound");
            //return View(model);

            //var act = (string)RouteData.Values["action"];
            //var controller = (string)RouteData.Values["controller"];

            return name;//+"/"+act+"/"+controller+"/";
        }
        public ActionResult NotFound()
        {
            return View();
        }

        public FileResult DownLoadPicture()
        {
            var name = (string)RouteData.Values["id"];
            var picture = @"C:\Users\Linet\Pictures/" + name + ".jpg";
            //var picture = "/Content/Uploads/" + name + ".jpg";
            var contentType = "image/jpg";
            var fileName = name + ".jpg";
            return File(picture, contentType, fileName);
        }
    }
}
