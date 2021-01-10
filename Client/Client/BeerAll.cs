/// Autores:    Rui Duarte 15831 | Carlos Silva 17028 | Daniel Silva  17637
/// Cadeira:    Integração de Sistemas de Informação
/// Curso:      LESI
/// Professor:  Luís Ferreira
/// Ano Létivo: 2020/2021
/// Cliente da API TP2

using System;
using System.Collections.Generic;
using System.Text;

namespace Client
{
    public class BeerAll
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Volume
        {
            public int value { get; set; }
            public string unit { get; set; }
        }

        public class Result
        {
            public int id { get; set; }
            public string name { get; set; }
            public string first_brewed { get; set; }
            public string description { get; set; }
            public string image_url { get; set; }
            public double abv { get; set; }
            public double? ph { get; set; }
            public double attenuation_level { get; set; }
            public Volume volume { get; set; }
            public List<string> food_pairing { get; set; }
            public string brewers_tips { get; set; }
        }

        public class Root
        {
            public List<Result> results { get; set; }
            public int nr_results { get; set; }
        }



    }
}
