﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(0.1 + 0.2 == 0.3);    // 浮點數用於比較容易出問題
            Console.WriteLine(1.2 + 1.3 == 2.5);
        }
    }
}