using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisttAsist.Logica
{
    public class Lpersonal
    {
        public int Id_personal { get; set; }//Recibe y retorna
        public string Nombres { get; set; }
        public string Identificacion { get; set; }
        public string Pais { get; set; }
        public string Id_cargo { get; set; }
        public double sueldoPorHora { get; set; }
        public string Estado { get; set; }

        public string Codigo { get; set; }
    }
}
