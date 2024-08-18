using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Francisco_Moreira.Models
{
    public class Tarea
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public bool Completada { get; set; }
    }
}