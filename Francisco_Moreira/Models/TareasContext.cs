using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Francisco_Moreira.Models
{
    public class TareasContext : DbContext
    {
        public TareasContext() : base("TareasContext") 
        {
        }
        public DbSet<Tarea> Tareas { get; set; }
    }
}