using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpolyeeLibrary
{
    public class Empolyee
    {
        private string name;
        private double baseSalary;
        private double benefit;
        private double salary;

        public string Name { get => name; set => name = value; }

        public double BaseSalary
        {
            get => baseSalary;
            set
            {
                if (value < 18000)
                {
                    baseSalary = 18000;
                }
                else
                {
                    baseSalary = value;
                }
            }
        }

        public double Benefit
        {
            get => benefit;
            set
            {
                if (value < 0)
                {
                    benefit = 0;
                }
                else
                {
                    benefit = value;
                }
            }
        }

        public double Salary
        {
            get
            {
                this.salary = this.baseSalary + this.benefit;
                return (this.salary);
            }
        }
    }
}