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
    public class FacturadosController : Controller
    {
        private SGAContext db = new SGAContext();

        // GET: Facturados
        public ActionResult Index()
        {
            var facturados = db.facturados.Include(f => f.estudiante);
            return View(facturados.ToList());
        }

        // GET: Facturados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facturado facturado = db.facturados.Find(id);
            if (facturado == null)
            {
                return HttpNotFound();
            }
            return View(facturado);
        }

        // GET: Facturados/Create
        public ActionResult Create()
        {
            ViewBag.ClienteId = new SelectList(db.clientes, "ClienteId", "nombre");
            return View();
        }

        // POST: Facturados/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FacturadoId,ClienteId")] Facturado facturado)
        {
            if (ModelState.IsValid)
            {
                db.facturados.Add(facturado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClienteId = new SelectList(db.clientes, "ClienteId", "nombre", facturado.ClienteId);
            return View(facturado);
        }

        // GET: Facturados/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facturado facturado = db.facturados.Find(id);
            if (facturado == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClienteId = new SelectList(db.clientes, "ClienteId", "nombre", facturado.ClienteId);
            return View(facturado);
        }

        // POST: Facturados/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FacturadoId,ClienteId")] Facturado facturado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(facturado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClienteId = new SelectList(db.clientes, "ClienteId", "nombre", facturado.ClienteId);
            return View(facturado);
        }

        // GET: Facturados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facturado facturado = db.facturados.Find(id);
            if (facturado == null)
            {
                return HttpNotFound();
            }
            return View(facturado);
        }

        // POST: Facturados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Facturado facturado = db.facturados.Find(id);
            db.facturados.Remove(facturado);
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
