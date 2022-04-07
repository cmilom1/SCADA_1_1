using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SCADA_1_1.Data
{
    class DB_Connection
    {
        static private string ConnectionString = "SERVER=TBOGL011\\SCSOLDINTEG;DATABASE=DB_SCADA_1_0; Integrated security=true";
        private SqlConnection Conn = new SqlConnection(ConnectionString);

        public SqlConnection ConnectionDB()
        {

            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            return Conn;
        }

        public SqlConnection CloseConnectionDB()
        {
            if (Conn.State == ConnectionState.Open)
                Conn.Close();
            return Conn;
        }

    }
}
