using System;
using System.Collections.Generic;
using System.Text;

namespace Client
{
    public class Beer
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class BeerInfo
        {
            public int id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public double abv { get; set; }
            public string first_brewed { get; set; }
            public string fermentation { get; set; }
        }

        public class Beers
        {
            public int results { get; set; }
            public List<BeerInfo> beer_info { get; set; }
        }

        public class Root
        {
            public string food { get; set; }
            public Beers beers { get; set; }
        }
    }
}
