using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Threading.Tasks;

namespace Cadastro.DataAccess
{
    public partial class ClienteDataAccess : Cliente
    {
        public static bool Insere(Cliente pCliente)
        {
            try
            {
                CadastroDataClassesDataContext oDB = new CadastroDataClassesDataContext();
                oDB.Clientes.InsertOnSubmit(pCliente);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Insere(List<Cliente> pClientes)
        {
            try
            {
                CadastroDataClassesDataContext oDB = new CadastroDataClassesDataContext();
                oDB.Clientes.InsertAllOnSubmit(pClientes);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Delete(Cliente pCliente)
        {
            try
            {
                CadastroDataClassesDataContext oDB = new CadastroDataClassesDataContext();
                oDB.Clientes.DeleteOnSubmit(pCliente);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Delete(List<Cliente> pClientes)
        {
            try
            {
                CadastroDataClassesDataContext oDB = new CadastroDataClassesDataContext();
                oDB.Clientes.DeleteAllOnSubmit(pClientes);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Delete(int pCodigoCliente)
        {
            try
            {
                CadastroDataClassesDataContext oDB = new CadastroDataClassesDataContext();
                Cliente oCliente = (from Selecao in oDB.Clientes where Selecao.Codigo == pCodigoCliente select Selecao).SingleOrDefault();

                oDB.Clientes.DeleteOnSubmit(oCliente);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Atualiza(Cliente pCliente)
        {
            try
            {
                CadastroDataClassesDataContext oDB = new CadastroDataClassesDataContext();
                Cliente oCliente = (from Selecao in oDB.Clientes where Selecao.Codigo == pCliente.Codigo select Selecao).SingleOrDefault();

                oCliente.Ativo = pCliente.Ativo;
                oCliente.Bairro = pCliente.Bairro;
                oCliente.Cidade = pCliente.Cidade;
                oCliente.CPF = pCliente.CPF;
                oCliente.Logradouro = pCliente.Logradouro;
                oCliente.Nascimento = pCliente.Nascimento;
                oCliente.Nome = pCliente.Nome;
                oCliente.UF = pCliente.UF;

                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Cliente ObterCliente(int pCodigoCliente)
        {
            CadastroDataClassesDataContext oDB = new CadastroDataClassesDataContext();
            Cliente oCliente = (from Selecao in oDB.Clientes where Selecao.Codigo == pCodigoCliente select Selecao).SingleOrDefault();
            return oCliente;
        }

        public static List<Cliente> ObterClientes()
        {
            CadastroDataClassesDataContext oDB = new CadastroDataClassesDataContext();
            List<Cliente> oClientes = (from Selecao in oDB.Clientes orderby Selecao.Nome descending select Selecao).ToList<Cliente>();
            return oClientes;
        }
    }
}
