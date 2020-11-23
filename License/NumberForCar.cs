using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;

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
        public Bitmap MakeNumbers(string strunc1, string struck2, string struck3, string region, string country, 
            string font, Bitmap flag,int margin,Color color)
        {
            Theme = new Bitmap(Theme, new Size(ThemeWeight, ThemeHeight));
            Result = new Bitmap(ThemeWeight, ThemeHeight, PixelFormat.Format32bppArgb);
            flag = new Bitmap(flag, new Size(FlagWeight, FlagHeigh)) ;

            Graphics graphics = Graphics.FromImage(Result);
            graphics.CompositingMode = CompositingMode.SourceOver;
            graphics.DrawImage(Theme, 0, 0);
            graphics.DrawString(strunc1, new Font(font,120, FontStyle.Bold), new SolidBrush(color),0,100);
            graphics.DrawString(struck2, new Font(font, 150, FontStyle.Bold), new SolidBrush(color),250, 70);
            graphics.DrawString(struck3, new Font(font, 120, FontStyle.Bold), new SolidBrush(color), 620, 100);

            graphics.DrawString(region, new Font(font, 120, FontStyle.Bold), new SolidBrush(Color.Black), margin, 50);
            graphics.DrawString(country, new Font(font, 80, FontStyle.Bold), new SolidBrush(Color.Black), 920, 200);
            graphics.DrawImage(flag, 1180, 220);

            // Result.Save("ZIK.Jpeg", ImageFormat.Jpeg);
            
            return Result;
        }
    }
}
