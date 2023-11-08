using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            string Name= Console.ReadLine();
            Console.WriteLine("Enter Employee Gender:");
            char Gender=char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee salary:");
            float salary=float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Doj:");
            DateTime doj=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Employee Id");
            Console.WriteLine(id);
            Console.WriteLine("Employee Name");
            Console.WriteLine(Name);
            Console.WriteLine("Employee Gender");
            Console.WriteLine(Gender);
            Console.WriteLine("Employee Salary:");
            Console.WriteLine(salary);
            Console.WriteLine("Employee Joined on");
            Console.WriteLine(doj);
            Console.WriteLine("Employee has to this tax");
            double taxRate;
            if (salary > 90000)
            {
                taxRate = 0.30; // 30% tax rate for salary > 90K
            }
            else
            {
                taxRate = 0.15; // 15% tax rate for salary <= 90K
            }
            double taxAmount = salary * taxRate;
            Console.WriteLine("Tax to be paid: {taxAmount:C}");
            Console.ReadKey();
        }
    }
}
