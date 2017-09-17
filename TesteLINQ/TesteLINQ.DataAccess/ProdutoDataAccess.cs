using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLINQ.DataAccess
{
    public class ProdutoDataAccess
    {
        public static bool Insere(Produto prod)
        {
            try
            {
                TesteLINQDataClassesDataContext oDB = new TesteLINQDataClassesDataContext();

                oDB.Produtos.InsertOnSubmit(prod);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception) {
                return false;
            }
        }

        public static bool Insere(List<Produto> prods)
        {
            try
            {
                TesteLINQDataClassesDataContext oDB = new TesteLINQDataClassesDataContext();

                oDB.Produtos.InsertAllOnSubmit(prods);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Deleta(Produto prod)
        {
            try
            {
                TesteLINQDataClassesDataContext oDB = new TesteLINQDataClassesDataContext();

                oDB.Produtos.DeleteOnSubmit(prod);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Deleta(List<Produto> prods)
        {
            try
            {
                TesteLINQDataClassesDataContext oDB = new TesteLINQDataClassesDataContext();

                oDB.Produtos.DeleteAllOnSubmit(prods);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Deleta(int codBarras)
        {
            try
            {
                TesteLINQDataClassesDataContext oDB = new TesteLINQDataClassesDataContext();

                Produto ProdSelecionado = (from selecionado in oDB.Produtos where selecionado.codigoBarras == codBarras select selecionado).SingleOrDefault();

                oDB.Produtos.DeleteOnSubmit(ProdSelecionado);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Produto Obter(int codBarras)
        {
            try
            {
                TesteLINQDataClassesDataContext oDB = new TesteLINQDataClassesDataContext();

                Produto ProdSelecionado = (from selecionado in oDB.Produtos where selecionado.codigoBarras == codBarras select selecionado).SingleOrDefault();
                return ProdSelecionado;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<Produto> Obter()
        {
            try
            {
                TesteLINQDataClassesDataContext oDB = new TesteLINQDataClassesDataContext();

                List<Produto> ProdSelecionado = (from selecionado in oDB.Produtos orderby selecionado.nome descending select selecionado).ToList<Produto>();
                return ProdSelecionado;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool Atualiza(Produto prod)
        {
            try
            {
                TesteLINQDataClassesDataContext oDB = new TesteLINQDataClassesDataContext();

                Produto ProdSelecionado = (from selecionado in oDB.Produtos where selecionado.codigoBarras == prod.codigoBarras orderby selecionado.nome descending select selecionado).SingleOrDefault();

                ProdSelecionado.nome = prod.nome;
                ProdSelecionado.fabricante = prod.fabricante;
                ProdSelecionado.categoria = prod.categoria;
                ProdSelecionado.valor = prod.valor;
                ProdSelecionado.peso = prod.peso;
                ProdSelecionado.quantidade = prod.quantidade;

                oDB.SubmitChanges();
                oDB.Dispose();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
