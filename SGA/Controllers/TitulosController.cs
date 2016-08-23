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
    public class TitulosController : Controller
    {
        private SGAContext db = new SGAContext();

        // GET: Titulos
        public ActionResult Index()
        {
            return View(db.titulos.ToList());
        }

        // GET: Titulos/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Titulo titulo = db.titulos.Find(id);
            if (titulo == null)
            {
                return HttpNotFound();
            }
            return View(titulo);
        }

        // GET: Titulos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Titulos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductoId,precio,nombre,rutaFoto")] Titulo titulo)
        {
            if (ModelState.IsValid)
            {
                db.titulos.Add(titulo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(titulo);
        }

        // GET: Titulos/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Titulo titulo = db.titulos.Find(id);
            if (titulo == null)
            {
                return HttpNotFound();
            }
            return View(titulo);
        }

        // POST: Titulos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductoId,precio,nombre,rutaFoto")] Titulo titulo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(titulo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(titulo);
        }

        // GET: Titulos/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Titulo titulo = db.titulos.Find(id);
            if (titulo == null)
            {
                return HttpNotFound();
            }
            return View(titulo);
        }

        // POST: Titulos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Titulo titulo = db.titulos.Find(id);
            db.titulos.Remove(titulo);
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
