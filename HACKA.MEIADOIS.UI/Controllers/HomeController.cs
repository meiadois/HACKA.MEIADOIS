using HACKA.MEIADOIS.UI.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace HACKA.MEIADOIS.UI.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Dashboard()
        {
            MercadoLivre ml = new MercadoLivre();
            List<Result> resultados = ml.ObterResultados();
            double media = 0.0;

            foreach (Result r in resultados)
            {
                media += r.price;
            }
            media = media / resultados.Count;
            ViewBag.media = media;
            return View();
        }
    }
}