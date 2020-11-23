using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using License;

namespace Logical
{
    public class MakeNumber
    {
        Bitmap print;
        NumberForCar NFC = new NumberForCar();
        PhotoProccesing PP = new PhotoProccesing();
        
        PrintDocument PD = new PrintDocument();

        private float ValueOfPixel = 37.9f;//в одном сантиметре
        private float MaxPixelWeight = 795.9f;
        private float MaxPixelHeight = 1125.63f;

        string PathFolder;
        

        public void Numbers(string strunc1,string struck2,string struck3, string region,string country,
            string font,Bitmap flag, float weight,float height,Color color)
        {
            PathFolder = Environment.CurrentDirectory;
            PathFolder +=@"\HistoryNumbers";
            int margin=1000;
            print = NFC.MakeNumbers(strunc1, struck2, struck3, region, country, font, flag,margin,color);
          //  print.Save(strunc1 + struck2 + struck3 + "_" + region + ".png", ImageFormat.Png);

            if (Directory.Exists(PathFolder))
            {
                print.Save(PathFolder + "\\"+ strunc1 + struck2 + struck3 + "_" + region + ".png", ImageFormat.Png);
            }
            else
            {
                Directory.CreateDirectory(PathFolder);
                print.Save(PathFolder +"\\"+ strunc1 + struck2 + struck3 + "_" + region + ".png", ImageFormat.Png);
            }

            print = new Bitmap(print, new Size( PixelWeightInSM(weight), PixelHeighInSM(height)));
            Printer();
        }

        public void MakeLicense(string Name, string FullName, DateTime DateOfBrith, DateTime DateOfIssue, string Path)
        {
            PathFolder = Environment.CurrentDirectory;
            PathFolder += @"\HistoryLicense";

            print = PP.photo(Name, FullName, DateOfBrith, DateOfIssue, Path);
        //    print.Save(Name + "_" + FullName + ".png", ImageFormat.Png);

            if (Directory.Exists(PathFolder))
            {
                print.Save(PathFolder + "\\" + Name + "_" + FullName + ".png", ImageFormat.Png);
            }
            else
            {
                Directory.CreateDirectory(PathFolder);
                print.Save(PathFolder + "\\" + Name + "_" + FullName + ".png", ImageFormat.Png);
            }

            print = new Bitmap(print, new Size(PixelWeightInSM(19), PixelHeighInSM(14)));
            Printer();
        }

      
        public void JustPrint(Bitmap printer, float weight, float height)
        {
            PathFolder = Environment.CurrentDirectory;
            PathFolder += @"\HistoryNumbers";

            print = printer;

            if (Directory.Exists(PathFolder))
            {
                print.Save(PathFolder + "\\" +"LastNumber"+ ".png", ImageFormat.Png);
            }
            else
            {
                Directory.CreateDirectory(PathFolder);
                print.Save(PathFolder + "\\" + "LastNumber" + ".png", ImageFormat.Png);
            }
            print = new Bitmap(print, new Size(PixelWeightInSM(weight), PixelHeighInSM(height)));
            Printer();

        }
        void Printer()
        {
          
            PD.PrintPage += Printing;
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = PD;
            if (printDialog.ShowDialog() == DialogResult.OK)
                PD.Print();
        }

        void Printing(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap(print), new Point(0, 0));
        }

        private int PixelHeighInSM(float SM)
        {
            float result;
            result = SM * ValueOfPixel;
            if (result >= MaxPixelHeight)
                result = MaxPixelHeight;

            return Convert.ToInt32(result);
        }

        private int PixelWeightInSM(float SM)
        {
            {
                float result;
                result = SM * ValueOfPixel;
                if (result >= MaxPixelWeight)
                    result = MaxPixelWeight;

                return Convert.ToInt32( result);
            }
        }
    }
}
