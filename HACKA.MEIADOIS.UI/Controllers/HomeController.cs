using HACKA.MEIADOIS.UI.Api;
using System;
using System.Collections.Generic;
using System.Linq;
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
            string ft_melhor1 = "";
            string ft_melhor2 = "";
            string ft_melhor3 = "";

            List<String> melhoresEmpresas = new List<String>();

            int cont = 0;
            foreach (Result r in resultados)
            {

                switch (cont)
                {
                    case 0:
                        melhor1 = ml.pegarNomeVendedor(r.seller.id);
                        melhoresEmpresas.Add(melhor1);
                        ft_melhor1 = r.thumbnail;
                        break;
                    case 1:
                        if (melhoresEmpresas.Any(ml.pegarNomeVendedor(r.seller.id).Contains))
                        {
                            cont--;
                        }
                        else
                        {
                            melhor2 = ml.pegarNomeVendedor(r.seller.id);
                            melhoresEmpresas.Add(melhor2);
                            ft_melhor2 = r.thumbnail;
                        }
                        break;
                    case 2:
                        if (melhoresEmpresas.Any(ml.pegarNomeVendedor(r.seller.id).Contains))
                        {
                            cont--;
                        }
                        else
                        {
                            melhor3 = ml.pegarNomeVendedor(r.seller.id);
                            melhoresEmpresas.Add(melhor3);
                            ft_melhor3 = r.thumbnail;
                        }
                        break;
                    default:
                        break;
                }

                dResultados.Add(r.price);
                cont++;
            }

            if (melhor1.Equals("") && melhor2.Equals("") && melhor3.Equals(""))
            {
                melhor1 = "";
                melhor2 = "";
                melhor3 = "";
            }

            if(dResultados.Count != 0)
            {
                ViewBag.maximo = dResultados.Max();
                ViewBag.minimo = dResultados.Min();
                ViewBag.media = dResultados.Average();
            }

            ViewBag.melhor1 = melhor1;
            ViewBag.melhor2 = melhor2;
            ViewBag.melhor3 = melhor3;
            ViewBag.ftmelhor1 = ft_melhor1;
            ViewBag.ftmelhor2 = ft_melhor2;
            ViewBag.ftmelhor3 = ft_melhor3;

            return View();
        }
    }
}