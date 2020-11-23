using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        Bitmap SelectedFlag;

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
            var sw = float.Parse(Weights.Text);

            //   Number.MakeNumbers("Area");
            MN.Numbers(Struct1.Text, Struct2.Text, Struck3.Text, Regions.Text, Country.Text, Fonts.Text,
                SelectedFlag, float.Parse(Weights.Text),float.Parse(Heights.Text),Struct1.ForeColor);
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = false;
            colorDialog1.ShowHelp = true;

            colorDialog1.Color = Struct1.ForeColor;

            // Update the text box color if the user clicks OK 
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            { 
                Struct1.ForeColor = colorDialog1.Color;
                Struct2.ForeColor = colorDialog1.Color;
                Struck3.ForeColor = colorDialog1.Color;
            }

        }
    }
}
