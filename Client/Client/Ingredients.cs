using System;
using System.Collections.Generic;
using System.Text;

namespace Client
{
    public class Ingredients
    {
        public class Content
        {
            public int id { get; set; }
            public string name { get; set; }
            public string type { get; set; }
        }

        public class Root
        {
            public List<Content> content { get; set; }
            public int nr_results { get; set; }
        }
    }
}
