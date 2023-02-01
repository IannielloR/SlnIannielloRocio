using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SlnIannielloRocio.Data;
using SlnIannielloRocio.Models;
using System.Collections.Generic;
using System.Linq;

namespace SlnIannielloRocio.Controllers
{
    public class RecetaController : Controller
    {
        private readonly DbRecetasContext context;
        public RecetaController(DbRecetasContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var receta = context.Recetas.ToList();
            return View(receta);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Receta receta = new Receta();

            return View("Create", receta);
        }

        [HttpPost]
        public ActionResult Create(Receta receta)
        {
            if (ModelState.IsValid)
            {
                context.Recetas.Add(receta);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(receta);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Receta receta = TraerUna(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                return View("Details", receta);
            }
        }
        [HttpGet]
        public IActionResult DetailsByTitle(string nombre, string apellido)
        {
            var recetas  = (from r in context.Recetas
                             where r.AutorNombre == nombre && r.AutorApellido == apellido
                             select r).ToList();

            if (recetas == null)
                return NotFound();

            return View("DetailsByTitle", recetas);
        }

        private Receta TraerUna(int id)
        {
            return context.Recetas.Find(id);
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            var receta = TraerUna(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", receta);
            }

        }

        [ActionName("Delete")]
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            Receta receta = TraerUna(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                context.Recetas.Remove(receta);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var receta = context.Recetas.Find(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                return View("Edit", receta);
            }
        }


        [ActionName("Edit")]
        [HttpPost]
        public ActionResult EditConfirmed(Receta receta)
        {
            context.Entry(receta).State = EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
