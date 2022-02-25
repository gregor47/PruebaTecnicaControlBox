using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front.Models
{
    public class TablaModel
    {
        public string Letra { get; set; }
        public int Conteo { get; set; }

        public TablaModel(string letra, int conteo)
        {
            this.Letra = letra;
            this.Conteo = conteo;
        }
    }
    
}
