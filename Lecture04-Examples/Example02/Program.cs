using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal enum Status1
    { Success, Error }

    internal enum Status2
    { Success = 403, Error }

    internal enum Status3
    { Success = 403, Error = 405, Doknow }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Status1 httpResponse1 = Status1.Error;
            Console.WriteLine(httpResponse1);
            Console.WriteLine((int)httpResponse1);

            Status2 httpResponse2 = Status2.Success;
            Console.WriteLine(httpResponse2);
            Console.WriteLine((int)httpResponse2);

            Status3 httpResponse3 = Status3.Doknow;
            Console.WriteLine(httpResponse3);
            Console.WriteLine((int)httpResponse3);
        }
    }
}