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
    public class PrecoProdutosController : Controller
    {
        private HackaMeiaDoisDataContext db = new HackaMeiaDoisDataContext();

        // GET: PrecoProdutos
        public ActionResult Index()
        {
            return View(db.PrecoProdutoes.ToList());
        }

        // GET: PrecoProdutos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrecoProduto precoProduto = db.PrecoProdutoes.Find(id);
            if (precoProduto == null)
            {
                return HttpNotFound();
            }
            return View(precoProduto);
        }

        // GET: PrecoProdutos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrecoProdutos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NomeProduto,CategoriaProduto,PrecoCompra")] PrecoProduto precoProduto)
        {
            if (ModelState.IsValid)
            {
                db.PrecoProdutoes.Add(precoProduto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(precoProduto);
        }

        // GET: PrecoProdutos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrecoProduto precoProduto = db.PrecoProdutoes.Find(id);
            if (precoProduto == null)
            {
                return HttpNotFound();
            }
            return View(precoProduto);
        }

        // POST: PrecoProdutos/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NomeProduto,CategoriaProduto,PrecoCompra")] PrecoProduto precoProduto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(precoProduto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(precoProduto);
        }

        // GET: PrecoProdutos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrecoProduto precoProduto = db.PrecoProdutoes.Find(id);
            if (precoProduto == null)
            {
                return HttpNotFound();
            }
            return View(precoProduto);
        }

        // POST: PrecoProdutos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PrecoProduto precoProduto = db.PrecoProdutoes.Find(id);
            db.PrecoProdutoes.Remove(precoProduto);
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
