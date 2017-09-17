using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DVD_MVC5.Controllers
{
    // 3 - atribuir o routeprefix
    // [RoutePrefix("novasrotas")]
    // 4 - renomear o nome do routeprefix
    [RoutePrefix("geral")]
    public class NovasRotasController : Controller
    {
        // GET: NovasRotas
        // 1 - http://localhost:9808/novasrotas?nascimento=11-22-93
        // 2 - declarar os parâmetros
        // http://localhost:9808/novasrotas/index/11-22-93
        // Route("novasrotas/index/{nascimento:datetime}")]
        // 3 - rota com o prefixo
        // 4 - com routeprefix renomeado
        // http://localhost:9808/geral/index/11-22-93
        [Route("index/{nascimento:datetime}")]
        public string Index(DateTime nascimento)
        {
            return string.Format("Data de nascimento: {0:dd/MM/yyyy}", nascimento );
        }

        // 1 - http://localhost:9808/novasrotas/getdados?nome=jean&idade=58
        // 2 - declarar os parâmetros
        // http://localhost:9808/novasrotas/getdados/jean/29
        // [Route("novasrotas/getdados/{nome}/{idade}")]
        // 3 - rota com o prefixo
        // 4 - com routeprefix renomeado
        // http://localhost:9808/geral/getdados/jean/29
        // [Route("getdados/{nome}/{idade}")] // ou [Route("{nome}/{idade}/getdados")]
        // 5 - renomear o método
        // http://localhost:9808/geral/info/jean/29
        [Route("info/{nome}/{idade}")]
        public string GetDados(string nome, int idade = 20)
        {
            return HttpUtility.HtmlAttributeEncode(string.Format("Bem vindo {0}, com idade {1}", nome, idade));
        }

        // 1 - http://localhost:9808/novasrotas/getpreco?preco=13
        // 2 - declarar os parâmetros
        // http://localhost:9808/novasrotas/getpreco/13
        // [Route("novasrotas/getpreco/{preco}")]
        // 3 - rota com o prefixo
        // 4 - com routeprefix renomeado
        // http://localhost:9808/geral/getpreco/13
        // [Route("getpreco/{preco}")]
        // 5 - renomear o método e atribuir um valor mínimo
        // http://localhost:9808/geral/cotacao/21
        [Route("cotacao/{preco:int:min(20)}")]
        public string GetPreco(int preco) {
            return "Preço do produto é: " + preco; 
        }

        // 1 - http://localhost:9808/novasrotas/getcliente?id=5
        // 2 - declarar os parâmetros
        // http://localhost:9808/novasrotas/getcliente/5
        // [Route("novasrotas/getcliente/{id}")]
        // 3 - rota com o prefixo
        // 4 - com routeprefix renomeado
        // http://localhost:9808/geral/getcliente/5
        // [Route("getcliente/{id}")]
        // 5 - renomear o método e atribuir um valor mínimo
        // http://localhost:9808/geral/cliente/21
        [Route("cotacao/{preco:int:min(5):max(99)}")]
        public string GetCliente(int id)
        {
            return "Código do cliente: " + id;
        }

    }
}