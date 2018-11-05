using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacas
{
    class Operacion
    {
        Queue<Cow> ladoInicial = new Queue<Cow>();//Se crea una cola 
        Queue<Cow> ladoFinal = new Queue<Cow>(); //Se crea una cola       
        
        //Atributos
        string nombreVaca;
        int tiempo,tiempoTotal = 0,varAuxiliar = 0;
      
        private void AgregarVacas()//Metodo
        {
            for (int i = 0; i < 4; i++)
            {
                switch (i)//Switch para cada numero
                {
                    case 0://caso 
                        nombreVaca = "Daisy";//Se le asigna un nombre a la variable 
                        tiempo = 4;//Se le asigna tiempo a la variable 
                        break;

                    case 1://caso 
                        nombreVaca = "Mazie";//Se le asigna un nombre a la variable
                        tiempo = 2;//Se le asigna tiempo a la variable
                        break;

                    case 2://caso 
                        nombreVaca = "Crazy";//Se le asigna un nombre a la variable
                        tiempo = 10;//Se le asigna tiempo a la variable
                        break;

                    case 3://caso 
                        nombreVaca = "Lazy ";//Se le asigna un nombre a la variable
                        tiempo = 20;//Se le asigna tiempo a la variable
                        break;
                }
                Cow Vaca = new Cow(nombreVaca, tiempo);//Se crea un objeto de tipo Cow 
                ladoInicial.Enqueue(Vaca);//se le añade a la cola el objeto Vaca
            }
        }

        private void mostrarVacas()//Metodo
        {
            AgregarVacas();//Llamada al metodo        
            Console.WriteLine("Lado inicial del puente:");//Se imprime en consola
            Console.WriteLine();//Salto de linea 
            foreach (var item in ladoInicial)//por cada item en LadoInicial
            {
                Console.WriteLine("{0}   tiempo: {1} minutos", item.NombreVaca, item.TiempoEnCruzar);//Se imprime en consola nombre y tiempo de las vacas 
            }

            Console.WriteLine();//Salto de linea
            Console.WriteLine("Lado final del puente: \n");//Se impirime en consola 

            foreach (var item in ladoFinal)////por cada item en LadoFinal
            {
                if (ladoFinal.Count == 0)//si el espacio de la cola LadoFinal es igual a 0
                    Console.WriteLine("En este lado ya no hay vacas ");//Se impirime en consola 
                Console.WriteLine("{0}   tiempo: {1} minutos", item.NombreVaca, item.TiempoEnCruzar);//Se imprime en consola nombre y tiempo de las vacas 
            }

            Console.WriteLine("Las vacas se encuentran en el lado inicial del puente");//Se impirime en consola 
            Console.ReadKey();//Se para la ejecucion 
            Console.Clear();//Se limpia la consola 
        }

        private void PrimerMovimiento()//Metodo
        {
            mostrarVacas();//Llamada al metdo 
            foreach (var item in ladoInicial)//Por cada item en ladoInicial
            {
                if (varAuxiliar == 0)//si la variable es igual a 0 
                    tiempoTotal = item.TiempoEnCruzar;//se le asigna un valor a tiempoTotal
                if (varAuxiliar == 2)//si la variable es igual a 2
                    break;
                varAuxiliar++;//Aumenta la variable auxiliar 
                ladoFinal.Enqueue(item);//se le añade a la cola el item 
            }
            varAuxiliar = 0;//se le da el valor de 0 a la variable 
            ladoInicial.Dequeue();//quita un elemento de la cola lado inicial
            ladoInicial.Dequeue();//quita un elemento de la cola lado inicial

            Console.WriteLine("Lado inicial del puente:");//Se impirime en consola

            foreach (var item in ladoInicial)//por cada item en ladoInicial
            {
                Console.WriteLine("{0}   Tiempo: {1} minutos", item.NombreVaca, item.TiempoEnCruzar);//Se imprime en consola nombre y tiempo de las vacas 
            }

            Console.WriteLine("\nLado final del puente:");//Se impirime en consola

            foreach (var item in ladoFinal)//por cada item en ladoFinal
            {
                Console.WriteLine("{0}   Tiempo: {1} minutos", item.NombreVaca, item.TiempoEnCruzar);//Se imprime en consola nombre y tiempo de las vacas 
            }

            Console.WriteLine("\nTiempo actual: {0} minutos", tiempoTotal);//Se impirime en consola
            Console.ReadKey();//detiene la ejecucion
            Console.Clear();//Limpia la consola

        }

        private void SegundoMovimiento()//Metodo
        {
            PrimerMovimiento();//llamada al metodo 

            foreach (var item in ladoFinal)//por cada item en ladoFinal
            {
                if (varAuxiliar == 0)//si la variable es igual a 0
                    tiempoTotal = tiempoTotal + item.TiempoEnCruzar;//se le suma al valor total el tiempo en cruzar 
                if (varAuxiliar == 1)//si la variable es igual a 1
                    break;
                varAuxiliar++;//se aumenta la variable auxiliar 
                ladoInicial.Enqueue(item);//se le añade el item a la cola ladoInicial
            }
            varAuxiliar = 0;//se iguala a 0 
            ladoFinal.Dequeue();//quita un elemento de la cola ladoFinal

            Console.WriteLine("Lado inicial del puente:");//imprime en consola 

            foreach (var item in ladoInicial)//Por cada item en ladoInicial
            {
                Console.WriteLine("{0}   Tiempo: {1} minutos", item.NombreVaca, item.TiempoEnCruzar);//Se imprime en consola nombre y tiempo de las vacas 
            }

            Console.WriteLine("\nLado final del puente:");//imprime en consola 

            foreach (var item in ladoFinal)
            {
                Console.WriteLine("{0}   Tiempo: {1} minutos", item.NombreVaca, item.TiempoEnCruzar);//Se imprime en consola nombre y tiempo de las vacas 
            }

            Console.WriteLine("\nTiempo actual: {0} minutos", tiempoTotal);//imprime en consola 
            Console.ReadKey();//detiene la ejecucion
            Console.Clear();//Limpia la consola
        }

        private void TercerMovimiento()//Metodo
        {
            SegundoMovimiento();//Metodo
            foreach (var item in ladoInicial)//Por cada item en ladoInicial
            {
                if (varAuxiliar == 1)//si la variable el 1 
                    tiempoTotal = tiempoTotal + item.TiempoEnCruzar;//se le suma al tiempo total el tiempo en cruzar 

                if (varAuxiliar == 2)//si la variable es 2 
                    break; 
                varAuxiliar++;//Se aumenta la variable 
                ladoFinal.Enqueue(item);//se le añade un item a la cola ladoFinal
            }
            varAuxiliar = 0;//se le da el valor de 0 a la variable 
            ladoInicial.Dequeue();// se le quita un elemento a la cola ladoInicial
            ladoInicial.Dequeue();// se le quita un elemento a la cola ladoInicial

            Console.WriteLine("Lado inicial del puente:");//se imprime en pantalla 
            foreach (var item in ladoInicial)//por cada item en ladoInicial
            {
                Console.WriteLine("{0}   Tiempo: {1} minutos", item.NombreVaca, item.TiempoEnCruzar);//Se imprime en consola nombre y tiempo de las vacas 
            }

            Console.WriteLine("\nLado final del puente:");//se imprime en pantalla

            foreach (var item in ladoFinal)//por cada item en ladoFinal
            {
                Console.WriteLine("{0}   Tiempo: {1} minutos", item.NombreVaca, item.TiempoEnCruzar);//Se imprime en consola nombre y tiempo de las vacas 
            }

            Console.WriteLine("\nTiempo actual: {0} minutos", tiempoTotal);//se imprime en pantalla
            Console.ReadKey();//detiene la ejecucion 
            Console.Clear();//limpia la pantalla 
        }

        private void CuartoMovimiento()//metodo 
        {
            TercerMovimiento();//llamada al metodo 
            foreach (var item in ladoFinal)//por cada item en ladoFinal
            {
                if (varAuxiliar == 0)//si es igual a 0 
                    tiempoTotal = tiempoTotal + item.TiempoEnCruzar;//se le suma al tiempo total el tiempo en cruzar 

                if (varAuxiliar == 1)//si es igual a 1 
                    break;
                varAuxiliar++;//aumenta la varAuxiliar
                ladoInicial.Enqueue(item);//se le añade a la cola un elemento 
            }
            varAuxiliar = 0;//se iguala a 0 
            ladoFinal.Dequeue();//se quita un elemento de la cola 

            Console.WriteLine("Lado izquierdo del puente:");//se imprime en consola 
            foreach (var item in ladoInicial)//por cada item en ladoInicial
            {
                Console.WriteLine("{0}   Tiempo: {1} minutos", item.NombreVaca, item.TiempoEnCruzar);//Se imprime en consola nombre y tiempo de las vacas 
            }

            Console.WriteLine("\nLado derecho del puente:");//se imprime en consola 

            foreach (var item in ladoFinal)//por cada item en ladoFinal
            {
                Console.WriteLine("{0}   Tiempo: {1} minutos", item.NombreVaca, item.TiempoEnCruzar);//Se imprime en consola nombre y tiempo de las vacas 
            }

            Console.WriteLine("\nTiempo actual: {0} minutos", tiempoTotal);//se imprime en consola 
            Console.ReadKey();//Se detiene la ejecucion 
            Console.Clear();//se limpia la consola 
        }

        public void UltimoMovimiento()//metodo 
        {
            CuartoMovimiento();//llamada al metodo 

            foreach (var item in ladoInicial)//por cada item en ladoInicial
            {
                if (varAuxiliar == 0)//si es igual a 0 
                    tiempoTotal = tiempoTotal + item.TiempoEnCruzar;//se le suma al tiempo total el tiempo en cruzar 

                if (varAuxiliar == 2)//si es igual a 2 
                    break;
                varAuxiliar++;//se aumenta varAuxiliar
                ladoFinal.Enqueue(item);//se le añade un elemento a la cola 
            }
            varAuxiliar = 0;//se iguala a 0 
            ladoInicial.Dequeue();//se elimina un elemento de la cola 
            ladoInicial.Dequeue();//se elimina un elemento de la cola 

            Console.WriteLine("Lado inicial del puente:");//Se imprime en consola 
            foreach (var item in ladoInicial)//por cada item en ladoInicial
            {
                Console.WriteLine("{0}   Tiempo: {1} minutos", item.NombreVaca, item.TiempoEnCruzar);//Se imprime en consola nombre y tiempo de las vacas 
            }

            Console.WriteLine("\nLado final del puente:");//Se imprime en consola 

            foreach (var item in ladoFinal)//por cada item en ladoFinal
            {
                Console.WriteLine("{0}   Tiempo: {1} minutos", item.NombreVaca, item.TiempoEnCruzar);//Se imprime en consola nombre y tiempo de las vacas 
            }

            Console.WriteLine("\nTiempo final {0} minutos", tiempoTotal);//Se imprime en consola 
            Console.WriteLine("\nLas vacas llegaron al otro lado del puente");//Se imprime en consola 

        }
    }
}
