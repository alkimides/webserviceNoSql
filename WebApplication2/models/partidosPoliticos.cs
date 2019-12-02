using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.models
{
    public class partidosPoliticos
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Siglas { get; set; }
        public string Descripcion { get; set; }
        public string Posicion { get; set; }
        public string Votantes { get; set; }
    }

}
