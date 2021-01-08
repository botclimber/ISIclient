using System;
using System.Collections.Generic;
using System.Text;

namespace Client
{
    public class IngredientsInfo
    {
        public class Ingredient
        {
            public int id { get; set; }
            public string name { get; set; }
            public int calories { get; set; }
            public string type { get; set; }
            public string created_at { get; set; }
        }

        public class Content
        {
            public List<object> recipes { get; set; }
            public Ingredient ingredient { get; set; }
        }

        public class Root
        {
            public List<Content> content { get; set; }
            public int total_results { get; set; }
        }
    }
}
