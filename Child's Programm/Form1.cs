using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Child_s_Programm
{
    public partial class Form1 : Form
    {
        Bitmap Photo;
        Bitmap Licenses = Properties.Resources.license;
        
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap Result;
    
            OpenFileDialog openFile = new OpenFileDialog();
            SaveFileDialog saveFile = new SaveFileDialog();
            openFile.Filter = "Файлы изображения | *.bmp;*.png;*jpg;";
            if (openFile.ShowDialog() == DialogResult.Cancel)
                return;

            if (openFile.FileName != null)
            {
            //    pictureBox2.Image = Image.FromFile(openFile.FileName);
                Photo = new Bitmap(Image.FromFile(openFile.FileName));
                //          Bitmap result = new Bitmap()
                pictureBox2.Image = Photo;
             //   Result = new Bitmap(Licenses, License.Width, License.Height);
                Result = new Bitmap(License.Width,License.Height,System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                Graphics grap = Graphics.FromImage(Result);
                grap.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;


                Photo = new Bitmap(Photo, new Size(300, 300));
                grap.DrawImage(Licenses,0,0);
                grap.DrawImage(Photo, (License.Width-Photo.Width) / 2, (License.Height-Photo.Height) / 2, Photo.Width, Photo.Height);
                pictureBox1.Image = Result;

                Result.Save("image.Jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void License_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
