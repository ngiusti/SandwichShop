using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SandwichShopMVC.Models
{
    /*
    public enum Items
    {
        Sourdough_Bread,
        Bacon,
        Lettuce,
        Tomato,
        Mayo,
        Rye_Bread,
        Corned_Beef,
        Sauerkraut,
        Thousand_Island_Dressing,
        Swiss_Cheese,
        French_Roll,
        Italian_Dressing,
        Pepperoni,
        Salami,
        Cappicola,
        Provolone,
        Onion,
        Roast_Beef,
        Peppers,
        Turkey,
        Ham,
        Cheddar,
        Mustard,
        Chicken_Salad,
        Hummus,
        Cucumber,
        Sprouts,
        Focaccia_Bread,
        White_Bread,
        Wheat_Bread,
        Pastrami
}
*/
    public class Menu
    {
        public int MenuID { get; set; }
        public string Name { get; set; }
        public string[] Ingredients { get; set; }
       

        public virtual ICollection<UpdateSales> Inventory { get; set; }
      
    }
}