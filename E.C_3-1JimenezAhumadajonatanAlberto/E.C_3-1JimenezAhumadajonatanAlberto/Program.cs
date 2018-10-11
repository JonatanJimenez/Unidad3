using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.C_3_1JimenezAhumadajonatanAlberto
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack Elementos = new Stack();//Se crea una pila llamada Elementos
            Elementos.Push(1);//El metodo Push() agrega a la pila lo que ingreses dentro del parentesis
            Elementos.Push(20);
            Elementos.Push("Mexico");
            Elementos.Push("Hola");
            Elementos.Push(5.45);

            foreach (var item in Elementos)//Imprime la pila
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();//Espaciado
            //Contains indica si un cierto elemento está en la pila
            if (Elementos.Contains("Mexico"))//Si en la pila existe la palabra Mexico 
            {
                Console.WriteLine("Si se encuentra el elemento indicado");//Imprime esto
            }

            //GetType se usa para saber de que tipo son los elementos almacenados en la pila
            Console.WriteLine(Elementos.Peek().GetType());//Muestra el tipo de dato del primer dato que imprime, en este caso 5.45 dara double
            Console.WriteLine();
            //ToString devuelve el elemento actual convertido en un string
            if (Elementos.Peek().ToString() == "5.45")//Convierto el primer elemento a string y lo comparo con otro sring y si son iguales 
            {
                Console.WriteLine(Elementos.Peek());//lo imrpime
            }
            Console.WriteLine();
            //ToArray devuelve toda la pila convertida en un array
            Stack copyPila = new Stack(Elementos.ToArray());//Creo un stack utilizando la pila Eleentos pero lo convierto a Array
            foreach (var item in copyPila)//por cada variable en copyPila 
            {
                Console.WriteLine(item);//Imprime las variables, siendo que es un array se imprime tal como fuimos ingresando los datos 
            }
            Console.WriteLine();
            //GetEnumerator permite usar enumeradores para recorrer la pila
            IEnumerator enumerator = Elementos.GetEnumerator(); //Creo un objeto de tipo IEnumerator y lo igualo a Elementos.GetEnumerator()
            while (enumerator.MoveNext())//Recorro la pila con el MoveNext
            {
                Console.WriteLine(enumerator.Current);//Voy imprimiendo el elemento que esta situado en la pocision actual del enumerador
            }

            Console.ReadKey();
        }
    }
}
