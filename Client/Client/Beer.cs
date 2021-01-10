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
    public class Beer
    {
        
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

        public class RootRecomended
        {
            public string food { get; set; }
            public Beers beers { get; set; }
        }

        public class Temp
        {
            public int value { get; set; }
            public string unit { get; set; }
        }

        public class MashTemp
        {
            public Temp temp { get; set; }
            public object duration { get; set; }
        }

        public class Fermentation
        {
            public Temp temp { get; set; }
        }

        public class Method
        {
            public List<MashTemp> mash_temp { get; set; }
            public Fermentation fermentation { get; set; }
            public object twist { get; set; }
        }

        public class Amount
        {
            public double value { get; set; }
            public string unit { get; set; }
        }

        public class Malt
        {
            public string name { get; set; }
            public Amount amount { get; set; }
        }

        public class Hop
        {
            public string name { get; set; }
            public Amount amount { get; set; }
            public string add { get; set; }
            public string attribute { get; set; }
        }

        public class Ingredients
        {
            public List<Malt> malt { get; set; }
            public List<Hop> hops { get; set; }
            public string yeast { get; set; }
        }

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
            public Method method { get; set; }
            public Ingredients ingredients { get; set; }
            public Volume volume { get; set; }
            public List<string> food_pairing { get; set; }
            public string brewers_tips { get; set; }
        }
        public class ResultRandom
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

        public class RootBeerDetail
        {
            public List<Result> results { get; set; }
        }

        public class RootBeerRandom
        {
            public List<ResultRandom> results { get; set; }
        }


    }
}
