using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fileuploadproject.Models;

namespace fileuploadproject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddImage()
        {
            Brand b1 = new Brand();

            return View(b1);
        }
        [HttpPost]
        public ActionResult AddImage(Brand model,HttpPostedFileBase image1)
        {
            UploadimageDBEntities db = new UploadimageDBEntities();
            if (image1 != null)
            {
                model.BrandImage = new byte[image1.ContentLength];
                image1.InputStream.Read(model.BrandImage, 0, image1.ContentLength);

            }
            db.Brands.Add(model);
            db.SaveChanges();
          

            return View(model);
        }
        [HttpGet]
        public ActionResult AddImage(int id)
        {
            Brand image1 = new Brand();
            using (UploadimageDBEntities db = new UploadimageDBEntities()) {
                image1 = db.Brands.Where(x => x.BrandId == id).FirstOrDefault();
            
            }
            return View(image1);
        }


            public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}