using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandwichShopMVC.Models
{
    public enum Category
    {
        Bread,
        Protein,
        Dairy,
        Produce,
        Beverage,
        Condiment,
        Side
    }

    public class Tab
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Visible { get; set; }
        public string Url { get; set; }
    }

    public class Ingredients
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public double Quantity { get; set; }
        public Category Category { get; set; }

        public virtual ICollection<Inventory> Inventory { get; set; }
           
    }
}