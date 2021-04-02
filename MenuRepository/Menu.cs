using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuRepository
{
    public class Menu
    {

        public int MealNumber { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public string Ingredients { get; set; } 
        public int Price { get; set; }
        public Menu()
        {

        }


        public Menu(string name, string description, int price, string ingredients)
        {
           // MealNumber = mealNumber;
            Name = name;
            Description = description;
            Price = price;
            Ingredients = ingredients;

        }
      


    }





    //A meal number, so customers can say "I'll have the #5"
    //A meal name
    //A description
    //A list of ingredients,
    //A price

}

