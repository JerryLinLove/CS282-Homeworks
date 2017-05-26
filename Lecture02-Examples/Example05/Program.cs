using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "Jerry",
                Birthday = "1019",
                Email = "asdf123@ms4.url.com.tw",
                Orientation = 0.0,
                Pos = Position.Generate();
            };

            Console.Write("請輸入要畫的方型邊長:");
            double width = 0.0;
            bool success = double.TryParse
                (Console.ReadLine(), out width);
            if (success)
                person.DrawSquare(width);
            else
                Console.WriteLine("輸入錯誤，請重新執行!!");


        }
    }
}
