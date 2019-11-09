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
    public class HistoricosController : Controller
    {
        private HackaMeiaDoisDataContext db = new HackaMeiaDoisDataContext();

        // GET: Historicoes
        public ActionResult Index()
        {
            return View(db.Historicoes.ToList());
        }

        // GET: Historicoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Historico historico = db.Historicoes.Find(id);
            if (historico == null)
            {
                return HttpNotFound();
            }
            return View(historico);
        }

        // GET: Historicoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Historicoes/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ProdutoId,NomeProduto,CategoriaProduto,PrecoProduto,DataRegistro")] Historico historico)
        {
            if (ModelState.IsValid)
            {
                db.Historicoes.Add(historico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(historico);
        }

        // GET: Historicoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Historico historico = db.Historicoes.Find(id);
            if (historico == null)
            {
                return HttpNotFound();
            }
            return View(historico);
        }

        // POST: Historicoes/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ProdutoId,NomeProduto,CategoriaProduto,PrecoProduto,DataRegistro")] Historico historico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(historico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(historico);
        }

        // GET: Historicoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Historico historico = db.Historicoes.Find(id);
            if (historico == null)
            {
                return HttpNotFound();
            }
            return View(historico);
        }

        // POST: Historicoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Historico historico = db.Historicoes.Find(id);
            db.Historicoes.Remove(historico);
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
