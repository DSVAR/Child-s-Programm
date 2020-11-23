using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logical
{
    public  class AddPictureBox
    {
        private PictureBox[] PBCollection = new PictureBox[100];

        private int i = 0;
        private bool Dragging;
        private int xPos;
        private int yPos;

        public void AddPB(Bitmap bitmap, Panel panel1, int All, int Heigh)
        {
            PictureBox PB = new PictureBox();
            PB.BackColor = Color.Transparent;
            PB.Image = bitmap;
            PB.SizeMode = PictureBoxSizeMode.StretchImage;
            PB.Size = new Size(All,Heigh);

            PB.Name = "PB" + i.ToString();

            PB.MouseDown += new MouseEventHandler(TMouseDown);
            PB.MouseUp += new MouseEventHandler(TMouseUp);
            PB.MouseMove += new MouseEventHandler(TMouseMove);
            PB.MouseClick += new MouseEventHandler(TMouse_click);

            panel1.Controls.Add(PB);
            PBCollection[i] = PB;
            i++;
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
            if (sender is PictureBox)
            {

                if (e.Button == MouseButtons.Right)
                {
                    string er = ((PictureBox)sender).Name.Remove(0, 2);
                    int cost = Convert.ToInt32(er);
                    PBCollection[cost].Dispose();
                }
            }

        }
    }
}
