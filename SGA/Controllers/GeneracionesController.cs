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
    public class GeneracionesController : Controller
    {
        private SGAContext db = new SGAContext();

        // GET: Generaciones
        public ActionResult Index()
        {
            return View(db.generaciones.ToList());
        }

        // GET: Generaciones/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Generacion generacion = db.generaciones.Find(id);
            if (generacion == null)
            {
                return HttpNotFound();
            }
            return View(generacion);
        }

        // GET: Generaciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Generaciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GeneracionId,ano")] Generacion generacion)
        {
            if (ModelState.IsValid)
            {
                db.generaciones.Add(generacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(generacion);
        }

        // GET: Generaciones/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Generacion generacion = db.generaciones.Find(id);
            if (generacion == null)
            {
                return HttpNotFound();
            }
            return View(generacion);
        }

        // POST: Generaciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GeneracionId,ano")] Generacion generacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(generacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(generacion);
        }

        // GET: Generaciones/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Generacion generacion = db.generaciones.Find(id);
            if (generacion == null)
            {
                return HttpNotFound();
            }
            return View(generacion);
        }

        // POST: Generaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Generacion generacion = db.generaciones.Find(id);
            db.generaciones.Remove(generacion);
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
