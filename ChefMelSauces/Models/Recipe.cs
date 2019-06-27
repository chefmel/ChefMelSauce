using System;
using System.Collections.Generic;


namespace ChefMelSauces.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        //this is where my recipe TYPES is going to be appetizers, entree, etc
        public Type Type { get; set; }
    }
}
