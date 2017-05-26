using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
    public class Position
    {
        public double X;
        public double Y;

        private static Random random;  //私有參數，這只是功能，不開放給其它程序使用

        public static Position Generate()   // Generate ==> 亂數產生器
        {
            if (Position.random == null)    // 單體寫法
                random = new Random();
            return new Position()
            {
                X = random.Next(-100, 101),
                Y = random.Next(-100, 101)
            };
        }
    }
}
