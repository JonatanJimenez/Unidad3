using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3._3BlackJack_JimenezAhumadaJonatanAlberto
{
    class Metodo
    {
        public void LLenarCartas(ArrayList ValorCarta, ArrayList FiguraCarta) //Creo un metodo void con parametros ValorCarta y FiguraCarta 
        {
            for (int i = 0; i < 4; i++) // Creo un for para agregar A, J, Q  y K 4 veces en el ArrayList
            {
                ValorCarta.Add("A"); // Agrega con el Metodo Add al ArrayList 
                ValorCarta.Add("J");
                ValorCarta.Add("Q");
                ValorCarta.Add("K");
                for (int j = 2; j <= 10; j++) // for para agregar los valores del 2 al 10 al ArrayList 
                {
                    ValorCarta.Add(j); // Agrega con el Metodo Add al ArrayList 
                }
            }

            for (int i = 0; i <= 3; i++) // for para ejecutar 4 veces 
            {
                string Figura = "";
                if (i == 0) // si i es 0 
                {
                    Figura = "♠"; //Le asigna a la variable la figura de picas 
                }
                if (i == 1) // si i es 1
                {
                    Figura = "♣"; //Le asigna a la variable la figura de picas 
                }
                if (i == 2) // si i es 2
                {
                    Figura = "♦"; //Le asigna a la variable la figura de diamante
                }
                if (i == 3) // si i es 3
                {
                    Figura = "♥"; //Le asigna a la variable la figura de corazon
                }
                for (int j = 0; j <= 12; j++)
                {
                    FiguraCarta.Add(Figura); // Agregra Figura al ArrayList FiguraCarta
                }
            }
        }

        public void BarajearDeck(ArrayList ValorCarta, ArrayList FiguraCarta, Stack Deck, Stack DeckNumeros, Random Aleatorio) //creo un metodo void para Barajear el Mazo
        {                                                                                                                      // Al cual le mando diferentes parametros 
            for (int i = 0; i < 52; i++) // for para que me ejecute 52 veces 
            {
                int Var = Aleatorio.Next(0, ValorCarta.Count);
                Deck.Push(FiguraCarta[Var]); //Agrego una figura a la pila con indice aleatorio
                DeckNumeros.Push(ValorCarta[Var]); //Agrego un numero aleatorio a la pila 
                ValorCarta.RemoveAt(Var); // Remuevo el numero del ArrayList
                FiguraCarta.RemoveAt(Var); // Remuevo la figura del ArrayList
            }
        }

        public void RepartirCartas(Stack Deck, Stack DeckNumeros, Stack Jugador, Stack JuegosGanados, Stack JuegosPerdidos)//Metodo void para repartir las cartas 
        {
            object Carta1 = DeckNumeros.Pop(); // creo un objeto de nombre Carta1 al cual le asignamos el primer valor en la pila el cual al mismo tiempo se elimina 
            object Carta2 = DeckNumeros.Pop(); // creo un objeto de nombre Carta1 al cual le asignamos el primer valor en la pila por que el primero en si se elimino
            Console.WriteLine("Bienvenido al Juego de BlackJack");
            Console.WriteLine("Tus primeras 2 cartas son: \n");
            Console.Write(Deck.Pop() + "" + Carta1); //Imprimen la carta 1 
            Console.WriteLine("    " + Deck.Pop() + "" + Carta2);//Imprime la carta 2 
            Jugador.Push(Carta1); //Guarda la carta numero 1 en una pila 
            Jugador.Push(Carta2); // Guarda la carta numero 2 en una pila 

            int Resultado = 0;
            List<int> SumaCartas = new List<int>(); //Creo una lista en la cual se guardan los numeros que van saliendo
            for (int i = 0; i < 2; i++) // for para ejecutar 2 veces 
            {
                var Numero = Jugador.Peek(); // creo una variable numero la cual la igualamos a lo que esta en la primera posicion de la pila jugador 
                if (Numero.ToString() == "J" || Numero.ToString() == "Q" || Numero.ToString() == "K") // si el numero es igual a J, Q o K 
                {
                    Numero = 10; // se le asigna a la variable el valor de 10                
                }

                if (Numero.ToString() == "A") // Si el numero es A 
                {
                    Pregunta:
                    Console.WriteLine("Desea que la carta As valga 1 u 11"); // Le preguntamos al usuario como quiere usar el As como 1 u 11 
                    int ValorAs = int.Parse(Console.ReadLine());
                    if (ValorAs == 1) // si elige 1 
                    {
                        Numero = 1; // se le asigna el valor 1 
                    }
                    else if (ValorAs == 11) // si elige 11
                    {
                        Numero = 11; //se le asigna el valor 11
                    }
                    else
                    {
                        Console.WriteLine("Introduzca un numero valido"); //En caso de que no introdujo un dato valido
                        goto Pregunta; // me regresa a la etiquta Pregunta
                    }
                }
                SumaCartas.Add(Convert.ToInt32(Numero)); // Agrega el valor de Numero a la lista SumaCartas
                Jugador.Pop(); //Saca la carta del jugador 
            }

            foreach (var item in SumaCartas) //Por cada item en la lista SumaCartas 
            {
                Resultado += item; // Se suman 
            }

            Console.WriteLine("El resultado de sus cartas es de: {0}", Resultado);//Me escribe el valor de la suma correspondiente

            ComeBack:
            if (Resultado < 21) // Si el resultado de la suma es menor a 21 
            {
                Console.WriteLine("Presione cualquier tecla para darle otra carta");
                Console.ReadKey();
                var Carta3 = DeckNumeros.Pop(); // creo una variable llamada Carta3 a la cual le doy un valor de la DeckNumeros
                Console.WriteLine(Deck.Pop() + "" + Carta3); // Escribo el valor de la carta 3                 
                Jugador.Push(Carta3); //Saca la carta del arreglo para que ya no vuelva a salir 

                var Numero = Jugador.Peek();
                if (Numero.ToString() == "J" || Numero.ToString() == "Q" || Numero.ToString() == "K") //Si el valor de la carta es J, Q o K 
                {
                    Numero = 10; // se le asigna el Valor de 10 
                }
                if (Numero.ToString() == "A") //Si es un As 
                {
                    Pregunta:
                    Console.WriteLine("Desea que el As valga 1 u 11");//Pregunta que valor quiere que se le asigne, si 1 u 11 
                    int ValorAs = int.Parse(Console.ReadLine());
                    if (ValorAs == 1) //Si escoge 1 
                    {
                        Numero = 1; // se iguala la variable Numero a 1 
                    }
                    else if (ValorAs == 11)// Si escoge 11 
                    {
                        Numero = 11; // se iguala la variable Numero a 11
                    }
                    else
                    {
                        Console.WriteLine("Introduzca un numero valido");//Si escribe un dato erroneo 
                        goto Pregunta;// se regresa de nuevo a la pregunta 
                    }
                }

                SumaCartas.Add(Convert.ToInt32(Numero));//Agrega a la lista el siguiente numero de la carta 
                Resultado += SumaCartas.Last();//Lo suma 
                Console.WriteLine("El resultado de sus cartas es de: " + Resultado); //Escribe la suma          
                goto ComeBack;
            }

            if (Resultado == 21) //Si el resultado de la suma es 21 
            {
                Console.WriteLine("\n¡Felicidades has ganado"); // Se escribe que ha ganado                               
                JuegosGanados.Push(1); //Incrementa en 1 la pila         
            }

            if (Resultado > 21) //Si la suma es mayor a 21 
            {
                Console.WriteLine("\nPerdiste el juego");//Se escribe que ha perdido                                 
                JuegosPerdidos.Push(1); // Incrementa en 1 la pila  
            }

        }
        public void GanadosPerdidos(Stack JuegosGanados, Stack JuegosPerdidos, int Iniciar) //Creo un metodo void GanadosPerdidos
        {
            Console.Clear();
            Console.WriteLine("Ganaste {0} juegos de {1} jugados", JuegosGanados.Count, Iniciar); //Me dice cuantos juegos gane 
            Console.WriteLine("Perdiste {0} juegos de {1} jugados", JuegosPerdidos.Count, Iniciar); //Me dice cuantos juegos perdi
        }

        public void Menu()
        {

            Metodo CardGame = new Metodo(); //Creo un objeto de tipo Carta 
            int iniciar = 0;
            Stack JuegosGanados = new Stack(); //Se crea una pila de los juegos ganados  
            Stack juegosPerdidos = new Stack(); //Se crea una pila de los juegos Perdidos              
            Console.Clear(); //Se limpia la consola
            Jugar:
            Console.Clear(); //Se limpia la consola
            Stack Jugador = new Stack(); //Creo una pila llamada Jugador 
            List<int> Numeros = new List<int>(); //Creo una Lista llamada Numeros
            Stack Mazo = new Stack(); //Creo una pila llamada Mazo
            Stack MazoNumeros = new Stack(); //Creo una pila llamada MazoNumeros
            ArrayList Numero = new ArrayList(); //Creo un ArrayList Numero
            ArrayList Figura = new ArrayList(); //Creo un ArrayList Figura
            Random NumeroAleatorio = new Random();  //Creo una variable Ramdom
            CardGame.LLenarCartas(Numero, Figura); //Llamo el metodo LlenarCartas    
            CardGame.BarajearDeck(Numero, Figura, Mazo, MazoNumeros, NumeroAleatorio); //Llamo el metodo BarajearDeck
            CardGame.RepartirCartas(Mazo, MazoNumeros, Jugador, JuegosGanados, juegosPerdidos); //Llamo el metodo RepartirCartas
            VolveraJugar:
            Console.WriteLine("¿Desea Volver a jugar? Si/No"); //Pregunto si desea volver a jugar 
            string respuesta = Console.ReadLine().ToUpper();
            if (respuesta == "SI") //Si la respueste es si 
            {
                iniciar += 1; //Me incrementa en 1 iniciar
                goto Jugar;
            }
            else if (respuesta == "NO")//Si es no 
            {
                iniciar += 1;
                CardGame.GanadosPerdidos(JuegosGanados, juegosPerdidos, iniciar); //Llamo el metodo GanadosPerdidos para que me den mis estadisticas
                Console.ReadKey();
            }
            else
            {
                Console.Write("Introduzca un valor correcto; Si o No solamente.");//Si ingreso un dato erroneo vuelve a preguntar si desea jugar de nuevo 
                goto VolveraJugar;
            }
        }
    }
}
