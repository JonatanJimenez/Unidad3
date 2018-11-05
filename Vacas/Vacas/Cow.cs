using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacas
{
    class Cow
    {
        //Propiedades
        public string NombreVaca { get; set; }
        public int TiempoEnCruzar { get; set; }
        //Constructor Sobrecargado 
        public Cow(string nombre, int tiempo)
        {
            NombreVaca = nombre;
            TiempoEnCruzar = tiempo;
        }
    }
}
