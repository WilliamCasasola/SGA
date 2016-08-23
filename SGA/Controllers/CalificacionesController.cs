using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SGA.Models;

namespace SGA.Controllers
{
    public class CalificacionesController : Controller
    {
        private SGAContext db = new SGAContext();

        // GET: Calificaciones
        public ActionResult Index()
        {
            var calificaciones = db.calificaciones.Include(c => c.estudiante);
            return View(calificaciones.ToList());
        }

        // GET: Calificaciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calificacion calificacion = db.calificaciones.Find(id);
            if (calificacion == null)
            {
                return HttpNotFound();
            }
            return View(calificacion);
        }

        // GET: Calificaciones/Create
        public ActionResult Create()
        {
            ViewBag.ClienteId = new SelectList(db.clientes, "ClienteId", "nombre");
            return View();
        }

        // POST: Calificaciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CalificacionId,CursoId,numero,tipo,ClienteId,nota")] Calificacion calificacion)
        {
            if (ModelState.IsValid)
            {
                db.calificaciones.Add(calificacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClienteId = new SelectList(db.clientes, "ClienteId", "nombre", calificacion.ClienteId);
            return View(calificacion);
        }

        // GET: Calificaciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calificacion calificacion = db.calificaciones.Find(id);
            if (calificacion == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClienteId = new SelectList(db.clientes, "ClienteId", "nombre", calificacion.ClienteId);
            return View(calificacion);
        }

        // POST: Calificaciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CalificacionId,CursoId,numero,tipo,ClienteId,nota")] Calificacion calificacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calificacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClienteId = new SelectList(db.clientes, "ClienteId", "nombre", calificacion.ClienteId);
            return View(calificacion);
        }

        // GET: Calificaciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calificacion calificacion = db.calificaciones.Find(id);
            if (calificacion == null)
            {
                return HttpNotFound();
            }
            return View(calificacion);
        }

        // POST: Calificaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Calificacion calificacion = db.calificaciones.Find(id);
            db.calificaciones.Remove(calificacion);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
