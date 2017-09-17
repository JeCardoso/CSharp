using System;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace Projeto.Repository
{
    public class Conexao
    {
        protected SqlConnection Con;

        protected SqlCommand Cmd;

        protected SqlDataReader Dr;

        //Método para abrir a conexão com o SqlServer:
        protected void AbrirConexao()
        {
            try
            {
                Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jean\Desktop\crud-mvc5-adonet-code4coders-master\Proj_CRUD_ADONET\Projeto\App_Data\ProjetoCrud.mdf;Integrated Security=True");
                //Con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ProjetoCRUD"].ConnectionString);
                Con.Open();
            }
            catch (Exception e)
            {   
                // Caso dê algum problema, enviar uma mensagem informando o erro:
                throw new Exception("Erro ao abrir a conexão: " + e.Message);
            }
        }

        //Método para fechar a conexão:
        protected void FecharConexao()
        {
            try
            {
                if (Con != null)
                {
                    Con.Close();
                }
            }
            catch (Exception e)
            {
                // Caso dê algum problema, enviar uma mensagem informando o erro:
                throw new Exception("Erro ao fechar a conexão: " + e.Message);
            }
        }
    }
}