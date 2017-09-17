using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLINQ.DataAccess
{
    public class CategoriaDataAccess
    {
        public static bool Insere(Categoria cat)
        {
            try
            {
                TesteLINQDataClassesDataContext oDB = new TesteLINQDataClassesDataContext();

                oDB.Categorias.InsertOnSubmit(cat);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Insere(List<Categoria> cat)
        {
            try
            {
                TesteLINQDataClassesDataContext oDB = new TesteLINQDataClassesDataContext();

                oDB.Categorias.InsertAllOnSubmit(cat);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Deleta(Categoria cat)
        {
            try
            {
                TesteLINQDataClassesDataContext oDB = new TesteLINQDataClassesDataContext();

                oDB.Categorias.DeleteOnSubmit(cat);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Deleta(List<Categoria> cat)
        {
            try
            {
                TesteLINQDataClassesDataContext oDB = new TesteLINQDataClassesDataContext();

                oDB.Categorias.DeleteAllOnSubmit(cat);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Deleta(int id)
        {
            try
            {
                TesteLINQDataClassesDataContext oDB = new TesteLINQDataClassesDataContext();

                Categoria CatSelecionado = (from selecionado in oDB.Categorias where selecionado.id_categoria == id select selecionado).SingleOrDefault();

                oDB.Categorias.DeleteOnSubmit(CatSelecionado);
                oDB.SubmitChanges();
                oDB.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Categoria Obter(int id)
        {
            try
            {
                TesteLINQDataClassesDataContext oDB = new TesteLINQDataClassesDataContext();

                Categoria CatSelecionado = (from selecionado in oDB.Categorias where selecionado.id_categoria == id select selecionado).SingleOrDefault();
                return CatSelecionado;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<Categoria> Obter()
        {
            try
            {
                TesteLINQDataClassesDataContext oDB = new TesteLINQDataClassesDataContext();

                List<Categoria> CatSelecionado = (from selecionado in oDB.Categorias orderby selecionado.id_categoria descending select selecionado).ToList<Categoria>();
                return CatSelecionado;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool Atualiza(Categoria cat)
        {
            try
            {
                TesteLINQDataClassesDataContext oDB = new TesteLINQDataClassesDataContext();

                Categoria CatSelecionado = (from selecionado in oDB.Categorias where selecionado.id_categoria == cat.id_categoria orderby selecionado.id_categoria descending select selecionado).SingleOrDefault();

                CatSelecionado.categoria1 = cat.categoria1;

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
