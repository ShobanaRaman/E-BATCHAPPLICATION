using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace eBatch.Common
{
    public static class Db
    {

        public static IDbConnection Connection()
        {
            return (IDbConnection)new SqlConnection(ConfigurationManager.ConnectionStrings["eBatchDBConnection"].ConnectionString);
        }

        public static void Save(CommandDefinition cmd)
        {
            Connection().Execute(cmd);
        }

        public static List<T> Fetch<T>(string spName, List<Tuple<string, string>> param = null)
        {
            var dynParam = new DynamicParameters();

            if ((param != null))
            {
                foreach (var p in param)
                {
                    dynParam.Add(p.Item1, p.Item2);
                }
            }
            return (List<T>)Connection().Query<T>(spName, dynParam, commandType: CommandType.StoredProcedure);
        }

        public static List<T> FetchDT<T>(string spName, DynamicParameters param = null)
        {
            return Connection().Query<T>(spName, param, commandType: CommandType.StoredProcedure).ToList();
        }

        public static T FetchSingle<T>(string spName, DynamicParameters param = null)
        {
            return Connection().Query<T>(spName, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public static dynamic Fetch<T, T1>(string spName, DynamicParameters param = null, string internalproperty = null, string splitcolumn = null)
        {
            var res = Connection().Query<T, T1, T>(spName, (obj1, obj2) =>
            {
                var ss = obj1.GetType().GetProperty(internalproperty);
                PropertyInfo propertyInfo = obj1.GetType().GetProperty(internalproperty);
                propertyInfo.SetValue(obj1, obj2, null);
                return obj1;
            }, param, splitOn: splitcolumn, commandType: CommandType.StoredProcedure).ToList();
            return res;
        }

        private static T MapResults<T, T1>(T arg1, T1 arg2)
        {
            //var res = new demora



            var ss = arg1.GetType().GetProperty("userRole");
            PropertyInfo propertyInfo = arg1.GetType().GetProperty("userRole");
            propertyInfo.SetValue(arg1, arg2, null);
            return arg1;
            //return arg1.GetType().GetProperty("userRole")
        }

        public static List<T> Fetch<T>(string spName, DynamicParameters dynParam)
        {
            return (List<T>)Connection().Query<T>(spName, dynParam, commandType: CommandType.StoredProcedure);
        }

    }
}
