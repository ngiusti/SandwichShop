using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SandwichShopMVC.Models;

namespace SandwichShopMVC.DAL
{
    public class RestaurantInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<RestaurantEntities>
    {
        protected override void Seed(RestaurantEntities context)
        {
            // Adding to the Ingredient Model to populate table with Mock Data
            var listOfIngredients = new List<Ingredients>
            {
            new Ingredients { Name = "Ham", Quantity = 6, Cost = 2, Category=Category.Protein},
            new Ingredients { Name = "Sourdough", Quantity = 2, Cost = 1.5, Category=Category.Bread},
            new Ingredients { Name = "Swiss", Quantity = 65, Cost = 2, Category=Category.Dairy},
            new Ingredients { Name = "Spicy Brown Mustard", Quantity = 162, Cost = .25, Category=Category.Condiment},
            new Ingredients { Name = "Pickle", Quantity = 16, Cost = .50, Category=Category.Side},
            new Ingredients { Name = "Dr. Pepper", Quantity = 316, Cost = 1.50, Category=Category.Beverage},
            new Ingredients { Name = "Turkey", Quantity = 6, Cost = 2, Category=Category.Protein},
            new Ingredients { Name = "Salami", Quantity = 6, Cost = 2, Category=Category.Protein},
            new Ingredients { Name = "Roast Beef", Quantity = 6, Cost = 2, Category=Category.Protein},
            new Ingredients { Name = "Pepperoni", Quantity = 6, Cost = 2, Category=Category.Protein},

            };

            listOfIngredients.ForEach(s => context.Ingredients.Add(s));
            context.SaveChanges();

            // Adding to the Menu Model to populate table with Mock Data
            var menuItems = new List<Menu>
            {
            new Menu{ MenuID = 001, Name = "Ham N' Swiss"},
            new Menu{ MenuID = 001, Name = "Classic Italian"},
            new Menu{ MenuID = 001, Name = "All American"},
            new Menu{ MenuID = 001, Name = "Veggie"},
            new Menu{ MenuID = 001, Name = "The Earl's Club"},
            new Menu{ MenuID = 001, Name = "The Hunter's Bounty"},
            new Menu{ MenuID = 001, Name = "El Cubano"},
            };
            menuItems.ForEach(s => context.Menu.Add(s));
            context.SaveChanges();

            // Adding to the Inventory Model to populate table with Mock Data
            var inventoryCount = new List<Inventory>
            {
            new Inventory{ InventoryName = "Ham", Quantity = 6},
            new Inventory{ InventoryName = "Turkey", Quantity = 16},
            new Inventory{ InventoryName = "Swiss", Quantity = 63},
            new Inventory{ InventoryName = "Cheddar", Quantity = 26},
            new Inventory{ InventoryName = "Roast Beef", Quantity = 18},
            new Inventory{ InventoryName = "Pickle", Quantity = 68},
            new Inventory{ InventoryName = "Spicy Brown Mustard", Quantity = 46},
            };
            inventoryCount.ForEach(s => context.Inventory.Add(s));
            context.SaveChanges();
        }
    }
}