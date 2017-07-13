using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandwichShopMVC.Models
{
    public class Menu
    {
        public int MenuID { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
       

        public virtual ICollection<UpdateSales> Inventory { get; set; }
      
    }
}