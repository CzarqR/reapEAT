using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace reapEAT
{
    static class StringCorrect
    {
        /// <summary>
        /// Checking if all characters in string all between giving ranges in ASCII
        /// </summary>
        /// <param name="x">String to chech</param>
        /// <param name="list">ASCII index of pairs witch contains ranges</param>
        /// <returns></returns>
        public static bool CheckCorrect(string x, params int[] list)
        {
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < list.Length - 1; j += 2)
                {
                    if (x[i] > list[j] && x[i] < list[j + 1])
                        break;
                    if (j == list.Length - 2)
                        return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Return file name from given localization eg. C::User\\Images\\picture.jpg return picture.jpg
        /// </summary>
        /// <param name="x">File localization</param>
        /// <returns>File name</returns>
        public static string GetName(string x)
        {
            int i = x.Length - 1;
            while (x[i] != '\\') { i--; }
            return x.Substring(i + 1);
        }

        public static string BuildString(params string[] list)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string item in list)
            {
                stringBuilder.Append(item);
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// from string in format "dd.mm.yyyy" get DateTime
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static DateTime GetDateTimeFromString(string x)
        {
            return new DateTime(int.Parse(x.Substring(6)), int.Parse(x.Substring(3, 2)), int.Parse(x.Substring(0, 2)));
        }

        public static string LoadFoodFromFridge(int id)
        {
            StringBuilder food = new StringBuilder(" ");
            using (SqlConnection sqlConnection = new SqlConnection(X.ConnectionString("DB")))
            {
                string Q = "SELECT IdFood FROM [" + id + "_fridge] ORDER BY IdFood";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Q, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    food.Append(row.Field<int>("IdFood").ToString());
                    food.Append(" ");
                }
            }
            return food.ToString();
        }

        public static bool CheckIngredients(string r, string f)
        {
            int start = 0, stop;

            for (int i = 0; i < 10000; i++)
            {
                while (start < r.Length - 1)
                {

                    stop = (r.IndexOf(" ", start + 1));
                    if (f.IndexOf(r.Substring(start, stop - start)) == -1)
                        return false;
                        start = stop;

                }
            }
            return true;
        }

        



    }

}


