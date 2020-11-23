
namespace Child_s_Programm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.License = new System.Windows.Forms.TabPage();
            this.Chage_photo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DateOfBrith = new System.Windows.Forms.MonthCalendar();
            this.DateOfIssue = new System.Windows.Forms.MonthCalendar();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FullName = new System.Windows.Forms.TextBox();
            this.Numbers = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Fonts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Weights = new System.Windows.Forms.TextBox();
            this.Heights = new System.Windows.Forms.TextBox();
            this.Flag = new System.Windows.Forms.PictureBox();
            this.Country = new System.Windows.Forms.ComboBox();
            this.Regions = new System.Windows.Forms.TextBox();
            this.Struck3 = new System.Windows.Forms.TextBox();
            this.Struct2 = new System.Windows.Forms.TextBox();
            this.Struct1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Heigh = new System.Windows.Forms.DomainUpDown();
            this.All = new System.Windows.Forms.DomainUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.TextF = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.License.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Numbers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Flag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.License);
            this.tabControl1.Controls.Add(this.Numbers);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(617, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // License
            // 
            this.License.BackgroundImage = global::Child_s_Programm.Properties.Resources.Права;
            this.License.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.License.Controls.Add(this.Chage_photo);
            this.License.Controls.Add(this.button1);
            this.License.Controls.Add(this.DateOfBrith);
            this.License.Controls.Add(this.DateOfIssue);
            this.License.Controls.Add(this.FirstName);
            this.License.Controls.Add(this.pictureBox1);
            this.License.Controls.Add(this.FullName);
            this.License.Location = new System.Drawing.Point(4, 22);
            this.License.Name = "License";
            this.License.Padding = new System.Windows.Forms.Padding(3);
            this.License.Size = new System.Drawing.Size(609, 410);
            this.License.TabIndex = 0;
            this.License.Text = "Права";
            this.License.UseVisualStyleBackColor = true;
            this.License.Click += new System.EventHandler(this.License_Click);
            // 
            // Chage_photo
            // 
            this.Chage_photo.Location = new System.Drawing.Point(22, 310);
            this.Chage_photo.Name = "Chage_photo";
            this.Chage_photo.Size = new System.Drawing.Size(113, 23);
            this.Chage_photo.TabIndex = 6;
            this.Chage_photo.Text = "Выбрать фото";
            this.Chage_photo.UseVisualStyleBackColor = true;
            this.Chage_photo.Click += new System.EventHandler(this.Chage_photo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Печать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DateOfBrith
            // 
            this.DateOfBrith.Location = new System.Drawing.Point(196, 254);
            this.DateOfBrith.Name = "DateOfBrith";
            this.DateOfBrith.TabIndex = 3;
            // 
            // DateOfIssue
            // 
            this.DateOfIssue.Location = new System.Drawing.Point(411, 254);
            this.DateOfIssue.Name = "DateOfIssue";
            this.DateOfIssue.TabIndex = 4;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(246, 147);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(269, 20);
            this.FirstName.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(305, 104);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(222, 20);
            this.FullName.TabIndex = 0;
            // 
            // Numbers
            // 
            this.Numbers.Controls.Add(this.label11);
            this.Numbers.Controls.Add(this.TextF);
            this.Numbers.Controls.Add(this.button5);
            this.Numbers.Controls.Add(this.label10);
            this.Numbers.Controls.Add(this.label9);
            this.Numbers.Controls.Add(this.label8);
            this.Numbers.Controls.Add(this.All);
            this.Numbers.Controls.Add(this.Heigh);
            this.Numbers.Controls.Add(this.panel1);
            this.Numbers.Controls.Add(this.button4);
            this.Numbers.Controls.Add(this.button3);
            this.Numbers.Controls.Add(this.label7);
            this.Numbers.Controls.Add(this.label6);
            this.Numbers.Controls.Add(this.label5);
            this.Numbers.Controls.Add(this.label4);
            this.Numbers.Controls.Add(this.label3);
            this.Numbers.Controls.Add(this.Fonts);
            this.Numbers.Controls.Add(this.label2);
            this.Numbers.Controls.Add(this.label1);
            this.Numbers.Controls.Add(this.Weights);
            this.Numbers.Controls.Add(this.Heights);
            this.Numbers.Controls.Add(this.Flag);
            this.Numbers.Controls.Add(this.Country);
            this.Numbers.Controls.Add(this.Regions);
            this.Numbers.Controls.Add(this.Struck3);
            this.Numbers.Controls.Add(this.Struct2);
            this.Numbers.Controls.Add(this.Struct1);
            this.Numbers.Controls.Add(this.pictureBox2);
            this.Numbers.Controls.Add(this.button2);
            this.Numbers.Location = new System.Drawing.Point(4, 22);
            this.Numbers.Name = "Numbers";
            this.Numbers.Padding = new System.Windows.Forms.Padding(3);
            this.Numbers.Size = new System.Drawing.Size(609, 410);
            this.Numbers.TabIndex = 1;
            this.Numbers.Text = "Номера";
            this.Numbers.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(281, 337);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Добавить фото";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(281, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Изменить цвет";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Только запятые!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(26, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "/Максиму 21СМ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "/Максиму 29СМ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Стиль:";
            // 
            // Fonts
            // 
            this.Fonts.FormattingEnabled = true;
            this.Fonts.Items.AddRange(new object[] {
            "Times New Roman",
            "Calibri",
            "Arial"});
            this.Fonts.Location = new System.Drawing.Point(86, 217);
            this.Fonts.Name = "Fonts";
            this.Fonts.Size = new System.Drawing.Size(121, 21);
            this.Fonts.TabIndex = 12;
            this.Fonts.SelectedIndexChanged += new System.EventHandler(this.Font_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ширина";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Высота";
            // 
            // Weights
            // 
            this.Weights.Location = new System.Drawing.Point(90, 301);
            this.Weights.Name = "Weights";
            this.Weights.Size = new System.Drawing.Size(49, 20);
            this.Weights.TabIndex = 9;
            this.Weights.Text = "5";
            // 
            // Heights
            // 
            this.Heights.Location = new System.Drawing.Point(90, 254);
            this.Heights.Name = "Heights";
            this.Heights.Size = new System.Drawing.Size(49, 20);
            this.Heights.TabIndex = 8;
            this.Heights.Text = "2";
            // 
            // Flag
            // 
            this.Flag.Location = new System.Drawing.Point(437, 124);
            this.Flag.Name = "Flag";
            this.Flag.Size = new System.Drawing.Size(44, 21);
            this.Flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flag.TabIndex = 7;
            this.Flag.TabStop = false;
            // 
            // Country
            // 
            this.Country.DisplayMember = "0";
            this.Country.FormattingEnabled = true;
            this.Country.Items.AddRange(new object[] {
            "RUS",
            "EN",
            "BRL"});
            this.Country.Location = new System.Drawing.Point(355, 124);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(64, 21);
            this.Country.TabIndex = 6;
            this.Country.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Regions
            // 
            this.Regions.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Regions.Location = new System.Drawing.Point(386, 56);
            this.Regions.Multiline = true;
            this.Regions.Name = "Regions";
            this.Regions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Regions.Size = new System.Drawing.Size(77, 38);
            this.Regions.TabIndex = 5;
            this.Regions.Text = "76";
            this.Regions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Struck3
            // 
            this.Struck3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Struck3.Location = new System.Drawing.Point(240, 50);
            this.Struck3.Name = "Struck3";
            this.Struck3.Size = new System.Drawing.Size(77, 44);
            this.Struck3.TabIndex = 4;
            this.Struck3.Text = "ED";
            this.Struck3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Struct2
            // 
            this.Struct2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Struct2.Location = new System.Drawing.Point(109, 50);
            this.Struct2.Name = "Struct2";
            this.Struct2.Size = new System.Drawing.Size(125, 44);
            this.Struct2.TabIndex = 3;
            this.Struct2.Text = "588";
            this.Struct2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Struct1
            // 
            this.Struct1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Struct1.Location = new System.Drawing.Point(26, 50);
            this.Struct1.Name = "Struct1";
            this.Struct1.Size = new System.Drawing.Size(77, 44);
            this.Struct1.TabIndex = 2;
            this.Struct1.Text = "AA";
            this.Struct1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Child_s_Programm.Properties.Resources.Numbers;
            this.pictureBox2.Location = new System.Drawing.Point(16, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(483, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(424, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Печать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(26, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 119);
            this.panel1.TabIndex = 20;
            // 
            // Heigh
            // 
            this.Heigh.Items.Add("25");
            this.Heigh.Items.Add("30");
            this.Heigh.Items.Add("40");
            this.Heigh.Items.Add("50");
            this.Heigh.Items.Add("60");
            this.Heigh.Items.Add("70");
            this.Heigh.Items.Add("80");
            this.Heigh.Items.Add("90");
            this.Heigh.Items.Add("100");
            this.Heigh.Location = new System.Drawing.Point(476, 225);
            this.Heigh.Name = "Heigh";
            this.Heigh.Size = new System.Drawing.Size(38, 20);
            this.Heigh.TabIndex = 21;
            this.Heigh.Text = "140";
            // 
            // All
            // 
            this.All.Items.Add("25");
            this.All.Items.Add("30");
            this.All.Items.Add("40");
            this.All.Items.Add("50");
            this.All.Items.Add("60");
            this.All.Items.Add("70");
            this.All.Items.Add("80");
            this.All.Items.Add("90");
            this.All.Items.Add("100");
            this.All.Location = new System.Drawing.Point(476, 280);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(47, 20);
            this.All.TabIndex = 22;
            this.All.Text = "140";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Высота";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(473, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Ширина";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Печать:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(281, 257);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 23);
            this.button5.TabIndex = 26;
            this.button5.Text = "Добавить текст";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // TextF
            // 
            this.TextF.Location = new System.Drawing.Point(272, 217);
            this.TextF.Multiline = true;
            this.TextF.Name = "TextF";
            this.TextF.Size = new System.Drawing.Size(135, 28);
            this.TextF.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(284, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Текст";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 443);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.License.ResumeLayout(false);
            this.License.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Numbers.ResumeLayout(false);
            this.Numbers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Flag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage License;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.MonthCalendar DateOfIssue;
        private System.Windows.Forms.MonthCalendar DateOfBrith;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Chage_photo;
        private System.Windows.Forms.TabPage Numbers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Fonts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Weights;
        private System.Windows.Forms.TextBox Heights;
        private System.Windows.Forms.PictureBox Flag;
        private System.Windows.Forms.ComboBox Country;
        private System.Windows.Forms.TextBox Regions;
        private System.Windows.Forms.TextBox Struck3;
        private System.Windows.Forms.TextBox Struct2;
        private System.Windows.Forms.TextBox Struct1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextF;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DomainUpDown All;
        private System.Windows.Forms.DomainUpDown Heigh;
        private System.Windows.Forms.Label label11;
    }
}

