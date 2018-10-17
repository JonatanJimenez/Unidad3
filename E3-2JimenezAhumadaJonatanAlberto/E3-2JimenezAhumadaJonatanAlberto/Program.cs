using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_2JimenezAhumadaJonatanAlberto
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Cola = new Queue();//Creo una cola 
            Cola.Enqueue("HolaMundo");//El metodo Enqueue() Agrega un elemento al final de la Cola(Queue) 
            Cola.Enqueue(100);
            Cola.Enqueue('C');
            Cola.Enqueue(23.50);

            foreach (var item in Cola)//Imprime lo que esta guardado en el Queue 
            {
                Console.WriteLine(item);
            }
           
            Console.WriteLine();//Salto de linea 
            Cola.Dequeue();//El metodo Dequeue() elimina el primer elemento del Queue, en este caso elimina HolaMundo
            foreach (var item in Cola)//Imprime la Cola sin el primer elemento por que antes se uso el metodo Dequeue() 
            {
                Console.Write(item);
            }

            //TrimToSize() Establece la capacidadd en el numero real de elementos que hay en Queue, lo que hace este metodo es liberar memoria ya que 
            //por ejemplo si creamos una cola con una capacidad para 100 elementos y solo usamos 8 de esos espacios, los demas quedan sin 
            //usarse pero es espacio que ya esta definido por lo tanto esta gastando memoria nada mas; asi que este metodo lo que hace es que 
            //solo deja los espacios que estan siendo utilizados. Este metodo se usa casi siempre cuando se sabe que ya no se va a incrementar 
            //el tamaño del Queue. 

            Queue MyCola = new Queue(100);//Creo una cola de tamaño 100 
            for (int  i = 0;  i < 10;  i++)//For desde 0 hasta el 9 
            {
                MyCola.Enqueue(i);// se guardan los numeros del 0 al 9 a la Cola 
            }

            MyCola.TrimToSize();//Como solo le agrege 10 numeros a la Cola y la habia creado con un tamaño de 100 lo que hace es que solo me deja los 10 espacios 
                                //que tengo en uso; este metodo es void por lo tanto no regresa valor

            Console.ReadKey();
        }
    }
}
