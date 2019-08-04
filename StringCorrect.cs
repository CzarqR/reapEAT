using System;
using System.Collections.Generic;
using System.Linq;
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

        
    }

}


