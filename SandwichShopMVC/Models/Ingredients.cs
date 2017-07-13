using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

    public class Ingredients
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public double Cost { get; set; }
        public double Quantity { get; set; }
        public Category Category { get; set; }

        public virtual IEnumerable<UpdateSales> Inventory { get; set; }
        public virtual IEnumerable<Menu> Menu { get; set; }

    }
}