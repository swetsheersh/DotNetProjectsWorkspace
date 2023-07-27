using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlLink
{
    internal class Employ
    {
        public int empid { get; set; }
        public string name { get; set; }
        public string designation { get; set; }
        public string department { get; set; }
        public int basic { get; set; }

        public Employ(int empid,string name,string designation,string department,int basic) 
        {
            this.empid = empid;
            this.name = name;
            this.designation = designation;
            this.department = department;
            this.basic = basic;
        }

        public override string ToString()
        {
            return "empid :" + empid + " name :" + name + " designation : " + designation + " department : " + department + " basic : " + basic;
        }
    }
}
