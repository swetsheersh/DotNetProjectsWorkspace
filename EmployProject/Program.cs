using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployProject
{
    class Demo
    {
        public StringBuilder Validate(Employ emp)
        {
                StringBuilder str = new StringBuilder();
                bool flag = true;
                if (emp.employId < 1) 
                {
                    str.Append("Invalid EmployId!! Must be greater than 1\n");
                    flag = false;
                }
                if (emp.name.Length < 5)
                {
                    str.Append("Name Must be Min. 5 char.\n");
                    flag = false;
                }
                if(!emp.department.Equals("Angular") || !emp.department.Equals("Dotnet"))
                {
                    str.Append("Department can either be Angular or Dotnet\n");
                    flag = false;
                
                }
                if (flag)
                {
                    str.Append("All validations are passed\n");
                }
                return str;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employ employ = new Employ();
            Console.WriteLine("Enter EmployId");
            employ.employId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            employ.name=Console.ReadLine();
            Console.WriteLine("Enter Department");
            employ.department = Console.ReadLine();
            Console.WriteLine("Enter Designation");
            employ.designation = Console.ReadLine();
            Console.WriteLine("Enter Basic");
            try
            {
                employ.basic = Convert.ToInt32(Console.ReadLine());
            }catch(Exception e)
            {
                Console.WriteLine("Invalid Basic");
            }
            
            Demo obj=new Demo();
            Console.WriteLine(obj.Validate(employ));

            SqlConnection con=null;

            try
            {
                con = new SqlConnection("integrated security=true;data source=MSSQLLocalDB;initial catalog=sqlpractice2");
                con.Open();
                Console.WriteLine("connected");
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            finally { 
                if( con != null)
                {
                    con.Close();
                }
            }

        }
    }
}
