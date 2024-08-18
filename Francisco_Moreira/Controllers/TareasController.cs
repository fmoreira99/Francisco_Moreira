using Francisco_Moreira.Models;
using System.Linq;
using System.Web.Mvc;

namespace Francisco_Moreira.Controllers
{
    public class TareasController : Controller
    {
        private TareasContext db = new TareasContext();

        // GET: Tareas
        public ActionResult Index()
        {
            var tareas = db.Tareas.ToList(); 
            return View(tareas); 
        }

        // GET: Tareas/Details/5
        public ActionResult Details(int id)
        {
            Tarea tarea = db.Tareas.Find(id);
            if (tarea == null)
            {
                return HttpNotFound();
            }
            return View(tarea);
        }

        // GET: Tareas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tareas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tarea tarea)
        {
            if (ModelState.IsValid)
            {
                db.Tareas.Add(tarea);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tarea);
        }

        // GET: Tareas/Edit/5
        public ActionResult Edit(int id)
        {
            Tarea tarea = db.Tareas.Find(id);
            if (tarea == null)
            {
                return HttpNotFound();
            }
            return View(tarea);
        }

        // POST: Tareas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Tarea tarea)
        {
            if (ModelState.IsValid)
            {
                var existingTarea = db.Tareas.Find(id);
                if (existingTarea == null)
                {
                    return HttpNotFound();
                }

                existingTarea.Titulo = tarea.Titulo;
                existingTarea.Descripcion = tarea.Descripcion;
                existingTarea.FechaVencimiento = tarea.FechaVencimiento;
                existingTarea.Completada = tarea.Completada;

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tarea);
        }

        // GET: Tareas/Delete/5
        public ActionResult Delete(int id)
        {
            Tarea tarea = db.Tareas.Find(id);
            if (tarea == null)
            {
                return HttpNotFound();
            }
            return View(tarea);
        }

        // POST: Tareas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tarea tarea = db.Tareas.Find(id);
            if (tarea == null)
            {
                return HttpNotFound();
            }

            db.Tareas.Remove(tarea);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
