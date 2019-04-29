using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DungeonCrawler.Class_For_SQL
{
    public static class Connection
    {

        //public static SqlConnection GetLogInConnection()
        //{
        //    string cn_String = Properties.Settings.Default.connection_String;
        //    SqlConnection connection = new SqlConnection(cn_String);
        //    if (connection.State == ConnectionState.Closed)
        //    {
        //        connection.Open();
        //    }
        //    return connection;
        //}

        //public static DataTable Get_Table (string query)
        //{
        //    //Connection
        //    SqlConnection connection = GetLogInConnection();

        //    //Table
        //    DataTable table = new DataTable();
        //    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
        //    adapter.Fill(table);

        //    return table;

        //}

    }
}
