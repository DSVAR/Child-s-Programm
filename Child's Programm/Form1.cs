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
        private Picture_text PT = new Picture_text();

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

        PictureBox[] PBCollection=new PictureBox[100];

        int i = 0;
        private bool Dragging;
        private int xPos;
        private int yPos;

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        void TMouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            xPos = e.X;
            yPos = e.Y;
        }


        void TMouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
        void TMouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (Dragging && c != null)
            {
                c.Top = e.Y + c.Top - yPos;
                c.Left = e.X + c.Left - xPos;
            }
        }

        void TMouse_click(object sender, MouseEventArgs e)
        {
            if(sender is PictureBox)
            {
                
                if (e.Button == MouseButtons.Right)
                {
                   string er= ((PictureBox)sender).Name.Remove(0,2);
                    int cost = Convert.ToInt32(er);
                    PBCollection[cost].Dispose();
                }
            }
           
        }
        


        private void button5_Click_1(object sender, EventArgs e)
        {
            Bitmap text=PT.Converts(TextF.Text,colorDialog1.Color,Fonts.Text,Convert.ToInt32(All.Text),Convert.ToInt32( Heigh.Text), Convert.ToInt32(All.Text));
            pork(text);
        }

        void pork(Bitmap bitmap)
        {
            PictureBox PB = new PictureBox();
            PB.BackColor = Color.Transparent;
            PB.Image = bitmap;
            PB.SizeMode = PictureBoxSizeMode.StretchImage;
            PB.Size = new Size(Convert.ToInt32(All.Text), Convert.ToInt32(Heigh.Text));
            
            PB.Name = "PB" + i.ToString();

            PB.MouseDown += new MouseEventHandler(TMouseDown);
            PB.MouseUp += new MouseEventHandler(TMouseUp);
            PB.MouseMove += new MouseEventHandler(TMouseMove);
            PB.MouseClick += new MouseEventHandler(TMouse_click);

            panel1.Controls.Add(PB);
            PBCollection[i] = PB;
            i++;
        }
    }
}
