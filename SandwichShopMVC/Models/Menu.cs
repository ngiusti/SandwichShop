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
       

        public virtual ICollection<Inventory> Inventory { get; set; }
      
    }
}