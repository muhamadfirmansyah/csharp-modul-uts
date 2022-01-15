using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

//Copyright UTS GENAP 2018 by Muhamad Firmansyah | RPL X-2  
namespace Allhamdulillah_UTS_Genap_Firmansyah
{
    class fungsi
    {
        static int status;

        static MySqlDataAdapter sdaUser;
        static MySqlConnection conn;
        public static int EQuery(string query)
        {
            status = 0;
            conn = koneksi.Conn;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = query;

                status = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                return status;
            }
            finally
            {
                conn.Close();
            }

            return status;
        }

        public Boolean statusLogin(string user, string password)
        {

            user = user.ToUpper();
            password = password.ToUpper();

            conn = koneksi.Conn;
            MySqlCommand command = conn.CreateCommand();

            conn.Open();
            string sql = "select username, password from login";
            command.CommandText = sql;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if ((reader.GetString(0).ToString().ToUpper() == user) && (reader.GetString(1).ToString().ToUpper() == password))
                {
                    return true;
                }
            }
            conn.Close();
            return false;
        }
    }
}