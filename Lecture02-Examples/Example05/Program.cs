using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //===================================================//
            // Example
            // 輸入正方型邊長，若此時沒輸入，將造成當機
            //===================================================//
            /*
            Person person = new Person()
            {
                Name = "Jerry",
                Birthday = "1019",
                Email = "asdf123@ms4.url.com.tw",
                Orientation = 0.0,
                //Pos = Position.Generate()
                Pos = new Position()
                {
                    X = 10.0,
                    Y = 20.0
                }
            };
            Console.Write("請輸入正方型邊長: ");
            double width = double.Parse(Console.ReadLine());
            person.DrawSquare(width);
            */

            //===================================================//
            // Example
            // 改用TryParse，先偵測是否有輸入值
            // 就算有錯誤，也會以預設值進行執行
            //===================================================//
            /*
            Person person = new Person()
            {
                Name = "Jerry",
                Birthday = "1019",
                Email = "asdf123@ms4.url.com.tw",
                Orientation = 0.0,
                //Pos = Position.Generate()
                Pos = new Position()
                {
                    X = 10.0,
                    Y = 20.0
                }
            };
            Console.Write("請輸入正方型邊長: ");
            double width = 0.0;
            double.TryParse(Console.ReadLine(), out width);
            person.DrawSquare(width);
            */

            //===================================================//
            // Example
            // 加入bool變數，可以提醒輸入者錯誤輸入
            //===================================================//
            /*
            Person person = new Person()
            {
                Name = "Jerry",
                Birthday = "1019",
                Email = "asdf123@ms4.url.com.tw",
                Orientation = 0.0,
                //Pos = Position.Generate()
                Pos = new Position()
                {
                    X = 10.0,
                    Y = 20.0
                }
            };
            Console.Write("請輸入正方型邊長: ");
            double width = 0.0;
            bool success = double.TryParse(Console.ReadLine(), out width);
            if (success)
            {
               person.DrawSquare(width);
            }
            else
            {
               Console.WriteLine("輸入錯誤，請重新執行!!");
            }
            */

            //===================================================//
            // Example
            // 加入Random Generate變數，更改啟始座標
            //===================================================//
            Person person = new Person()
            {
                Name = "Jerry",
                Birthday = "1019",
                Email = "asdf123@ms4.url.com.tw",
                Orientation = 0.0,
                Pos = Position.Generate()
            };
            Console.Write("請輸入正方型邊長: ");
            double width = 0.0;
            bool success = double.TryParse(Console.ReadLine(), out width);
            if (success)
            {
                person.DrawSquare(width);
            }
            else
            {
                Console.WriteLine("輸入錯誤，請重新執行!!");
            }

            //===================================================//
            // Homework
            // 長方型繪製
            //===================================================//
            /*
            Person person = new Person()
            {
                Name = "Jerry",
                Birthday = "1019",
                Email = "asdf123@ms4.url.com.tw",
                Orientation = 0.0,
                //Pos = Position.Generate()
                Pos = new Position()
                {
                    X = 10.0,
                    Y = 20.0
                }
            };
            double width, length;

            Console.Write("請輸入長方型的短邊尺寸: ");
            bool widthsuccess = double.TryParse(Console.ReadLine(), out width);
            if (widthsuccess)
            {
                Console.Write("請輸入長方型的長邊尺寸: ");
                bool lengthsuccess = double.TryParse(Console.ReadLine(), out length);
                if (lengthsuccess)
                {
                    person.DrawRectangle(length, width);
                }
                else
                {
                    Console.WriteLine("輸入錯誤，請重新執行!!");
                }
            }
            else
            {
                Console.WriteLine("輸入錯誤，請重新執行!!");
            }
            */
        }
    }
}