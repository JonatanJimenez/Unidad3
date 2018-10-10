using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_1JimenezAhumadaJonatanAlberto
{
    class Alumno
    {
        ArrayList Clases = new ArrayList();//Cree un Arraylist Llamado Clases
        ArrayList Alumnos = new ArrayList();//Cree un Arraylist Llamado Alumnos
        ArrayList Promedio = new ArrayList();//Cree un Arraylist Llamado Promedio
        List<int> CantAlumnos = new List<int>();//Cree una lista de tipo entero llamada CantAlumnos

        int numClases, numAlumnos;//Declaracion de variables 
        int contador1 = 0, contador2 = 0;//Declaracion de variables 

        public void PedirClases()//Metodo que le pide al usuario cuantas clases desea agregar 
        {
            Console.Write("Cuantas clases desea: ");//le pedimos Cuantas clases desea
            numClases = int.Parse(Console.ReadLine());//la cantidad se guarda en esta variable
            Console.Clear();//borra la pantalla
            for (int i = 0; i < numClases; i++)//este for imprime ciertas veces dependendode la cantidad de clases un mensaje 
            {                                  
                Console.Write("Ingrese el nombre de la clase {0}: ", i + 1);
                Clases.Add(Console.ReadLine());//se guardan los nombres de la clase en el ArrayList Clases 
            }
        }

        public void PedirDatos()//Medoro llamado PedirDatos 
        {
            foreach (var clase in Clases)//Por cada clase que tenga en mi ArrayList imprime cuantos alumnos deseo y ahi mismo pido el promedio
            {
                Console.Write("Cuantos Alumnos de la Clase de {0} desea: ", clase);
                numAlumnos = int.Parse(Console.ReadLine());//guarda numero de alumnos en una variable
                CantAlumnos.Add(numAlumnos);//hago uso de la lista CantAlumnos, le añado la variable numAlumnos
                for (int i = 0; i < numAlumnos; i++)//Imprime desde cero hasta uno menor que numAlumnos las lineas de abajo
                {
                    Console.Write("Ingrese el nombre del Alumno {0}: ", i + 1);//Pido el nombre del alumno
                    Alumnos.Add(Console.ReadLine());//se guarda en el ArrayList Alumnos
                    Console.Write("Ingrese su calificacion: ");//Pido calificacion
                    Promedio.Add(Console.ReadLine());//Se guarda en el ArrayList Promedio
                }

            }
        }

        public void Imprimir()//Metodo imprimir
        {
            foreach (var clase in Clases)//por cada variable clase en el ArrayList Clases imprime la clase asi como alumno y calificacion
            {
                Console.WriteLine("Clase: {0}", clase);//Imprime la clase
                for (int i = 0; i < CantAlumnos[contador1]; i++)//for desde i = 0 hasta i menor que la Lista de CantAlumnos con indice contador1, al principio incializado en cero
                {
                    Console.WriteLine("Alumno: {0} Calificacion: {1}\n",Alumnos[contador2],Promedio[contador2]);//imprime alumno y promedio
                    contador2++;//contador 2 incrementa
                }
                contador1++;//contador 1 incrementa 
            }
        }

    }
}
