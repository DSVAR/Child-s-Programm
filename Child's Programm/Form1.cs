using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using License;

namespace Child_s_Programm
{
    public partial class Form1 : Form
    {

        private PhotoProccesing photo = new PhotoProccesing();
        private NumberForCar Number = new NumberForCar();
          
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(FirstName.Text) && !String.IsNullOrEmpty(FullName.Text))
            {
                OpenFileDialog openFile = new OpenFileDialog();

                openFile.Filter = "Файлы изображения | *.bmp;*.png;*jpg;";
                if (openFile.ShowDialog() == DialogResult.Cancel)
                    return;
                
                if (openFile.FileName != null)
                {
                    photo.photo(FirstName.Text, FullName.Text,DateOfBrith.SelectionStart,DateOfIssue.TodayDate, openFile.FileName);
                }

            }
            else
                MessageBox.Show("Нельзя оставлять пустым имя и фамилию!");
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap dw = Properties.Resources.Права;
            DateOfBrith.SelectionStart=Convert.ToDateTime("02.02.2013");
            DateOfBrith.SelectionEnd= Convert.ToDateTime("02.02.2013");
            comboBox2.Items.Add(dw);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Number.MakeNumbers("Area");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
