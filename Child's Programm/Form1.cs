using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using License;
using Logical;

namespace Child_s_Programm
{
    public partial class Form1 : Form
    {

        private PhotoProccesing photo = new PhotoProccesing();
        private NumberForCar Number = new NumberForCar();
        private MakeNumber MN = new MakeNumber();
        private Picture_text PT = new Picture_text();
        private AddPictureBox APB = new AddPictureBox();

        Bitmap SelectedFlag;
        Bitmap Picture;
        OpenFileDialog openFile;
        public Form1()
        {
            InitializeComponent();

        }
            

        private void License_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Country.SelectedIndex = 0;
            Fonts.SelectedIndex = 0;
            DateOfBrith.SelectionStart = Convert.ToDateTime("02.02.2013");
            DateOfBrith.SelectionEnd = Convert.ToDateTime("02.02.2013");

        }


        private void button2_Click(object sender, EventArgs e)
        {

            //MN.Numbers(Struct1.Text, Struct2.Text, Struck3.Text, Regions.Text, Country.Text, Fonts.Text,
            //    SelectedFlag, float.Parse(Weights.Text), float.Parse(Heights.Text), Struct1.ForeColor);

            Size Sizes = License.Size-new Size(100,230);
            

            var bitmap = new Bitmap(Sizes.Width, Sizes.Height);
           
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(License.PointToScreen(Point.Empty), Point.Empty, Sizes);
            // bitmap.Save("lulu.png", ImageFormat.Png);
            MN.JustPrint(bitmap, float.Parse(Weights.Text), float.Parse(Heights.Text));
          //  MN.Just_Print(bitmap, 300f, 300f);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Country.SelectedIndex)
            {
                case 0:
                    {
                        SelectedFlag = Properties.Resources.flag_sRussia;
                        Flag.Image = Properties.Resources.flag_sRussia;
                        break;
                    }
                case 1:
                    {
                        SelectedFlag = Properties.Resources.ENG;
                        Flag.Image = Properties.Resources.ENG;
                        break;
                    }
                case 2:
                    {
                        SelectedFlag = Properties.Resources.brasil;
                        Flag.Image = Properties.Resources.brasil;
                        break;
                    }
            }

        }

        private void Font_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(FirstName.Text) && !String.IsNullOrEmpty(FullName.Text) && openFile.FileName != null)
            {
                    // photo.photo(FirstName.Text, FullName.Text, DateOfBrith.SelectionStart, DateOfIssue.TodayDate, openFile.FileName);
                    MN.MakeLicense(FirstName.Text, FullName.Text, DateOfBrith.SelectionStart, DateOfIssue.TodayDate, openFile.FileName);
            }
            else
                MessageBox.Show("Нельзя оставлять пустым имя, фамилию или фото!");

           
        }

        private void Chage_photo_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();


            openFile.Filter = "Файлы изображения | *.bmp;*.png;*jpg;";
            if (openFile.ShowDialog() == DialogResult.Cancel)
                return;

            if (openFile.FileName != null)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);
            }

        }

       

        private void button3_Click(object sender, EventArgs e)
        {
        

        }


        private void button4_Click(object sender, EventArgs e)
        {
            
                openFile = new OpenFileDialog();


            openFile.Filter = "Файлы изображения | *.bmp;*.png;*jpg;";
            if (openFile.ShowDialog() == DialogResult.Cancel)
                return;

            if (openFile.FileName != null)
            {
                Picture = (Bitmap)Image.FromFile(openFile.FileName);
                APB.AddPB(Picture, panel1, Convert.ToInt32(All.Text), Convert.ToInt32(Heigh.Text));
            }
        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            Bitmap text=PT.Converts(TextF.Text,colorDialog1.Color,Fonts.Text,Convert.ToInt32(SizeOfText.Text),Convert.ToInt32(Heigh.Text), Convert.ToInt32(All.Text));
            //            pork(text);
            APB.AddPB(text, panel1, Convert.ToInt32(All.Text), Convert.ToInt32(Heigh.Text));
        }


        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
