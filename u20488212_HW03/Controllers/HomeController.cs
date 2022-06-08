using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace u20488212_HW03.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string ftype, HttpPostedFileBase file)
        {
            try
            {
                if (file.ContentLength > 0)
                {
                    string _FileName = Path.GetFileName(file.FileName);
                    if (ftype == "Document")
                    {
                        string _path = Path.Combine(Server.MapPath("~/Media/Documents"), _FileName);
                        file.SaveAs(_path);
                    }
                    else if (ftype == "Image")
                    {
                        string _path = Path.Combine(Server.MapPath("~/Media/Images"), _FileName);
                        file.SaveAs(_path);
                    }
                    else
                    {
                        string _path = Path.Combine(Server.MapPath("~/Media/Videos"), _FileName);
                        file.SaveAs(_path);
                    }

                }
                ViewBag.Message = "File uploaded successfully";
                return View();
            }
            catch
            {
                ViewBag.Message = "File upload failed";
                return View();
            }
        }

        public ActionResult Files()
        {
            ViewBag.Message = "Your Files page.";

            return View();
        }

        public ActionResult Images()
        {
            ViewBag.Message = "Your Images page.";

            return View();
        }

        public ActionResult Videos()
        {
            ViewBag.Message = "Your Videos page.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your About page.";

            return View();
        }
    }
}