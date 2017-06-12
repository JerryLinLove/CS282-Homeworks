using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RandomGenerator random = new RandomGenerator();
            Console.WriteLine(random.NextDouble(3.12, 3.12));
            Console.WriteLine(random.NextDouble());
        }
    }
}