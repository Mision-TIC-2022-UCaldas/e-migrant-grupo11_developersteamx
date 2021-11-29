using System;
using System.Linq;
using System.Collections.Generic;
using EMigrant.App.Dominio;

namespace EMigrant.App.Dominio{
    public class Articulo{
        public int id { get; set; }
        public string activor { get; set; }
        public string tituloArticulo { get; set; }
        public string fechaNovedad { get; set; }
        public string diasArticulo { get; set; }
        public string textoArticulo { get; set; }
    }
}