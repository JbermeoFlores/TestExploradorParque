using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using TestExplorador.Models;

namespace TestExplorador.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public String Proceso(String sonidos)
        {
            TestExplorador.Models.Grillo g = new TestExplorador.Models.Grillo();
            TestExplorador.Models.Rana r = new TestExplorador.Models.Rana();
            TestExplorador.Models.Libelula l = new TestExplorador.Models.Libelula();

            String mensaje = "El resto de la melodia es: ";

            switch (sonidos)
            {
                case "r1":
                    mensaje = mensaje + r.melodia1();
                break;

                case "r2":
                mensaje = mensaje + r.melodia2();
                break;

                case "r3":
                mensaje = mensaje + r.melodia3();
                break;

                case "r4":
                mensaje = mensaje + r.melodia4();
                break;

                case "l1":
                mensaje = mensaje + l.melodia1();
                break;

                case "l2":
                mensaje = mensaje + l.melodia2();
                break;

                case "l3":
                mensaje = mensaje + l.melodia3();
                break;

                case "g1":
                mensaje = mensaje + g.melodia1();
                break;

                case "g2":
                mensaje = mensaje + g.melodia2();
                break;

                case "g3":
                mensaje = mensaje + g.melodia3();
                break;

                default:
                mensaje = "El sonido no corresponde";
                break;
            }

            return mensaje;
            
        }
    }
}