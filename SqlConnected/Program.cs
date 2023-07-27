using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SqlConnected
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            SqlCommand cmd = new SqlCommand("prcEmpShow",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read()) 
            {
                Console.WriteLine("Employ id: " + reader["empid"]);
                Console.WriteLine("Employ name: " + reader["name"]);
                Console.WriteLine("Employ department: " + reader["department"]);
                Console.WriteLine("Employ designation: " + reader["designation"]);
                Console.WriteLine("Employ basic: " + reader["basic"]);
            }
        }
    }
}
