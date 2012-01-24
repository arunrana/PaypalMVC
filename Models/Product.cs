using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaypalMVC.Models
{
    public class Product 
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        public virtual  Category  category { get; set; }
    }
}