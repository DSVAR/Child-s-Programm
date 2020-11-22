using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;


namespace License
{
   public class NumberForCar
    {
        private Bitmap Theme = Properties.Resources.Numbers;
        private Bitmap Result;
        private Bitmap Flag = Properties.Resources.flag_sRussia;


        private int ThemeHeight = 329;
        private int ThemeWeight = 1339;
        private int FlagHeigh = 85;
        private int FlagWeight = 109;
        public void MakeNumbers(string font)
        {
            Theme = new Bitmap(Theme, new Size(ThemeWeight, ThemeHeight));
            Result = new Bitmap(ThemeWeight, ThemeHeight, PixelFormat.Format32bppArgb);
            Flag = new Bitmap(Flag, new Size(FlagWeight, FlagHeigh)) ;

            Graphics graphics = Graphics.FromImage(Result);
            graphics.CompositingMode = CompositingMode.SourceOver;
            graphics.DrawImage(Theme, 0, 0);
            graphics.DrawString("AE", new Font(font,120, FontStyle.Bold), new SolidBrush(Color.Black),0,100);
            graphics.DrawString("558", new Font(font, 150, FontStyle.Bold), new SolidBrush(Color.Black),250, 70);
            graphics.DrawString("AE", new Font(font, 120, FontStyle.Bold), new SolidBrush(Color.Black), 620, 100);

            graphics.DrawString("116", new Font(font, 120, FontStyle.Bold), new SolidBrush(Color.Black), 950, 50);
            graphics.DrawString("RUS", new Font(font, 80, FontStyle.Bold), new SolidBrush(Color.Black), 920, 200);
            graphics.DrawImage(Flag, 1180, 220);

            Result.Save("ZIK.Jpeg", ImageFormat.Jpeg);
        }
    }
}
