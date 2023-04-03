using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShopping.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }//ürünün adedi
        public string Image { get; set; }
        public bool Slider { get; set; }//slayt içinde görünüyor mu
        public bool IsHome { get; set; }//ana sayfada görünüyor mu
        public bool IsApproved { get; set; }//ürün onaylı mı--> true : onaylı ise ürün satışta , false : ürün listelenmiyor.
        public bool IsFeatured { get; set; }//öne çıkan ürün mü?
        public int CategoryId { get; set; }//her ürünün bir kategorisi olmalı
        public virtual Category Category { get; set; }//bir kategorinin birden fazla ürünü olabilir ancak her ürünün ait olduğu kategori tipinde yalnızca bir kategori olmalı








    }
}