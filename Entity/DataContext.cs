﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineShopping.Entity
{
    public class DataContext:DbContext
    {
        public DataContext():base("dataConnection")
        { 
            Database.SetInitializer(new Datainitializer());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


    }
}