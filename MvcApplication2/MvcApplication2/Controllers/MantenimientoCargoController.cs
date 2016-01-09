using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class MantenimientoCargoController : Controller
    {
        private testappEntities db = new testappEntities();

        //
        // GET: /MantenimientoCargo/

        public ActionResult Index()
        {
            return View(db.cargo.ToList());
        }

        //
        // GET: /MantenimientoCargo/Details/5

        public ActionResult Details(int id = 0)
        {
            cargo cargo = db.cargo.Find(id);
            if (cargo == null)
            {
                return HttpNotFound();
            }
            return View(cargo);
        }

        //
        // GET: /MantenimientoCargo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MantenimientoCargo/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(cargo cargo)
        {
            if (ModelState.IsValid)
            {
                db.cargo.Add(cargo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cargo);
        }

        //
        // GET: /MantenimientoCargo/Edit/5

        public ActionResult Edit(int id = 0)
        {
            cargo cargo = db.cargo.Find(id);
            if (cargo == null)
            {
                return HttpNotFound();
            }
            return View(cargo);
        }

        //
        // POST: /MantenimientoCargo/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(cargo cargo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cargo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cargo);
        }

        //
        // GET: /MantenimientoCargo/Delete/5

        public ActionResult Delete(int id = 0)
        {
            cargo cargo = db.cargo.Find(id);
            if (cargo == null)
            {
                return HttpNotFound();
            }
            return View(cargo);
        }

        //
        // POST: /MantenimientoCargo/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            cargo cargo = db.cargo.Find(id);
            db.cargo.Remove(cargo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}