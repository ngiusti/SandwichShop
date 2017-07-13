using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SandwichShopMVC.DAL;
using System.Data.Entity;


namespace SandwichShopMVC.Models
{
    public class UpdateSales
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }

        public virtual Ingredients Ingredients { get; set; }
        public virtual Menu Menu { get; set; }
    }
}