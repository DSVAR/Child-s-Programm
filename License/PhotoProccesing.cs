using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Threading;

namespace License
{
   public class PhotoProccesing
    {
        private Bitmap Photo;
        private Bitmap License= Properties.Resources.AllLicens;
        private Bitmap Result;

        private int SizeHeight = 470;
        private int SizeWeight = 450;

        private int LSizeHeight = 1850;
        private int LSizeWeight = 1850;
       public Bitmap photo(string FirstName, string FullName, DateTime DateOfBrith, DateTime Gets, string Series, string area, string Path)
        {
            Photo = new Bitmap(Image.FromFile(Path));
            Photo =new Bitmap(Photo, new Size(SizeWeight, SizeHeight));
            License = new Bitmap(License, new Size(LSizeWeight, LSizeHeight));

            Result = new Bitmap(License.Width, License.Height, PixelFormat.Format32bppArgb);


            Graphics graphics = Graphics.FromImage(Result);
            graphics.CompositingMode = CompositingMode.SourceOver;
            graphics.DrawImage(License, 0, 0);
            graphics.DrawImage(Photo, 120, 230, Photo.Width, Photo.Height);
            graphics.DrawString(FullName.ToUpper(), new Font("Aria",34,FontStyle.Bold), new SolidBrush(Color.Black),700, 180);//2
            graphics.DrawString(FirstName.ToUpper(), new Font("Aria", 34, FontStyle.Bold), new SolidBrush(Color.Black), 700, 265);//1

            graphics.DrawString(DateOfBrith.ToShortDateString(), new Font("Aria", 34, FontStyle.Bold), new SolidBrush(Color.Black), 700, 350);//3
            graphics.DrawString(DateOfBrith.ToShortDateString(), new Font("Aria", 34, FontStyle.Bold), new SolidBrush(Color.Black), 715, 470);//4a
            graphics.DrawString(DateOfBrith.ToShortDateString(), new Font("Aria", 34, FontStyle.Bold), new SolidBrush(Color.Black), 1255, 470);//4b
            graphics.DrawString("ГИБДД", new Font("Aria", 34, FontStyle.Bold), new SolidBrush(Color.Black), 715, 515);//4c

            graphics.DrawString(Series.ToUpper(), new Font("Aria", 34, FontStyle.Bold), new SolidBrush(Color.Black), 700, 590);//5
            graphics.DrawString(area.ToUpper(), new Font("Aria", 34, FontStyle.Bold), new SolidBrush(Color.Black), 700, 640);//8


            Result.Save("buk.jpeg", ImageFormat.Jpeg);
            return Result;
        }
    }
}
