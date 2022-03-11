using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CRUDado
{
    public class CConexion
    {
        private string conn;
        public string strinCon(string nomBD)
        {
            conn = ConfigurationManager.ConnectionStrings[nomBD].
                ConnectionString;
            return conn;
        }
    }
}
