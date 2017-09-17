using Mini.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mini.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var obj = new ArquivoViewModel() { Origem = "origem.html", Destino = "destino.html" };
            return View(obj);
        }

        [HttpPost]
        public ActionResult Executar(ArquivoViewModel arquivo)
        {
            var caminho = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;
            Minificador.Executar(new string[] {
                "/o=" + Path.Combine(caminho, arquivo.Origem),
                "/d=" + Path.Combine(caminho, arquivo.Destino)
            });

            return RedirectToAction("Confirmacao", new { arquivo.Destino });
        }

        public ActionResult Confirmacao(string destino)
        {
            ViewBag.Arquivo = destino;
            return View();
        }

        public ActionResult Sobre()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}