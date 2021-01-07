using System;
using System.Collections.Generic;
using System.Text;

namespace Client
{
    public class Recipes
    {
        public class Result
        {
            public int id { get; set; }
            public int calories { get; set; }
            public int carbs { get; set; }
            public int fat { get; set; }
            public int protein { get; set; }
            public int fiber { get; set; }
            public string image { get; set; }
            public string imageType { get; set; }
            public string title { get; set; }
        }

        public class Root
        {
            public List<Result> results { get; set; }
            public int nr_results { get; set; }
        }

        public class Key
        {
            public string token { get; set; }
            public string user_type { get; set;}
        }
    }
}
