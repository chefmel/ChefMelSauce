using System;
using System.Collections.Generic;


namespace ChefMelSauces.Models
{
    public class Product
    {
        public int ID {get; set;}
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<Merchant> Merchants { get; set; }
        public IList<Recipe> Recipes { get; set; }
        public string Ingredients { get; set; }
        public string NutritionValue { get; set; }
        public string Thumbnail { get; set; }



    }
}
