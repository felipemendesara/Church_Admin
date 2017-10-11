using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sitema_Dashboard_Site.Models;

namespace Sitema_Dashboard_Site.Controllers
{
    public class DevocionalController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Devocional
        public ActionResult Index()
        {
            return View(db.Devocionals.ToList());
        }

        // GET: Devocional/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Devocional devocional = db.Devocionals.Find(id);
            if (devocional == null)
            {
                return HttpNotFound();
            }
            return View(devocional);
        }

        // GET: Devocional/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Devocional/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdDevocional,TituloDevocional,TextoDevocional,Autor,LivroBase,CapituloBase,VersiculoInicioBase,VersiculoFinalBase")] Devocional devocional)
        {
            if (ModelState.IsValid)
            {
                db.Devocionals.Add(devocional);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(devocional);
        }

        // GET: Devocional/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Devocional devocional = db.Devocionals.Find(id);
            if (devocional == null)
            {
                return HttpNotFound();
            }
            return View(devocional);
        }

        // POST: Devocional/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdDevocional,TituloDevocional,TextoDevocional,Autor,LivroBase,CapituloBase,VersiculoInicioBase,VersiculoFinalBase")] Devocional devocional)
        {
            if (ModelState.IsValid)
            {
                db.Entry(devocional).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(devocional);
        }

        // GET: Devocional/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Devocional devocional = db.Devocionals.Find(id);
            if (devocional == null)
            {
                return HttpNotFound();
            }
            return View(devocional);
        }

        // POST: Devocional/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Devocional devocional = db.Devocionals.Find(id);
            db.Devocionals.Remove(devocional);
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
