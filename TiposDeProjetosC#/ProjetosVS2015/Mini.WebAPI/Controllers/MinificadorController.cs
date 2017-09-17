using Mini.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mini.WebAPI.Controllers
{
    public class MinificadorController : ApiController
    {
        // GET api/
        public IEnumerable<string> Get()
        {
            return new string[] { "origem.html", "destino.html" };
        }

        // GET api/id
        public HttpResponseMessage Get(int id)
        {
            var lista = new string[] { "origem.html", "destino.html" };
            if (lista.Count() > id)
            {
                return Request.CreateResponse(HttpStatusCode.OK, lista[id]);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        //// POST api/value
        //public void Post([FromBody]string value)
        //{
        //}

        [HttpPost]
        public HttpResponseMessage Executar([FromBody]ArquivoModel arquivo)
        {
            var caminho = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;

            Minificador.Executar(new string[] {
                "/o=" + Path.Combine(caminho, arquivo.Origem),
                "/d=" + Path.Combine(caminho, arquivo.Destino)
            });

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
