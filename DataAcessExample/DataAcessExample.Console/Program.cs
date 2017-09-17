using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using DataAcessExample.DataHelper;

namespace DataAcessExample.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertUsuario();

            var dt = new DataTable();

            var cmd = "sp_ListaUsuario";

            dt = (DataTable)GenericDatabase.ExecuteCommand(cmd, CommandType.StoredProcedure, null, GenericDatabase.TypeCommand.ExecuteDataTable);

            foreach (DataRow item in dt.Rows)
            {
                System.Console.WriteLine("O usuaário é o {0} que mora na rua {1}", item["Nome"], item["Endereco"]);
            }

            System.Console.ReadKey();
        }

        static void InsertUsuario()
        {
            var query = String.Format("insert into Usuario values ('{0}','{1}')", "Caio", "Rua Catandoca");

            GenericDatabase.ExecuteCommand(query, CommandType.Text, null, GenericDatabase.TypeCommand.ExecuteNonQuery);
             
        }
    }
}
