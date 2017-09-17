using Mini.Classes;
using System.IO;

namespace Mini.WCF
{
    public class Service1 : IServiceMini
    {
        public void Executar(string origem, string destino)
        {
            var caminho = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;
            Minificador.Executar(new string[] {
                "/o=" + Path.Combine(caminho, origem),
                "/d=" + Path.Combine(caminho, destino)
            });
        }
    }
}
