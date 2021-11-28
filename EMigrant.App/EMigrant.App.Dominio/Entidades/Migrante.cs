using System;
using System.Linq;
using System.Collections.Generic;
using EMigrant.App.Dominio;

namespace EMigrant.App.Dominio{
    public class Migrante{
        public int id { get; set; }
        public string activor { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string tdocumento { get; set; }
        public string nodocumento { get; set; }
        public string paisorigen { get; set; }
        public string fechanacimiento { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string direciona { get; set; }
        public string ciudad { get; set; }
        public string situacionlaboral { get; set; }
       
    }

}