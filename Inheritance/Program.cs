using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Branch
    {
        int bid;
        string bname;
        string baddress;
        public Branch(int bid, string bname, string baddress)
        {
            this.bid = bid;
            this.bname = bname;
            this.baddress = baddress;
        }
        public void BranchDisplay()
        {
            Console.WriteLine("Branch ID: " + bid);
            Console.WriteLine("Branch Name: " + bname);
            Console.WriteLine("Branch Address: " + baddress);
        }
    }
    class student:Branch
    {
        int sid;
        string sname;
        string sclg;
        public student(int sid,string sname,string sclg):base(101,"AAA","Ameerpet")
        {
            this.sid = sid;
            this.sname = sname;
            this.sclg = sclg;
        }
        public void studentDisplay()
        {
            Console.WriteLine("Student ID: " + sid);
            Console.WriteLine("Student Name: " + sname);
            Console.WriteLine("Student College: " + sclg+"\n");

            base.BranchDisplay();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student(1, "Ram", "IIIT");
            s.studentDisplay();
        }
    }
}
