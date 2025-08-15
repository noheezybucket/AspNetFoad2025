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
    public class LivreursController : Controller
    {
        private BdTrackingContext db = new BdTrackingContext();

        // GET: Livreurs
        public ActionResult Index()
        {
            return View(db.userColis.ToList());
        }

        // GET: Livreurs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Livreur livreur = db.livreurs.Find(id);
            if (livreur == null)
            {
                return HttpNotFound();
            }
            return View(livreur);
        }

        // GET: Livreurs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Livreurs/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdUserColis,Nom,Prenom,CNI,Telephone,Email,Adresse,Statut,Matricule,CarteGrise,Permis")] Livreur livreur)
        {
            if (ModelState.IsValid)
            {
                db.userColis.Add(livreur);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(livreur);
        }

        // GET: Livreurs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Livreur livreur = db.livreurs.Find(id);
            if (livreur == null)
            {
                return HttpNotFound();
            }
            return View(livreur);
        }

        // POST: Livreurs/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdUserColis,Nom,Prenom,CNI,Telephone,Email,Adresse,Statut,Matricule,CarteGrise,Permis")] Livreur livreur)
        {
            if (ModelState.IsValid)
            {
                db.Entry(livreur).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(livreur);
        }

        // GET: Livreurs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Livreur livreur = db.livreurs.Find(id);
            if (livreur == null)
            {
                return HttpNotFound();
            }
            return View(livreur);
        }

        // POST: Livreurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Livreur livreur = db.livreurs.Find(id);
            db.userColis.Remove(livreur);
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
