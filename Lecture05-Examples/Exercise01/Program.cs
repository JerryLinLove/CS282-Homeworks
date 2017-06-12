using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpolyeeLibrary;

namespace Exercise01
{
    internal class Program
    {
        //       private static Empolyee empolyee = new Empolyee();

        private static void Main(string[] args)
        {
            Empolyee empolyee = new Empolyee();
            Console.Write("請輸入員工姓名: ");
            empolyee.Name = Console.ReadLine();
            Console.Write("請輸入底薪: ");
            empolyee.BaseSalary = double.Parse(Console.ReadLine());
            Console.Write("請輸入獎金: ");
            empolyee.Benefit = double.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------");
            Console.WriteLine("{0}的薪水為 : {1}", empolyee.Name, empolyee.Salary);
            Console.WriteLine("-----------------------");
        }
    }
}