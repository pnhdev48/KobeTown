using KobeTown.Models;
using KobeTown.Models.EFcodeFirts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KobeTown.Areas.Admin.Controllers
{
    public class ProductImageController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/ProductImage
        public ActionResult Index(int id)
        {
            ViewBag.ProductId = id;
            var items =db.ProductImages.Where(x => x.ProductId == id).ToList();
            return View(items);
        }
        [HttpPost]
        public ActionResult CreateImage(int productId,string url)
        {
            db.ProductImages.Add(new ProductImage
            {
                ProductId = productId,
                Image = url,
                IsDefault = false
            }); 
            db.SaveChanges();
            return Json(new { success = true} );
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.ProductImages.Find(id);
            db.ProductImages.Remove(item);
            db.SaveChanges();
            return Json(new { success = true});
        }
    }
}