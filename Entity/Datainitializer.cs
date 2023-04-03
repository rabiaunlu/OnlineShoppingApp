using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;

namespace OnlineShopping.Entity
{
    public class Datainitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>
            {
                new Category(){Name = "KAMERA",Description="Kamera Ürünleri"},
                new Category(){Name = "BİLGİSAYAR",Description="Bilgisayar Ürünleri"}
            };
            foreach(var item in kategoriler)
            {
               context. Categories.Add(item);
            }
            context.SaveChanges();
            var urunler = new List<Product>
            {
             new Product(){Name="Canon",Description="Kamera",Price=2500,Stock=50,IsHome=true,CategoryId=1,Image="camera1.jpg",IsApproved=true,IsFeatured=false},
             new Product(){Name="Asus Bilgisayar",Description="Asus Bilgisayar Ürünleri",Price=2500,Stock=10,IsHome=true,CategoryId=2,Image="pc1.jpg",IsApproved=true,IsFeatured=true},
             new Product(){Name="Casper Bilgisayar",Description="Casper Bilgisayar Ürünleri",Price=2500,Stock=150,IsHome=true,CategoryId=2,Image="pc2.jpg",IsApproved=true,IsFeatured=true}
            };
            foreach(var item in urunler)
            {
                context.Products.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}