using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Carro
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string tipo { get; set; }
        public string descricao { get; set; }
        public string urlFoto { get; set; }
        public string urlVideo { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }

}
