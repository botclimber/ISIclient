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

        public class Recipe
        {
            public int recipe_id { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string image_link { get; set; }
        }

        public class Content
        {
            public Ingredient ingredient { get; set; }
            public List<Recipe> recipes { get; set; }
        }

        public class Root
        {
            public List<Content> content { get; set; }
            public int total_results { get; set; }
        }
    }
}
