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
        private Bitmap License= Properties.Resources.Права;
        private Bitmap Result;

        private int SizeHeight = 457;
        private int SizeWeight = 350;

        private int LSizeHeight = 879;
        private int LSizeWeight = 1283;
       public Bitmap photo(string Name,string FullName,DateTime DateOfBrith,DateTime DateOfIssue,string Path)
        {
            Photo = new Bitmap(Image.FromFile(Path));
            Photo =new Bitmap(Photo, new Size(SizeWeight, SizeHeight));
            License = new Bitmap(License, new Size(LSizeWeight, LSizeHeight));

            Result = new Bitmap(License.Width, License.Height, PixelFormat.Format32bppArgb);


            Graphics graphics = Graphics.FromImage(Result);
            graphics.CompositingMode = CompositingMode.SourceOver;
            graphics.DrawImage(License, 0, 0);
            graphics.DrawImage(Photo, 23, 171, Photo.Width, Photo.Height);
            graphics.DrawString(FullName, new Font("Aria",34,FontStyle.Bold), new SolidBrush(Color.White),647, 220);
            graphics.DrawString(Name, new Font("Aria", 34, FontStyle.Bold), new SolidBrush(Color.White), 530, 310);
            graphics.DrawString(DateOfBrith.ToShortDateString(), new Font("Aria", 34, FontStyle.Bold), new SolidBrush(Color.White), 450, 550);
            graphics.DrawString(DateOfIssue.ToShortDateString(), new Font("Aria", 34, FontStyle.Bold), new SolidBrush(Color.White), 900, 550);

            return Result;
        }
    }
}
