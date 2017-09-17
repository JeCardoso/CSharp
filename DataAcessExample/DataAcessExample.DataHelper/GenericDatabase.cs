using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;


namespace DataAcessExample.DataHelper
{
    public class GenericDatabase
    {
        public static DbCommand CreateCommand(string cmdText, CommandType cmmType, List<DbParameter> listParameter)
        {
            var factory = DbProviderFactories.GetFactory(ConnectionDB.ProviderName);

            var conn = factory.CreateConnection();

            conn.ConnectionString = ConnectionDB.ConnectionString;

            var comm = conn.CreateCommand();

            comm.CommandText = cmdText;

            comm.CommandType = cmmType;

            if (listParameter != null)
            {
                foreach (var param in listParameter)
                {
                    comm.Parameters.Add(param);
                }
            }

            return comm;

            return null;
        }

        public static DbParameter CreateParameter(string nameParameter, DbType typeParameter, Object valueParameter)
        {

            var factory = DbProviderFactories.GetFactory(ConnectionDB.ProviderName);

            var param = factory.CreateParameter();

            if (param != null)
            {
                param.ParameterName = nameParameter;
                param.DbType = typeParameter;
                param.Value = valueParameter;
            }

            return param;
        }

        public static Object ExecuteCommand(string cmdText, CommandType cmdType, List<DbParameter> listParameter, TypeCommand typeCmd)
        {
            var command = CreateCommand(cmdText, cmdType, listParameter);
            Object objRetorno = null;

            try
            {
                command.Connection.Open();
                switch (typeCmd)
                {
                    case TypeCommand.ExecuteNonQuery:
                        objRetorno = command.ExecuteNonQuery();
                        break;

                    case TypeCommand.ExecuteReader:
                        objRetorno = command.ExecuteReader();
                        break;

                    case TypeCommand.ExecuteScalar:
                        objRetorno = command.ExecuteScalar();
                        break;

                    case TypeCommand.ExecuteDataTable:
                        var table = new DataTable();
                        var reader = command.ExecuteReader();
                        table.Load(reader);
                        reader.Close();
                        objRetorno = table;
                        break;
                }

            }
            catch (Exception)
            {
                throw new Exception("Erro ao executar o ExecuteCommando");
            }
            finally
            {
                if (typeCmd != TypeCommand.ExecuteReader)
                {   
                    if(command.Connection.State == ConnectionState.Open) { 
                        command.Connection.Close();
                    }
                    command.Connection.Dispose();
                }
            }

            return objRetorno;
        }   

        public enum TypeCommand
        {
            ExecuteNonQuery,
            ExecuteReader,
            ExecuteScalar,
            ExecuteDataTable
        }
    }
}
