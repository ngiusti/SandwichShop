using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandwichShopMVC.Models
{
    public class Inventory
    {
        public int ID { get; set; }
        public string InventoryName { get; set; }
        public int? Quantity { get; set; }

        public virtual Ingredients Ingredients { get; set; }
        public virtual Menu Menu { get; set; }
    }
}