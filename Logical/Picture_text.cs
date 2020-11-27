using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logical
{
    public class Picture_text
    {
       
        public Bitmap pb(string text, Color ColorText, string Font, int size, int heigh, int weigh)
        {
            //string text = "Какой-нибудь весьма длинный текст, не влезающий в картинку по длине, поэтому требующий переноса";
            Rectangle rect = new Rectangle(0, 0, weigh, heigh);
            Bitmap bmp2 = new Bitmap(weigh, heigh, PixelFormat.Format24bppRgb);

            using (Graphics g = Graphics.FromImage(bmp2))
            using (Font font = new Font(Font, size))
            {
                g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                // Заливаем фон нужным цветом.
                g.FillRectangle(Brushes.White, rect);

                // Выводим текст.
                TextRenderer.DrawText(
                    g,
                    text,
                    font,
                    rect,
                    ColorText, // цвет текста
                    TextFormatFlags.WordBreak // включаем перенос слов
                    );
            }
            return bmp2;
        }
    }


}
