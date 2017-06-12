using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Example01
{
    public class Scene
    {
        public int Number;

        public PictureBox TargetPictureBox; // 場景控制  誰?

        //=== 建立場景 ===//
        public Scene(PictureBox target)
        {
            this.Number = 1; //==> 場景控制編號為 1
            this.TargetPictureBox = target;
            this.TargetPictureBox.Image = this.GetImage();
        }

        //=== 取得Image ===//
        public Image GetImage()
        {
            //=== 利用 Resource, array, C#, Image ==> 用Google去找解答 ===//
            if (this.Number == 1)
                return global::Example01.Properties.Resources._1;
            else if (this.Number == 2)
                return global::Example01.Properties.Resources._2;
            else if (this.Number == 3)
                return global::Example01.Properties.Resources._3;
            else if (this.Number == 4)
                return global::Example01.Properties.Resources._4;
            else if (this.Number == 5)
                return global::Example01.Properties.Resources._5;
            else if (this.Number == 6)
                return global::Example01.Properties.Resources._6;
            else if (this.Number == 7)
                return global::Example01.Properties.Resources._7;
            else if (this.Number == 8)
                return global::Example01.Properties.Resources._8;
            else if (this.Number == 9)
                return global::Example01.Properties.Resources._9;
            else
                return global::Example01.Properties.Resources._10;
            /*
            for (int i = 0; i < 2; i++)
            {
                pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("Computer" + i);
            }

            this.TargetPicture.Image
            */
        }

        public void ChangeTo(int target)
        {
            this.Number = target;
            this.TargetPictureBox.Image = this.GetImage();
        }
    }
}