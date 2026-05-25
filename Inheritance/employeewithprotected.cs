using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class EmployeeSalary
    {
        protected double sal;
            public EmployeeSalary(double sal)
        {
            this.sal = sal;
        }
        public void employeedisplay()
        {
            Console.WriteLine("Employee Salary: " + sal);
        }
    }
    class hikesalary:EmployeeSalary
    {
        float hike;
        public hikesalary(float hike, double esal):base(esal)
        {
            this.hike = hike;
            
        }
        public void hikemeth()
        {
            hike = hike / 100;
            base.employeedisplay();
            sal = sal + (sal * hike);
            
            Console.WriteLine("Employee Salary with Hike:" + sal);
        }
    }
    internal class employeewithprotected
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Salary :");
            double esal=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Hike Percentage:");
            int p = int.Parse(Console.ReadLine());
            hikesalary h = new hikesalary(p, esal);
            h.hikemeth();
        }
    }
}
