using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacion operacion = new Operacion();//Creacion de un objeto de tipo Operacion
            operacion.Inicio();//Se utiliza el metodo Principal()
            Console.ReadKey();//Detiene el Programa
        }
    }
}
