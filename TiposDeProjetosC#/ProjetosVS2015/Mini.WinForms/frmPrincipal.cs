using Mini.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini.WinForms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            Minificador.Executar(new string[] { "/o=" + txtOrigem.Text, "/d=" + txtDestino.Text });
        }
    }
}
