using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace reapEAT
{
    static class FindIngridient
    {
        public static bool LookFor(int idRecipe, int idFood)
        {
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                SqlCommand sqlCommand = new SqlCommand("Select Count(IdFood) From [" + idRecipe + "_recipe] WHERE IdFood = " + idFood, sqlConnection)
                {
                    CommandType = CommandType.Text
                };
                sqlConnection.Open();
                bool find = (int)sqlCommand.ExecuteScalar() == 1 ? true : false;
                sqlConnection.Close();
                return find;
            }
        }
        public static bool LookForString(string ingridients, Dictionary<int, string> idFood)
        {
            foreach (var x in idFood)
            {
                if (ingridients.IndexOf(" " + x.Key + " ") == -1)
                    return false;
            }
            return true;
        }

    }
}
