using SandwichShopMVC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SandwichShopMVC.Models
{
    public class BigViewModel
    {
        
        public RestaurantEntities db = new RestaurantEntities();
        
        public List<Ingredients> Ingredients { get; set; }
        public Menu Menu { get; set; }
    }
}