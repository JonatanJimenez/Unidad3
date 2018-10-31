using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E_3JimenezAhumadaJonatanAlberto
{
    class Operacion
    {
        public void Principal()
        {
            Stack Lista = new Stack();
            Queue Cola = new Queue();

        }

        public void Ejercicio1()
        {
            //¿Qué valores se devuelven durante la siguiente serie de operaciones de pila,
            //si se ejecutan en una pila inicialmente vacía ? 
            //push(5), push(3), pop(), push(2), push(8),
            //pop(), pop(), push(9), push(1), pop(), push(7), push(6), pop(), pop(), push(4),
            //pop(), pop()
            Console.WriteLine("Ejercicio 1 del Examen");
            Stack Pila = new Stack();
            Pila.Push(5);
            Pila.Push(3);
            Pila.Pop();
            Pila.Push(2);
            Pila.Push(8);
            Pila.Pop();
            Pila.Pop();
            Pila.Push(9);
            Pila.Push(1);
            Pila.Pop();
            Pila.Push(7);
            Pila.Push(6);
            Pila.Pop();
            Pila.Pop();
            Pila.Push(4);
            Pila.Pop();
            Pila.Pop();
            foreach (var item in Pila)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.Clear();
        }
        
        List<string> palabrasReservadas = new List<string>();
        public void LlenarLista()
        {
            palabrasReservadas.Add("ABSTRACT");
            palabrasReservadas.Add("AS");
            palabrasReservadas.Add("BASE");
            palabrasReservadas.Add("BOOL");
            palabrasReservadas.Add("BREAK");
            palabrasReservadas.Add("BYTE");
            palabrasReservadas.Add("CASE");
            palabrasReservadas.Add("CATCH");
            palabrasReservadas.Add("CHAR");
            palabrasReservadas.Add("CHECKED");
            palabrasReservadas.Add("CLASS");
            palabrasReservadas.Add("CONST");
            palabrasReservadas.Add("CONTINUE");
            palabrasReservadas.Add("DECIMAL");
            palabrasReservadas.Add("DEFAULT");
            palabrasReservadas.Add("DELEGATE");
            palabrasReservadas.Add("DO");
            palabrasReservadas.Add("DOUBLE");
            palabrasReservadas.Add("ELSE");
            palabrasReservadas.Add("ENUM");
            palabrasReservadas.Add("EVENT");
            palabrasReservadas.Add("EXPLICIT");
            palabrasReservadas.Add("EXTERN");
            palabrasReservadas.Add("FALSE");
            palabrasReservadas.Add("FINALLY");
            palabrasReservadas.Add("FIXED");
            palabrasReservadas.Add("FLOAT");
            palabrasReservadas.Add("FOR");
            palabrasReservadas.Add("FOREACH");
            palabrasReservadas.Add("GOTO");
            palabrasReservadas.Add("IF");
            palabrasReservadas.Add("IMPLICIT");
            palabrasReservadas.Add("IN");
            palabrasReservadas.Add("INT");
            palabrasReservadas.Add("INTERFACE");
            palabrasReservadas.Add("INTERNALE");
            palabrasReservadas.Add("IS");
            palabrasReservadas.Add("LOCK");
            palabrasReservadas.Add("LONG");
            palabrasReservadas.Add("NAMESPACE");
            palabrasReservadas.Add("NEW");
            palabrasReservadas.Add("NULL");
            palabrasReservadas.Add("OBJECT");
            palabrasReservadas.Add("OPERATOR");
            palabrasReservadas.Add("OUT");
            palabrasReservadas.Add("OVERRIDE");
            palabrasReservadas.Add("PARAMS");
            palabrasReservadas.Add("PRIVATE");
            palabrasReservadas.Add("PROTECTED");
            palabrasReservadas.Add("PUBLIC");
            palabrasReservadas.Add("READONLY");
            palabrasReservadas.Add("REF");
            palabrasReservadas.Add("RETURN");
            palabrasReservadas.Add("SBYTE");
            palabrasReservadas.Add("SEALED");
            palabrasReservadas.Add("SHORT");
            palabrasReservadas.Add("SIZEOF");
            palabrasReservadas.Add("STACKALLOC");
            palabrasReservadas.Add("STATIC");
            palabrasReservadas.Add("STRING");
            palabrasReservadas.Add("STRUCT");
            palabrasReservadas.Add("SWITCH");
            palabrasReservadas.Add("THIS");
            palabrasReservadas.Add("THROW");
            palabrasReservadas.Add("TRUE");
            palabrasReservadas.Add("TRY");
            palabrasReservadas.Add("TYPEOF");
            palabrasReservadas.Add("UINT");
            palabrasReservadas.Add("ULONG");
            palabrasReservadas.Add("UCHECKED");
            palabrasReservadas.Add("UNSAFE");
            palabrasReservadas.Add("USHORT");
            palabrasReservadas.Add("USING");
            palabrasReservadas.Add("VIRTUAL");
            palabrasReservadas.Add("VOID");
            palabrasReservadas.Add("WHILE");
        }
        LinkedList<string> Palabras = new LinkedList<string>();

        public void Ejercicio2()
        {
            //Escriba en este metodo un modulo que pueda leer  y almacenar palabras reservadas en una lista enlazada 
            //e identificadores y literales en Otra lista enlazada.
            //Cuando el programa haya terminado de leer la entrada, mostrar
            //Los contenidos de cada lista enlazada.
            //Revise que es un Identificador y que es un literal
            Console.WriteLine("Ejercicio 2 del Examen");
            LlenarLista();
            LinkedList<String> PalabrasReservadas = new LinkedList<string>();
            string Opcion = "";
            do
            {
                Console.Write("Introduzca una palabra: ");
                string palabra = Console.ReadLine().ToUpper();
                if (true == palabrasReservadas.Contains(palabra))
                {
                    PalabrasReservadas.AddLast(palabra);
                }
                else
                {
                    Palabras.AddLast(palabra);
                }
                Console.WriteLine("Desea continuar ingresando palabras: ");
                Opcion = Console.ReadLine().ToUpper();
            } while (Opcion == "SI");
            
            Console.WriteLine("Lista de palabras reservadas:  ");
            foreach (var item in PalabrasReservadas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Lista de palabras no reservadas: ");
            foreach (var item in Palabras)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.Clear();
        }

        public void Ejercicio3()
        {
            //mida el tiempo entre Un lista ligada y una lista normal en el tiempo de ejecucion de 9876 elementos agregados.
            Console.WriteLine("Ejercicio 3 del Examen");
            List<int> ListaNormal = new List<int>();
            LinkedList<int> ListaLigada = new LinkedList<int>();

            Stopwatch Tiempo = new Stopwatch();
            
            Tiempo.Start();
            for (int i = 0; i < 9875; i++)
            {
                ListaNormal.Add(i);
            }
            Tiempo.Stop();
            Console.WriteLine("Tiempo lista Normal: " + ((double)(Tiempo.Elapsed.TotalMilliseconds * 1000000) / 9876).ToString("0.00 ns"));
            
            Tiempo.Start();
            for (int i = 0; i < 9875; i++)
            {
                ListaLigada.AddLast(i);
            }
            Tiempo.Stop();
            Console.WriteLine("Tiempo lista Ligada: " + ((double)(Tiempo.Elapsed.TotalMilliseconds * 1000000) / 9876).ToString("0.00 ns"));
            Console.ReadKey();
            Console.Clear();
        }

        public void Ejercicio4()
        {

            // Diseñar e implementar una clase que le permita a un maestro hacer un seguimiento de las calificaciones
            // en un solo curso.Incluir métodos que calculen la nota media, la
            //calificacion más alto, y el calificacion más bajo. Escribe un programa para poner a prueba tu clase.
            //implementación. Minimo 30 Calificaciones, de 30 alumnos.
            Console.WriteLine("Ejercicio 4 del Examen");
            List<Clase> Alumno = new List<Clase>();
            List<int> Calificacion = new List<int>();

            int Maxima = 0, Minima = 100;

            Clase clase = new Clase();
            Console.WriteLine("Ingrese el nombre del Maestro: ");
            clase.Maestro = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de la materia: ");
            clase.NombreClase = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("");
            for (int i = 0; i < 30; i++)
            {
                Clase claseNueva = new Clase();
                Console.WriteLine("Ingrese el nombre del Alumno " + (i+1));
                claseNueva.Alumno = Console.ReadLine();
                Console.WriteLine("Ingrese la calificacion");
                claseNueva.Calificacion = int.Parse(Console.ReadLine());
                if (claseNueva.Calificacion > Maxima)
                    Maxima = claseNueva.Calificacion;
                if (Minima > claseNueva.Calificacion)
                    Minima = claseNueva.Calificacion;
                Alumno.Add(claseNueva);
            }

            double sumaCalificaciones = 0;
            double Promedio = 0;

            foreach (var item in Alumno)
            {
                sumaCalificaciones += item.Calificacion;
                Promedio = sumaCalificaciones / Alumno.Count;
            }
            Console.WriteLine("El promedio es: {0}\nCalificacion Mas alta: {1}\nCalificacion Mas Baja: {2}", Promedio,Maxima,Minima);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
