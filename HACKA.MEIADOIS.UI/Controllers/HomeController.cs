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



        [HttpGet]
        public ActionResult Dashboard()
        {
            return View();
        }



        
        [HttpPost]
        public ActionResult Dashboard(String query)
        {
            MercadoLivre ml = new MercadoLivre();
            List<Result> resultados = ml.ObterResultados(query);

            List<Double> dResultados = new List<double>();

            double media;
            foreach (Result r in resultados)
            {
                
                dResultados.Add(r.price);
            }


            ViewBag.maximo = dResultados.Max();
            ViewBag.minimo = dResultados.Min();
            ViewBag.media = dResultados.Average();

            ViewBag.melhor1 = "Jackson Andrade";
            ViewBag.melhor2 = "Zenilson Souza";
            ViewBag.melhor3 = "Gabriel Silva";
            
            return View();
        }
    }
}