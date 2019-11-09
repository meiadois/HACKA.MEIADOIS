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
    public class UsuarioCPFsController : Controller
    {
        private HackaMeiaDoisDataContext db = new HackaMeiaDoisDataContext();

        // GET: UsuarioCPFs
        public ActionResult Index()
        {
            return View(db.UsuarioCPF.ToList());
        }

        // GET: UsuarioCPFs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UsuarioCPF usuarioCPF = db.UsuarioCPF.Find(id);
            if (usuarioCPF == null)
            {
                return HttpNotFound();
            }
            return View(usuarioCPF);
        }

        // GET: UsuarioCPFs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioCPFs/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CPF,Senha")] UsuarioCPF usuarioCPF)
        {
            if (ModelState.IsValid)
            {
                db.UsuarioCPF.Add(usuarioCPF);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usuarioCPF);
        }

        // GET: UsuarioCPFs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UsuarioCPF usuarioCPF = db.UsuarioCPF.Find(id);
            if (usuarioCPF == null)
            {
                return HttpNotFound();
            }
            return View(usuarioCPF);
        }

        // POST: UsuarioCPFs/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CPF,Senha")] UsuarioCPF usuarioCPF)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuarioCPF).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuarioCPF);
        }

        // GET: UsuarioCPFs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UsuarioCPF usuarioCPF = db.UsuarioCPF.Find(id);
            if (usuarioCPF == null)
            {
                return HttpNotFound();
            }
            return View(usuarioCPF);
        }

        // POST: UsuarioCPFs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UsuarioCPF usuarioCPF = db.UsuarioCPF.Find(id);
            db.UsuarioCPF.Remove(usuarioCPF);
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
