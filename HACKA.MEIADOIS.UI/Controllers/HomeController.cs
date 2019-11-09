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

            string melhor1 = "";
            string melhor2 = "";
            string melhor3 = "";


            int cont = 0;
            foreach (Result r in resultados)
            {
                switch (cont)
                {
                    case 0:
                        
                        melhor1 = ml.pegarNomeVendedor(r.seller.id);
                        break;
                    case 1:
                        // pega visão
                        if (melhor2.Equals(melhor1) || melhor3.Equals(melhor1))
                        {
                            cont--;
                            break;
                        }
                        melhor2 = ml.pegarNomeVendedor(r.seller.id);
                        break;
                    case 2:
                        if (melhor3.Equals(melhor2) || melhor3.Equals(melhor1))
                        {
                            cont--;
                            break;
                        }
                        melhor3 = ml.pegarNomeVendedor(r.seller.id);
                        break;
                    default:
                        break;


                }
                
                dResultados.Add(r.price);
                cont++;
            }

            if(melhor1.Equals("") && melhor2.Equals("") && melhor3.Equals(""))
            {
                melhor1 = "";
                melhor2 = "";
                melhor3 = "";
            }

            ViewBag.maximo = dResultados.Max();
            ViewBag.minimo = dResultados.Min();
            ViewBag.media = dResultados.Average();

            ViewBag.melhor1 = melhor1;

            ViewBag.melhor2 = melhor2;
            ViewBag.melhor3 = melhor3;
            
            return View();
        }
    }
}