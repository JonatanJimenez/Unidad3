using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Operacion
    {
        List<Tarea> Pendiente = new List<Tarea>();//Creacion de la lista Pendiente
        List<Tarea> EnProceso = new List<Tarea>();//Creacion de la lista EnProceso
        List<Tarea> Terminadas = new List<Tarea>();//Creacion de la lista Terminadas
        Tarea HomeWork;//Objeto de tipo Tarea
        int id, contador, opcion, NumTareas;//Atributos de tipo int
        string NomTarea, desc, fechaInicio = "", fechaFin = "", status = "", desStat = "";//Atributos de tipo string

        public void AgregarTareaInicial()//Metodo
        {
            Console.WriteLine("ID: ");//Escribe ID
            id = int.Parse(Console.ReadLine());

            foreach (var item in Pendiente)//Por cada Item in Pendiente
            {
                while (HomeWork.ID == id)//Mientras que la propiedad ID de HomeWork sea igual al id 
                {
                    Console.WriteLine("Esta tarea ya existe; favor de agregar una nueva tarea");//en caso de agregar otra tarea con el mismo Id, vuelve a pedir el id 
                    Console.WriteLine("ID: ");//Escribe ID
                    id = int.Parse(Console.ReadLine());

                }
            }

            foreach (var item in EnProceso)//Se hace lo mismo que en el metodo anterior pero en la lista EnProceso
            {
                while (HomeWork.ID == id)
                {
                    Console.WriteLine("Esta tarea ya existe; favor de agregar una nueva tarea");
                    Console.WriteLine("ID: ");
                    id = int.Parse(Console.ReadLine());
                }
            }

            foreach (var item in Terminadas)//Se hace lo mismo que en el metodo anterior pero en la lista Terminadas
            {
                while (HomeWork.ID == id)
                {
                    Console.WriteLine("Esta tarea ya existe; favor de agregar una nueva tarea");
                    Console.WriteLine("ID: ");
                    id = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Nombre de la Tarea: ");//Escribe Nombre de la Tarea
            NomTarea = Console.ReadLine();//Se guarda el nombre que le de el usuario
            Console.Write("Descripcion: ");//Escribe Descripcion
            desc = Console.ReadLine();//Se guarda la descripcion 
            Console.Write("Status de la Tarea: (Pendiente/Proceso/Terminada): ");//Escribe en pantalla lo que esta entre comillas
            status = Console.ReadLine();//Guarda el status 

            while (status != "Proceso" && status != "Terminada" && status != "Pendiente")//mientras status sea diferente de Proceso, Terminada y Pendiente
            {
                Console.WriteLine("El Status que ingreso no es valido, favor de escribir el status de nuevo ");//Se escribe lo que esta entre comillas
                Console.WriteLine("Status de la Tarea: (Pendiente/Proceso/Terminada): ");//Se ecribe lo que esta entre comillas 
                status = Console.ReadLine();//Guarda de nuevo el status
            }

            if (status == "Proceso")//si estatus es igual a Proceso
            {
                Console.Write("introduzca la fecha de inicio: ");//Pide al usuario que ingrese la fecha de inicio
                fechaInicio = Console.ReadLine();//guarda 
            }

            if (status == "Terminada")//si estatus es igual a Terminada
            {
                Console.Write("Introduzca la fecha de inicio: ");//Pide al usuario que ingrese la fecha de inicio
                fechaInicio = Console.ReadLine();//Guarda en la variable 
                Console.Write("Introduzca la fecha de finalizacion: ");//Pide tambien al usuario que ingrese la fecha de finalizacion
                fechaFin = Console.ReadLine();//Guarda en la variable 
            }

            Console.Write("Introduzca la descripcion del status: ");//Escribe en pantalla lo que esta entre comillas
            desStat = Console.ReadLine();//guarda 
            Console.WriteLine();//Salto de linea 
            HomeWork = new Tarea(id, NomTarea, desc, fechaInicio, fechaFin, status, desStat);//Le mando los parametros al objeto HomeWork 

            if (status == "Pendiente")//si la variable status es igual a Pendiente
            {
                Pendiente.Add(HomeWork);//Se añade a la lista el objeto HomeWork
            }

            if (status == "Proceso")//si la variable status es igual a Proceso
            {
                EnProceso.Add(HomeWork);//Se añade a la lista el objeto HomeWork
            }

            if (status == "Terminada")//si la variable status es igual a Terminada
            {
                Terminadas.Add(HomeWork);//Se añade a la lista el objeto HomeWork
            }
        }

        public void EditarTarea()//Metodo
        {
            Console.Clear();//Limpia la pantalla
            Console.WriteLine("Que tipo de tarea desea editar:");//Escribe lo que esta entre comillas 
            Console.Write("1.Tareas Pendientes\n2.Tareas En Proceso\n3.Tareas Terminadas: ");//Da opciones 
            int Opcion = int.Parse(Console.ReadLine());//Se guarda el numero de la opcion elegida en la variable Opcion
            switch (Opcion)//Se crea un switch 
            {
                case 1://Caso
                    foreach (var item in Pendiente)//por cada item en la lista pendiente 
                    {
                        Console.WriteLine("ID: {0}\nNombre: {1}", item.ID, item.NombreTarea);//Escribe el Id y el Nombre 
                    }

                    Console.WriteLine("Que tarea desea editar (Ingrese ID): ");//Escribe lo que esta entre comillas 
                    id = int.Parse(Console.ReadLine());//guarda en la variable id 
                    contador = -1;//Contador inicializado en -1
                    foreach (var item in Pendiente)//por cada item en la lista pendiente 
                    {
                        contador++;//aumenta el contador 
                        if (HomeWork.ID == id)//si el ID de la propiedad es igual al ingresado por el usuario
                        {
                            Console.WriteLine("Escriba el status de la tarea: ");//Escribe lo que esta entre comillas 
                            status = Console.ReadLine();//guarda en la variable 

                            while (status != "Terminada" && status != "Proceso")//Mientres el status sea diferente de Terminada y de Proceso 
                            {
                                Console.WriteLine("El Status que ingreso no es valido");//Escribe en pantalla
                                Console.Write("Escriba el status de la tarea: ");//vuelve a pedir el status 
                                status = Console.ReadLine();//guarda en la variable 
                            }

                            if (status == "Proceso")//si el status es igual a Proceso
                            {
                                HomeWork.Status = status;//Guarda en la propiedad de HomeWork el nuevo status 
                                Console.WriteLine("Ingrese la fecha de inicio de la tarea: ");//Escribe en pantalla 
                                HomeWork.FechaInicio = Console.ReadLine();//Guarda en la propiedad 
                                Console.WriteLine("Agregue una descripción del status: ");//Escribe en pantalla 
                                HomeWork.DescripcionStatus = Console.ReadLine();//guarda en la propiedad la descripcion del status 
                                EnProceso.Add(item);//añade a la lista en proceso la nueva tarea editada 
                                Pendiente.RemoveAt(contador);//remueve de la lista pendiente la tarea 
                                break;
                            }

                            if (status == "Terminada")//si el status es igual a Terminada 
                            {
                                HomeWork.Status = status;
                                Console.WriteLine("Ingrese la fecha de inicio de la tarea");
                                HomeWork.FechaInicio = Console.ReadLine();
                                Console.WriteLine("Ingrese la fecha de fin de la tarea");
                                HomeWork.FechaFin = Console.ReadLine();
                                Console.WriteLine("Agregue una descripción del status");
                                HomeWork.DescripcionStatus = Console.ReadLine();
                                Terminadas.Add(item);
                                Pendiente.RemoveAt(contador);
                                break;

                            }

                        }

                    }

                    Menu();//Llama al metodo Menu()
                    break;

                case 2://Caso 
                    foreach (var item in EnProceso)//por cada item en la lista EnProceso
                    {
                        Console.WriteLine("ID: {0}\nNombre: {1}", item.ID, item.NombreTarea);//Escribe el id y el nombre de la tarea 
                    }

                    Console.WriteLine("Que tarea desea editar: (Ingrese ID)");//Escribe en pantalla 
                    id = int.Parse(Console.ReadLine());//guarda en la variable 
                    contador = -1;//contador 
                    foreach (var item in EnProceso)//por cada item en la lista EnProceso
                    {
                        contador++;//aumenta el contador 
                        if (HomeWork.ID == id)//si la Propiedad ID es igual a la ingresada por el usuario 
                        {
                            Console.Write("Escriba el status de la tarea");//Escribe en pantalla 
                            status = Console.ReadLine();//guarda en la variable 

                            while (status != "Terminada")//Mientras el status sea diferente de Terminada 
                            {
                                Console.WriteLine("El Status que ingreso no es valido");//Escribe en pantalla 
                                Console.Write("Escriba el status de la tarea");//Vuelve a pedir el status 
                                status = Console.ReadLine();//Guarda en la Variable 
                            }

                            if (status == "Terminada")//Si status es igual a Terminada 
                            {
                                HomeWork.Status = status;//Guarda en la propiedad el status 
                                Console.Write("Ingrese la fecha de inicio de la tarea");//Escribe en pantalla 
                                HomeWork.FechaInicio = Console.ReadLine();//Guarda en la propiedad 
                                Console.Write("Ingrese la fecha de fin de la tarea");//Escribe en pantalla 
                                HomeWork.FechaFin = Console.ReadLine();//Guarda en la propiedad 
                                Console.Write("Agregue una descripción del status");//Escribe en pantalla 
                                HomeWork.DescripcionStatus = Console.ReadLine();//Guarda en la propiedad 
                                Terminadas.Add(item);//Añade a la lista la tarea 
                                Pendiente.RemoveAt(contador);//Elimina de la tarea pendiente 
                                break;
                            }

                        }

                    }
                    Menu();
                    break;

                case 3://Caso
                    foreach (var item in Terminadas)//por cada item en la lista Terminadas 
                    {
                        Console.WriteLine("ID: {0}\nNombre: {1}", item.ID, item.NombreTarea);//Imprime en pantalla 
                    }

                    Console.WriteLine("Que tarea desea editar: (Ingrese ID)");//Imprime en la pantalla 
                    id = int.Parse(Console.ReadLine());//Guarda en la variable 
                    contador = -1;//Contador 
                    foreach (var item in Terminadas)//Por cada item en Teminadas 
                    {
                        contador++;//Aumenta el contador 
                        if (HomeWork.ID == id)//Si el ID guardado en la propiedad es igual al que introdujo el usaurio 
                        {
                            Console.Write("Escriba el status de la tarea");//Imprime en pantalla 
                            status = Console.ReadLine();//Guarda en la variable 

                            while (status != "Proceso")//Mientras status sea diferente de Proceso
                            {
                                Console.WriteLine("Status no valido");//Imprime en pantalla 
                                Console.Write("Escriba el status de la tarea");//Vuelve a pedir el status 
                                status = Console.ReadLine();//Guarda en la variable 
                            }

                            if (status == "Proceso")//Si status es igual a Proceso
                            {
                                HomeWork.Status = status;//añade a la propiedad el status 
                                Console.Write("Ingrese la fecha de inicio de la tarea");//Imprime en pantalla 
                                HomeWork.FechaInicio = Console.ReadLine();//Guarda en la propiedad 
                                Console.Write("Agregue una descripción del status");//Imprime en pantalla 
                                HomeWork.DescripcionStatus = Console.ReadLine();//Guarda en la propiedad 
                                EnProceso.Add(item);//Añade a la lista EnProceso la tarea 
                                Pendiente.RemoveAt(contador);//Remueve la tarea de la lista Pendiente 
                                break;
                            }

                        }

                    }
                    Menu();//Se llama el metodo Menu()
                    break;
            }
        }

        public void Menu()//Metodo 
        {
            Console.Clear();//Limpia la pantalla 
            Console.WriteLine("1. Agregar tareas");//Imprime en pantalla lo escrito entre comillas 
            Console.WriteLine("2. Ver tareas");//Imprime en pantalla lo escrito entre comillas 
            Console.WriteLine("3. Modificar tarea");//Imprime en pantalla lo escrito entre comillas 
            Console.WriteLine("4. Salir del programa");//Imprime en pantalla lo escrito entre comillas 
            Console.Write("Presione el número de lo que desea hacer: ");//Imprime en pantalla lo escrito entre comillas 
            opcion = int.Parse(Console.ReadLine());//guarda en la variable opcion
            switch (opcion)//switch para las opciones 
            {
                case 1://Caso 
                    Console.WriteLine("Cuantas tareas desea Agregar: ");//Imprime en pantalla lo escrito entre comillas 
                    NumTareas = int.Parse(Console.ReadLine());//Guarda en la variable 

                    for (int i = 0; i < NumTareas; i++)//se crea un for 
                    {
                        AgregarOtraTarea();//Se utiliza el metodo AgregarOtraTarea
                    }

                    Menu();//Se llama el metodo Menu()
                    break;

                case 2://Caso 
                    VerTareas();// Se llama el metodo 
                    break;

                case 3://Caso 
                    EditarTarea();// Se llama el metodo 
                    break;

                case 4://Caso 
                    Console.WriteLine("Gracias por utilizar el programa");//Se imprime en pantalla 
                    Console.ReadKey();
                    Environment.Exit(0);//Para salir 
                    break;
            }
        }

        public void AgregarOtraTarea()//Metodo 
        {
            Console.Clear();//Limpia la pantalla 
            Console.WriteLine("ID: ");//Escribe en la pantalla 
            id = int.Parse(Console.ReadLine());//se guarda en la variable 
            foreach (var item in Pendiente)//por cada item en Pendiente 
            {
                while (HomeWork.ID == id)//Mientras la propiedad ID sea igual a la variable id 
                {
                    Console.WriteLine("Esta tarea ya existe; favor de agregar una nueva tarea");//Se escribe en pantalla 
                    Console.Write("ID: ");//Vualve a pedir el ID 
                    id = int.Parse(Console.ReadLine());//Se guarda en la variable 
                }

            }

            Console.WriteLine("Nombre de la Tarea: ");//Se imprime en pantalla 
            NomTarea = Console.ReadLine();//Se guarda en la variable 
            Console.Write("Descripcion: ");//Se imprime en pantalla 
            desc = Console.ReadLine();//Se guarda en la variable 
            status = "Pendiente";//Se le da un valor a status 
            Console.Write("Descripcion del Status: ");//Se imprime en pantalla 
            desStat = Console.ReadLine();//Se guarda en la variable 
            Console.WriteLine();//Salto de linea 
            HomeWork = new Tarea(id, NomTarea, desc, fechaInicio, fechaFin, status, desStat);//Se le manda las variables como parametros del objeto  HomeWork 
            Pendiente.Add(HomeWork);//Se añade a la lista una nueva tarea 
        }

        public void VerTareas()//Metodo 
        {
            Console.Clear();//Se limpia la pantalla         
            Console.WriteLine("1. Pendientes");//Se imprime en consola 
            Console.WriteLine("2. En Proceso");//Se imprime en consola 
            Console.WriteLine("3. Terminadas");//Se imprime en consola 
            Console.Write("Presione el número del tipo de tarea que desea ver: ");//Se imprime en consola 
            opcion = int.Parse(Console.ReadLine());//Se guarda en la variable 

            switch (opcion)//Swich para las opciones 
            {
                case 1://caso 
                    Console.Clear();//Limpia la pantalla 
                    Console.WriteLine("Tareas pendientes");//Escribe en pantalla 
                    foreach (var item in Pendiente)//Por cada item en Pendiente 
                    {
                        Console.WriteLine(item.ID);//Escribe los Id de las tareas 
                    }
                    Console.WriteLine("Escriba el id de la tarea:");//Pregunta cual Id desea ver 
                    id = int.Parse(Console.ReadLine());//Se guarda en la varible 
                    foreach (var item in Pendiente)//Por cada item en Pendiente 
                    {
                        if (item.ID == id)//si el ID de la propiedad es igual al que introdujo el usuario 
                        {
                            Console.WriteLine();//Salto de linea 
                            Console.WriteLine("ID: {0}", item.ID);//Se imprime en pantalla 
                            Console.WriteLine("Nombre: {0}", item.NombreTarea);//Se imprime en pantalla 
                            Console.WriteLine("Descripción: {0}", item.Descripcion);//Se imprime en pantalla 
                            Console.WriteLine("Status: {0}", item.Status);//Se imprime en pantalla 
                            Console.WriteLine("Descripción del Status: {0}", item.DescripcionStatus);//Se imprime en pantalla 
                            Console.WriteLine();//Salto de linea
                        }
                    }
                    Console.Write("Presione una tecla para continuar: ");//Se imprime en pantalla 
                    Console.ReadKey();//Se detiene la ejecucion 
                    Menu();//Se llama al metodo Menu()
                    break;

                case 2://caso 
                    Console.Clear();//Se limpia la pantalla 
                    Console.WriteLine("Tareas en proceso");//Se imprime en pantalla 
                    foreach (var item in EnProceso)//por cada item en EnProceso
                    {
                        Console.WriteLine(item.ID);//Se ecribe los Id 
                    }
                    Console.WriteLine("\nEscriba el id de la tarea:");//Se imprime en pantalla 
                    id = int.Parse(Console.ReadLine());//Se guarda en id  
                    foreach (var item in EnProceso)//por cada item en EnProceso
                    {
                        if (item.ID == id)//si el ID de la propiedad es igual al que introdujo el usuario 
                        {
                            Console.WriteLine();//Salto de linea 
                            Console.WriteLine("ID: {0}", item.ID);//Se imprime en pantalla 
                            Console.WriteLine("Nombre: {0}", item.NombreTarea);//Se imprime en pantalla 
                            Console.WriteLine("Descripción: {0}", item.Descripcion);//Se imprime en pantalla 
                            Console.WriteLine("Status: {0}", item.Status);//Se imprime en pantalla 
                            Console.WriteLine("Fecha de inicio: {0}", item.FechaInicio);//Se imprime en pantalla 
                            Console.WriteLine("Descripción del Status: {0}", item.DescripcionStatus);//Se imprime en pantalla 
                            Console.WriteLine();//Salto de linea
                        }

                    }
                    Console.Write("Presione una tecla para continuar: ");//Se imprime en pantalla 
                    Console.ReadKey();
                    Menu();
                    break;

                case 3://caso 
                    Console.Clear();//Limpia la pantalla 
                    Console.WriteLine("Tareas terminadas");//Se imprime en pantalla 
                    foreach (var item in Terminadas)//por cada item en Terminadas 
                    {
                        Console.WriteLine(item.ID);//Imprime el id 
                    }
                    Console.WriteLine("Escriba el id de la tarea:");//Se imprime en pantalla 
                    id = int.Parse(Console.ReadLine());//Se guarda en id 
                    foreach (var item in Terminadas)//Por cada item en Terminadas 
                    {
                        if (item.ID == id)//si el ID de la propiedad es igual al que introdujo el usuario 
                        {
                            Console.WriteLine();//Salto de linea 
                            Console.WriteLine("ID: {0}", item.ID);//Se imprime en pantalla 
                            Console.WriteLine("Nombre: {0}", item.NombreTarea);//Se imprime en pantalla 
                            Console.WriteLine("Descripción: {0}", item.Descripcion);//Se imprime en pantalla 
                            Console.WriteLine("Status: {0}", item.Status);//Se imprime en pantalla 
                            Console.WriteLine("Fecha de inicio: {0}", item.FechaInicio);//Se imprime en pantalla 
                            Console.WriteLine("Fecha de finalización: {0}", item.FechaFin);//Se imprime en pantalla 
                            Console.WriteLine("Descripción del Status: {0}", item.DescripcionStatus);//Se imprime en pantalla 
                            Console.WriteLine();//Salto de linea 
                        }
                    }
                    Console.Write("Presione una tecla para continuar: ");//Se imprime en pantalla 
                    Console.ReadKey();
                    Menu();
                    break;
            }
        }

        public void Inicio()
        {
            Console.WriteLine("ToDoList Program");//Se imprime en pantalla 
            Console.Write("Cuantas tareas desea Agregar: ");//Se imprime en pantalla 
            NumTareas = int.Parse(Console.ReadLine());//se guarda en la variable 

            for (int i = 0; i < NumTareas; i++)//Se crea un for 
            {
                AgregarTareaInicial();//llamada del metodo 
            }
            Console.Write("Presione una tecla para continuar ");//Se imprime en pantalla 
            Console.ReadKey();//Se detiene la ejecucion

            Menu();//llamada del metodo Menu()

        }
    }
}
