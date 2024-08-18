namespace Francisco_Moreira.Migrations
{
    using Francisco_Moreira.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Francisco_Moreira.Models.TareasContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Francisco_Moreira.Models.TareasContext context)
        {
         /*   context.Tareas.AddOrUpdate(
       t => t.Titulo,
       new Tarea { Titulo = "Tarea 1", Descripcion = "Descripción 1", FechaCreacion = DateTime.Now, FechaVencimiento = DateTime.Now.AddDays(7), Completada = false },
       new Tarea { Titulo = "Tarea 2", Descripcion = "Descripción 2", FechaCreacion = DateTime.Now, FechaVencimiento = DateTime.Now.AddDays(14), Completada = false }
     );*/
        }
    }
}
