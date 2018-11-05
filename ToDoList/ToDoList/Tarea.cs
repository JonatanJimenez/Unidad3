using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Tarea
    {
        //Propiedades
        public int ID { get; set; }
        public string NombreTarea { get; set; }
        public string Descripcion { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string Status { get; set; }
        public string DescripcionStatus { get; set; }

        //Constructor
        public Tarea(int Id, string NomTarea, string Stat, string Descrip, string FechaIn, string FechaFi, string DescripStat)
        {
            ID = Id;
            NombreTarea = NomTarea;
            Status = Stat;
            Descripcion = Descrip;
            FechaInicio = FechaIn;
            FechaFin = FechaFi;
            DescripcionStatus = DescripStat;
        }
    }
}
