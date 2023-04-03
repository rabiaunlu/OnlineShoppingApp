using OnlineShopping.Entity;
using OnlineShopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopping.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            var urun = db.Products.Where(i => i.IsHome && i.IsApproved).Select(i => new ProductModel()
            {
                Id = i.Id,
                Name = i.Name,
                Description = i.Description.Length > 25 ? i.Description.Substring(0,20)+"...":i.Description,
                Price= i.Price,
                Stock = i.Stock,
                Image= i.Image,
                CategoryId=i.CategoryId
            }
            ).ToList();
            return View(urun);
        }
        public ActionResult ProductDetail(int id) 
        { 
            return View(db.Products.Where(i=>i.Id==id).FirstOrDefault()); 
        
        }
        public ActionResult Product()
        {
            return View(db.Products.ToList());

        }
    }

}