using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI___Assignment_Prototype.Class
{
   public class FoodAndDrinks
    {
    
        
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public FoodAndDrinks(string name, int quantity, double price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }
}
