using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastro.DataAccess;

namespace Cadastro
{
    public partial class frmCadastroCliente : Form
    {
        List<Cliente> ListaClientes = new List<Cliente>();
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HabilitaOuDesabilitaCampos(true);

            LimpaTela();

            btnSalvar.Enabled = true;

            txtCodigo.Focus();
        }

        private void HabilitaOuDesabilitaCampos(bool pNovoStatus)
        {
            txtBairro.Enabled = pNovoStatus;
            txtCidade.Enabled = pNovoStatus;
            txtCodigo.Enabled = pNovoStatus;
            txtCPF.Enabled = pNovoStatus;
            txtLogradouro.Enabled = pNovoStatus;
            txtNome.Enabled = pNovoStatus;
            chbAtivo.Enabled = pNovoStatus;
            dtpNascimento.Enabled = pNovoStatus;
            cmbUF.Enabled = pNovoStatus;
        }

        private void LimpaTela()
        {
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtCodigo.Text = "";
            txtCPF.Text = "";
            txtLogradouro.Text = "";
            txtNome.Text = "";
            chbAtivo.Checked = true;
            dtpNascimento.Value = DateTime.Now;
            cmbUF.SelectedIndex = -1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNome.Text != "" && txtCPF.Text != "")
            {
                //Cria um novo objeto da classe Cliente
                Cliente NovoCliente = new Cliente();

                //Preenche os atributos deste objeto com os dados do formulário
                NovoCliente.Ativo = chbAtivo.Checked;
                NovoCliente.Bairro = txtBairro.Text;
                NovoCliente.Cidade = txtCidade.Text;
                NovoCliente.Codigo = Convert.ToInt32(txtCodigo.Text);
                NovoCliente.CPF = txtCPF.Text;
                NovoCliente.Nascimento = dtpNascimento.Value;
                NovoCliente.Logradouro = txtLogradouro.Text;
                NovoCliente.Nome = txtNome.Text;
                NovoCliente.UF = cmbUF.Text;

                //Inserir este novo objeto na tabela Cliente
                if(!ClienteDataAccess.Insere(NovoCliente))
                    MessageBox.Show("Falha ao tentar inserir o novo cliente no banco de dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Cliente inserido com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //Atualiza o DataGrid em relação à nova lista de clientes
                dtgClientes.DataSource = null;
                dtgClientes.DataSource = ListaClientes;
                dtgClientes.Refresh();

                //Volta os campos para o estado original
                LimpaTela();
                HabilitaOuDesabilitaCampos(false);

            }
            else
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            dtgClientes.DataSource = ClienteDataAccess.Insere(); 

        }
    }
}
