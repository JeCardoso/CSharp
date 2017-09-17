using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DVD_MVC5.Controllers
{
    public class OlaMundoController : Controller
    {
        // GET: /OlaMundo/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /OlaMundo/QueridoController
        public string QueridoController()
        {
            return "Texto <b>em negrito</b>, retorno do Controller";
        }

        // GET: /OlaMundo/GetJson
        public JsonResult GetJson()
        {
            var produto = new {
                ID = 12,
                Nome = "Bicicleta",
                Qtde = 10
            };
            return Json(produto, JsonRequestBehavior.AllowGet);
        }

        // GET: /OlaMundo/GetDados?nome=Jean&idade=23
        public string GetDados(string nome, int idade = 20)
        {
            return HttpUtility.HtmlEncode( string.Format("Bem vindo {0}, com idade {1}", nome, idade));
        }

    }
}