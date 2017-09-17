using Mini.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mini.WebForms
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtExecutar_Click(object sender, EventArgs e)
        {
            Minificador.Executar(new string[] {
                "/o=" + Path.Combine(Server.MapPath("~"), txtOrigem.Text),
                "/d=" + Path.Combine(Server.MapPath("~"), txtDestino.Text) });
        }
    }
}