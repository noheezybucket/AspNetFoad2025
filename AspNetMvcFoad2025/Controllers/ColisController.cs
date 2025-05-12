using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AspNetMvcFoad2025.Models;

namespace AspNetMvcFoad2025.Controllers
{
    public class ColisController : Controller
    {
        private BdTrackingContext db = new BdTrackingContext();

        // GET: Colis
        public ActionResult Index()
        {
            return View(db.colis.ToList());
        }

        // GET: Colis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Colis colis = db.colis.Find(id);
            if (colis == null)
            {
                return HttpNotFound();
            }
            return View(colis);
        }

        public ActionResult CreateColis() 
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateColis([Bind(Include = "IdColis,CodeColis,LibelleColis,DescriptionColis,PoidsColis,TypeColis")] Colis colis)
        {
            if (ModelState.IsValid)
            {
                db.colis.Add(colis);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(colis);
        }

        // GET: Colis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Colis/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdColis,CodeColis,LibelleColis,DescriptionColis,PoidsColis,TypeColis")] Colis colis)
        {
            if (ModelState.IsValid)
            {
                db.colis.Add(colis);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(colis);
        }

        // GET: Colis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Colis colis = db.colis.Find(id);
            if (colis == null)
            {
                return HttpNotFound();
            }
            return View(colis);
        }

        // POST: Colis/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdColis,CodeColis,LibelleColis,DescriptionColis,PoidsColis,TypeColis")] Colis colis)
        {
            if (ModelState.IsValid)
            {
                db.Entry(colis).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(colis);
        }

        // GET: Colis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Colis colis = db.colis.Find(id);
            if (colis == null)
            {
                return HttpNotFound();
            }
            return View(colis);
        }

        // POST: Colis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Colis colis = db.colis.Find(id);
            db.colis.Remove(colis);
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
