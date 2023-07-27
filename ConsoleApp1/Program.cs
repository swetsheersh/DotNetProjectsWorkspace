using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("integrated security=true;data source=(localdb)\\MSSQLLocalDB;initial catalog=sqlpractice2");
            SqlDataAdapter ad = new SqlDataAdapter("select * from Employ5",conn);
            DataSet ds = new DataSet();
            ad.Fill(ds,"Employ"); 
            foreach (DataRow dr in ds.Tables["Employ"].Rows) 
            {
                Console.WriteLine("Employ Id " + dr["empid"]);
                Console.WriteLine("Employ name " + dr["name"]);
                Console.WriteLine("Employ department " + dr["department"]);
                Console.WriteLine("Employ designation " + dr["designation"]);
                Console.WriteLine("Employ basic " + dr["basic"]);
                Console.WriteLine("-----------------------------------");
            }
            /* conn.Open();*/
            Console.WriteLine("Enter Emp. Id : ");
            int empid=Convert.ToInt32(Console.ReadLine());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Employ5 where empid=@empid",conn);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@empid", empid);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "Emp");
            int count = dataSet.Tables["Emp"].Rows.Count;
            if(count == 1)
            {
                Console.WriteLine("Employ Id " + dataSet.Tables["Emp"].Rows[0]["empid"]);
                Console.WriteLine("Employ name " + dataSet.Tables["Emp"].Rows[0]["name"]);
                Console.WriteLine("Employ department " + dataSet.Tables["Emp"].Rows[0]["department"]);
                Console.WriteLine("Employ designation " + dataSet.Tables["Emp"].Rows[0]["designation"]);
                Console.WriteLine("Employ basic " + dataSet.Tables["Emp"].Rows[0]["basic"]);
                Console.WriteLine("-----------------------------------");
            }
            else
            {
                Console.WriteLine("***********Record Not Found**************");
            }

        }
    }
}
