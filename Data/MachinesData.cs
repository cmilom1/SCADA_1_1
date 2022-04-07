using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SCADA_1_1.Data
{
    internal class MachinesData
    {
        private DB_Connection Conn = new DB_Connection();
        private SqlCommand Command = new SqlCommand();
        private SqlDataReader ReadRows;

        public DataTable ListMachines()
        {

            DataTable Table = new DataTable();
            Command.Connection = Conn.ConnectionDB();
            Command.CommandText = "LIST_MACHINES";
            Command.CommandType = CommandType.StoredProcedure;
            ReadRows = Command.ExecuteReader();
            Table.Load(ReadRows);
            ReadRows.Close();
            Conn.CloseConnectionDB();
            return Table;
            ;
        }

        public DataTable ListOperationalData()
        {

            DataTable Table = new DataTable();
            Command.Connection = Conn.ConnectionDB();
            Command.CommandText = "LIST_OPERATIONAL_DATA";
            Command.CommandType = CommandType.StoredProcedure;
            ReadRows = Command.ExecuteReader();
            Table.Load(ReadRows);
            ReadRows.Close();
            Conn.CloseConnectionDB();
            return Table;
            ;
        }
    }
}
