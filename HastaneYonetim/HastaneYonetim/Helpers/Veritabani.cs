using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYonetim.Helpers
{
    public static class Veritabani
    {
        public static SqlConnection Baglanti()
        {
            string connectionString = "server=localhost; database=hastane_yonetim; trusted_connection=true; trustservercertificate=true;";
            return new SqlConnection(connectionString);
        }
    }
}
