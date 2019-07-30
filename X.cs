using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace reapEAT
{
    /// <summary>
    /// Class which holds all imptrtant data
    /// </summary>
    class X
    {
        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        public static string ImageFolder()
        {
            return ConfigurationManager.AppSettings["ImageFolder"];
        }

        // set one to test mode, change after finish !!!!!!!!!!!!!
        public static int IdUser = 1;

        

    }


}

