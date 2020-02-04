using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AutoresEditorialesDB
{
    public class Repositorio
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.connectionString["autores"]);
    }
}
