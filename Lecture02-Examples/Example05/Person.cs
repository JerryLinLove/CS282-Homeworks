using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
    public class Person
    {
        public string Name;
        public string Brithday;
        public string Email;
        public string Pos;
        public string Orientation;

        public void MoveForward(double distance)
        {
            Pos.X = Pos.X + Math.Cos(Orientation * Math.PI / 180.0);
            Pos.Y = Pos.Y + Math.Sin(Orientation * Math.PI / 180.0);
        }

        public void TrunRight (double angle)
        {
            Orientation = Orientation + angle;
        }

        public void ShowPosition()
        {
            Console.WriteLine("{0}的位置:({1}, {2}) 方位：{3}度, Name, Pos.X, Pos.Y, Orientation");
        }

        public void DrawSquare(double width)
        {
            for (var count = 0; count < 4; count++)
            {
                this.MoveForward(width);
                this.TrunRight(90);
                this.ShowPosition();
            }
        }

        public void DrawSquare()
        {
            DrawSquare(100);
        }

    }
}
