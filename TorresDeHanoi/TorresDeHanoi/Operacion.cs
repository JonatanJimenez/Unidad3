using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorresDeHanoi
{
    class Operacion
    {     
        public void Principal()//Metodo
        {
            Console.WriteLine("Torres de Hanoi\n");
            Stack<int> primeraTorre = new Stack<int>();//Creacion de una pila 
            Stack<int> seguntaTorre = new Stack<int>();//Creacion de una pila 
            Stack<int> torreFinal = new Stack<int>();//Creacion de una pila 
            Console.WriteLine("De cuantos discos quieres la torre: ");//Se imorime en consola 
            int numDiscos = int.Parse(Console.ReadLine());//se le asigna a la variable un valor 
            for (int i = numDiscos; i > 0; i--)//for que va en decremento
            {
                primeraTorre.Push(i);//se le añaden valores a la pila 
            }
            TorreDeHanoi(numDiscos, primeraTorre, torreFinal, seguntaTorre);//se le mandan valores como parametros al metodo
            imprimirTorre(primeraTorre, torreFinal, seguntaTorre);//se le mandan valores como parametros al metodo
            Console.ReadKey();//se detiene la ejecucion del programa 
        }

        static void Mover(Stack<int> torreOrigen, Stack<int> torreDestino, Stack<int> torreAuxiliar)//metodo sobrecargado
        {
            imprimirTorre(torreOrigen, torreDestino, torreAuxiliar);//llamada al metodo 
            torreDestino.Push(torreOrigen.Pop());//se le añade un valor a la pila que es igual a lo que se elemina de la otra pila 
        }

        static void TorreDeHanoi(int numDisc, Stack<int> Origen, Stack<int> Destino, Stack<int> Aux)//Metodo sobrecargado
        {

            if (numDisc == 1)//si el numero de discos es igual a 1 // se movera directamente de la primera torre a la ultima 
            {
                Mover(Origen, Destino, Aux);//llamada al metodo 
                imprimirTorre(Origen, Destino, Aux);//llamada al metodo 
            }
            else// si no 
            {

                TorreDeHanoi(numDisc - 1, Origen, Aux, Destino);//Llamada al metodo 
                Mover(Origen, Destino, Aux);//Llamada al metodo 
                TorreDeHanoi(numDisc - 1, Aux, Destino, Origen);//Llamada al metodo 

            }
        }

        static void imprimirTorre(Stack<int> Origen, Stack<int> Destino, Stack<int> Auxiliar)//Metodo sobrecargado 
        {
            Console.WriteLine("Presione alguna tecla");//se imprime en consola 
            Console.ReadKey();//se detiene la ejecucion del programa 
            Console.Clear();//Limpia la consola 
            Console.Write("Primera Torre:\n ");//se imprime en consola 
            foreach (int item in Origen)//por cada numero en la pila o 
            {
                Console.Write(item + "\n ");//se imprime en consola cada numero 
            }
            Console.WriteLine();//salto de linea 
            Console.Write("Segunda Torre: \n");//se imprime en consola 
            foreach (int item in Auxiliar)//por cada numero en la pila a 
            {
                Console.Write(item + "\n ");//se imprime en consola cada numero 
            }
            Console.WriteLine();//Salto de linea 
            Console.Write("Torre Final:\n ");//se imprime en consola 
            foreach (int item in Destino)//por cada numero en la pila d 
            {
                Console.Write(item + "\n ");//se imprime en consola cada numero 
            }
            Console.WriteLine();//Salto de linea 

            

        }                         
        
    }
}
