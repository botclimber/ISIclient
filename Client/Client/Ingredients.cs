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
