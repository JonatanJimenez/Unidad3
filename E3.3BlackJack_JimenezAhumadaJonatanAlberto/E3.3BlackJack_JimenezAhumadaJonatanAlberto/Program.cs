using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3._3BlackJack_JimenezAhumadaJonatanAlberto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode; //Se usa para poder visualizar las figuras como el corazon, trebol, etc. en consola 
            Metodo metodo = new Metodo();  // Creo un objeto de tipo Carta           
            metodo.Menu(); //Llamo el metodo Menu 
        }
    }
}
