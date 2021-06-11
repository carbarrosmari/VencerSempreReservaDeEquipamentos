using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VencerSempre.Classes
{
    class Conn
    {
        public static string server = @"DESKTOP-9UVP2V8\SQLEXPRESS";
        public static string dataBase = "BDVSempre";
        public static string user = "admin";
        public static string password = "admin";

        public static string StrCon
        {
            get { return $" Integrated Security=True; Password= {password}; User ID={ user}; Initial Catalog={ dataBase}; Data Source={ server}"; }
        }
    }
}