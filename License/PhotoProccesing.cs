using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using License.Properties;

namespace License
{
   public class PhotoProccesing
    {
        private Bitmap Photo;
        private Bitmap License= Properties.Resources.AllLicens2;
        private Bitmap Result;

        private int SizeHeight = 470;
        private int SizeWeight = 450;

        private int LSizeHeight = 1850;
        private int LSizeWeight = 1850;

        string Pice2;
        string Pice3;
       public Bitmap photo(string FirstName, string FullName, DateTime DateOfBrith, DateTime Gets, string Series
           , string area, string Path,List<string> ck)
        {
            Photo = new Bitmap(Image.FromFile(Path));
            Photo =new Bitmap(Photo, new Size(SizeWeight, SizeHeight));
            License = new Bitmap(License, new Size(LSizeWeight, LSizeHeight));

            Result = new Bitmap(License.Width, License.Height, PixelFormat.Format32bppArgb);


            Graphics graphics = Graphics.FromImage(Result);
            graphics.CompositingMode = CompositingMode.SourceOver;
            graphics.DrawImage(License, 0, 0);
            graphics.DrawImage(Photo, 120, 240, Photo.Width, Photo.Height);//6
            graphics.DrawString(FullName.ToUpper(), new Font("Aria",34,FontStyle.Bold), new SolidBrush(Color.Black),720, 187);//2
            graphics.DrawString(FirstName.ToUpper(), new Font("Aria", 34, FontStyle.Bold), new SolidBrush(Color.Black), 720, 267);//1

            graphics.DrawString(DateOfBrith.ToShortDateString(), new Font("Aria", 34, FontStyle.Bold), new SolidBrush(Color.Black), 720, 357);//3
            graphics.DrawString(DateOfBrith.ToShortDateString(), new Font("Aria", 34, FontStyle.Bold), new SolidBrush(Color.Black), 720, 477);//4a
            graphics.DrawString(Gets.ToShortDateString(), new Font("Aria", 34, FontStyle.Bold), new SolidBrush(Color.Black), 1265, 477);//4b
            graphics.DrawString("ГИБДД", new Font("Aria", 34, FontStyle.Bold), new SolidBrush(Color.Black), 720, 522);//4c

            graphics.DrawString(Series.ToUpper(), new Font("Aria", 34, FontStyle.Bold), new SolidBrush(Color.Black), 720, 597);//5
            graphics.DrawString(area.ToUpper(), new Font("Aria", 34, FontStyle.Bold), new SolidBrush(Color.Black), 720, 647);//8

            var res = Resources.ResourceManager; ;
           
            int X = 710;
            foreach(string names in ck)
            {
                graphics.DrawImage((Bitmap)res.GetObject(names), X, 740, 50, 50);//6
                X += 70;
                if (names == "A")
                {
                    graphics.DrawString(DateOfBrith.ToShortDateString(), new Font("Aria", 28, FontStyle.Bold), new SolidBrush(Color.Black), 750, 1090);//a1
                    graphics.DrawString(DateOfBrith.ToShortDateString(), new Font("Aria", 28, FontStyle.Bold), new SolidBrush(Color.Black), 1000, 1090);//a2
                }
                if (names == "B")
                {
                    graphics.DrawString(DateOfBrith.ToShortDateString(), new Font("Aria", 28, FontStyle.Bold), new SolidBrush(Color.Black), 750, 1140);//b1
                    graphics.DrawString(DateOfBrith.ToShortDateString(), new Font("Aria", 28, FontStyle.Bold), new SolidBrush(Color.Black), 1000, 1140);//b2
                }
                if (names == "C")
                {
                    graphics.DrawString(DateOfBrith.ToShortDateString(), new Font("Aria", 28, FontStyle.Bold), new SolidBrush(Color.Black), 750, 1190);//c1
                    graphics.DrawString(DateOfBrith.ToShortDateString(), new Font("Aria", 28, FontStyle.Bold), new SolidBrush(Color.Black), 1000, 1190);//c2

                }
                if (names == "D")
                {
                    graphics.DrawString(DateOfBrith.ToShortDateString(), new Font("Aria", 28, FontStyle.Bold), new SolidBrush(Color.Black), 750, 1245);//d1
                    graphics.DrawString(DateOfBrith.ToShortDateString(), new Font("Aria", 28, FontStyle.Bold), new SolidBrush(Color.Black), 1000, 1245);//d2

                }
                if (names == "BE")
                {
                    graphics.DrawString(DateOfBrith.ToShortDateString(), new Font("Aria", 28, FontStyle.Bold), new SolidBrush(Color.Black), 750, 1300);//BE1
                    graphics.DrawString(DateOfBrith.ToShortDateString(), new Font("Aria", 28, FontStyle.Bold), new SolidBrush(Color.Black), 1000, 1300);//BE2

                }
                if (names == "CE")
                {
                    graphics.DrawString(DateOfBrith.ToShortDateString(), new Font("Aria", 28, FontStyle.Bold), new SolidBrush(Color.Black), 750, 1350);//CE1
                    graphics.DrawString(DateOfBrith.ToShortDateString(), new Font("Aria", 28, FontStyle.Bold), new SolidBrush(Color.Black), 1000, 1350);//CE2
                }
                if (names == "DE")
                {
                    graphics.DrawString(DateOfBrith.ToShortDateString(), new Font("Aria", 28, FontStyle.Bold), new SolidBrush(Color.Black), 750, 1400);//DE1
                    graphics.DrawString(DateOfBrith.ToShortDateString(), new Font("Aria", 28, FontStyle.Bold), new SolidBrush(Color.Black), 1000, 1400);//E2
                }
            }

            Pice2 = Series.Remove(0, 2);
            Pice2 = Pice2.Remove(2, Pice2.Length - 2);

            Pice3 = Series.Remove(0, 4);
            graphics.DrawString(Series.Remove(2,8), new Font("Aria", 38, FontStyle.Bold), new SolidBrush(Color.HotPink), 1100, 1580);//Series bottom
            graphics.DrawString(Pice2, new Font("Aria", 38, FontStyle.Bold), new SolidBrush(Color.HotPink), 1190, 1580);//Series bottom
            graphics.DrawString(Pice3, new Font("Aria", 38, FontStyle.Bold), new SolidBrush(Color.HotPink), 1290, 1580);//Series bottom
            
           // Result.Save("buk.jpeg", ImageFormat.Jpeg);
            return Result;
        }
    }
}
