using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTareasAvanzado
{
    public class Tarea
    {
        //Atributos de la clase tarea
        public string Nombre { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }
        public string Prioridad { get; set; }
        public bool Estado { get; set; }
        public string Comentario { get; set; }

        //Constructor con nombre, fecha de vencimiento, prioridad, estado y comentario
        public Tarea(string nombre, DateTime fecha_vencimiento, string prioridad, string comentario)
        {
            this.Nombre = nombre;
            this.Fecha_Vencimiento = fecha_vencimiento;
            this.Prioridad = prioridad;
            this.Estado = false;
            this.Comentario = comentario;
        }

        //Constructor con nombre, fecha de vencimiento, prioridad y estado
        public Tarea(string nombre, DateTime fecha_vencimiento, string prioridad)
        {
            this.Nombre = nombre;
            this.Fecha_Vencimiento = fecha_vencimiento;
            this.Prioridad = prioridad;
            this.Estado = false;
            this.Comentario = "";
        }
    }

}
