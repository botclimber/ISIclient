using System;
using System.Collections.Generic;
using System.Text;

namespace Client
{
    public class RecipeInfo
    {
        public class Ingredient
        {
            public int id_ingredient { get; set; }
            public string name { get; set; }
            public int ingredient_calories { get; set; }
            public string type { get; set; }
            public int amount { get; set; }
        }

        public class Recipe
        {
            public string id { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string instructions { get; set; }
            public string image_link { get; set; }
            public int @public { get; set; }
            public int calories { get; set; }
            public int fat { get; set; }
            public int protein { get; set; }
            public int fiber { get; set; }
            public List<Ingredient> ingredients { get; set; }
        }

        public class Root
        {
            public List<Recipe> recipe { get; set; }
        }
    }
}
