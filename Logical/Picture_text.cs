using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    public class Picture_text
    {
       
        Bitmap theme=Properties.Resources._null;
        public Bitmap Converts(string text,Color ColorText,string Font,int size,int heigh,int weigh)
        {
            
             theme = new Bitmap(theme ,new Size(weigh, heigh));
            theme.MakeTransparent(Color.White);
            Bitmap result =new Bitmap(weigh, heigh, PixelFormat.Format32bppArgb);
            result.MakeTransparent(Color.White);
            
            Graphics grap = Graphics.FromImage(result);
            grap.CompositingMode = CompositingMode.SourceOver;
            grap.DrawImage(theme, 0, 0);
            grap.DrawString(text, new Font(Font, size, FontStyle.Bold), new SolidBrush(ColorText),0,0);
            
            result.MakeTransparent(Color.White);
            result.Save("Imp.png", ImageFormat.Png);
            return result;
        }
    }
}
