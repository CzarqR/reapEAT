using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace reapEAT
{
    static class LoadDB
    {
        /// <summary>
        /// Return dictionary based on data base
        /// </summary>
        /// <param name="db">Data base name</param>
        /// <param name="idColumn">Name with id column</param>
        /// <param name="columnName">Column name value</param>
        /// <returns></returns>
        public static Dictionary<Byte, string> LoadDBId(string db, string idColumn, string columnName)
        {
            Dictionary<Byte, string> dictionary = new Dictionary<Byte, string>();
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                string query = "SELECT  * FROM " + db;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    dictionary.Add(row.Field<Byte>(idColumn), row.Field<string>(columnName).ToString());
                }
            }
            return dictionary;
        }
    }
}
