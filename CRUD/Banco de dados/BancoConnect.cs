using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD.Banco_de_dados
{
    public class BancoConnect
    {
        public const string host = "localhost";
        public const string name = "root";
        public const string pass = "";
        public const string db_name = "funcionarios";

        static public string conexaobanco = $"Server={host}; uid={name}; Database={db_name}; pwd={pass}";
        
        
    }
}
