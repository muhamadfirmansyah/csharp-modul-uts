using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

//Copyright UTS GENAP 2018 by Muhamad Firmansyah | RPL X-2
namespace Allhamdulillah_UTS_Genap_Firmansyah
{
    class koneksi
    {
        private static string conn;

        static koneksi()
        {
            string strConn="Data Source=localhost; Database=aplikasiku; User Id=root;";
            conn = strConn;
        }
        public static MySqlConnection Conn
        {
        get
            {
        return new MySqlConnection(conn);
            }
        }
    }
}