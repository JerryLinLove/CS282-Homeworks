using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMathLibrary
{
    public class Vector
    {
        #region 屬性定義

        /*
      //=== 手動建立欄位 ===//
        private double x;
        private double y;

        public double X
        {
            get => x;
            set => x = value;
        }

        public double Y
        {
            get => y;
            set => y = value;
        }
        */

        //=== 由C#自動建立欄位，需要其它方法來取得實際記憶體資料 ===//
        //=== 較不常用，除非很簡單的欄位，才會使用，一般欄位需要進行檢查才行 ===//
        public double X { get; set; }

        public double Y { get; set; }

        public double Length
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }

        #endregion 屬性定義

        #region 建構式

        public Vector(double X, double Y)
        {
            this.X = X; //this ==> 這個類別的X, 也就是指 public double X { get; set; } 的 X
                        // Y 因為沒標示，才是指 double Y
            this.Y = Y;
        }

        public Vector() : this(0, 0)
        {
        }

        public Vector(Vector vector) : this(vector.X, vector.Y)
        {
        }

        /*
        //=== 第一種寫法 ===//
        public Vector()
        {
            X = 0;
            Y = 0;
        }

        public Vector(double X, double Y)
        {
            this.X = X; //this ==> 這個類別的X, 也就是指 public double X { get; set; } 的 X
                        // Y 因為沒標示，才是指 double Y
            this.Y = Y;
        }

        public Vector(Vector vector)
        {
            this.X = vector.X;
            this.Y = vector.Y;
        }
        */

        #endregion 建構式

        public void Print()
        {
            Console.WriteLine("X: {0}, Y: {1}", this.X, this.Y);
        }
    }
}