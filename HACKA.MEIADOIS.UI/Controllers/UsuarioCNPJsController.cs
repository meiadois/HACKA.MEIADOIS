using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HACKA.MEIADOIS.UI.Data;
using HACKA.MEIADOIS.UI.Models;

namespace HACKA.MEIADOIS.UI.Controllers
{
    public class UsuarioCNPJsController : Controller
    {
        private HackaMeiaDoisDataContext db = new HackaMeiaDoisDataContext();

        // GET: UsuarioCNPJs
        public ActionResult Index()
        {
            return View(db.UsuarioCNPJ.ToList());
        }

        // GET: UsuarioCNPJs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UsuarioCNPJ usuarioCNPJ = db.UsuarioCNPJ.Find(id);
            if (usuarioCNPJ == null)
            {
                return HttpNotFound();
            }
            return View(usuarioCNPJ);
        }

        // GET: UsuarioCNPJs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioCNPJs/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CNPJ,Senha")] UsuarioCNPJ usuarioCNPJ)
        {
            if (ModelState.IsValid)
            {
                db.UsuarioCNPJ.Add(usuarioCNPJ);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usuarioCNPJ);
        }

        // GET: UsuarioCNPJs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UsuarioCNPJ usuarioCNPJ = db.UsuarioCNPJ.Find(id);
            if (usuarioCNPJ == null)
            {
                return HttpNotFound();
            }
            return View(usuarioCNPJ);
        }

        // POST: UsuarioCNPJs/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CNPJ,Senha")] UsuarioCNPJ usuarioCNPJ)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuarioCNPJ).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuarioCNPJ);
        }

        // GET: UsuarioCNPJs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UsuarioCNPJ usuarioCNPJ = db.UsuarioCNPJ.Find(id);
            if (usuarioCNPJ == null)
            {
                return HttpNotFound();
            }
            return View(usuarioCNPJ);
        }

        // POST: UsuarioCNPJs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UsuarioCNPJ usuarioCNPJ = db.UsuarioCNPJ.Find(id);
            db.UsuarioCNPJ.Remove(usuarioCNPJ);
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
