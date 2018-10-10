using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_1JimenezAhumadaJonatanAlberto
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno();//creo un objeto de tipo Alumno
            bool bandera = true;//variable booleana
            inicio:
            do//hace lo que esta adentro del do while
            {
                try//corre lo que esta adentro y si encuentra un error el catch lo atrapa
                {                    
                    alumno.PedirClases();//uso el metodo PedirClases gracias al objeto alumno
                    Console.Clear();//borro consola
                    alumno.PedirDatos();// uso otro metodo de la clase Alumno
                    Console.Clear();//borro consola
                    alumno.Imprimir();//utilizo metodo Imprimir definido en la clase Alumno
                    bandera = false;
                    Console.Write("Desea Continuar: Si / No ");//pregunto si desea continuar
                    string respuesta = Console.ReadLine();
                    if (respuesta.ToUpper() == "SI")//si responde si volvemos a inicio en caso contrario termina el programa 
                    {
                        goto inicio;
                    }                                    
                }
                catch (FormatException formato) // catch para formato
                {
                    Console.WriteLine(formato.Message);//imprime el puro mensaje de todo el error
                }                     
            } while (bandera == true); //mientras que la variable bandera sea cierta
                     
        }
    }
}
