
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
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Struct1 = new System.Windows.Forms.TextBox();
            this.Struct2 = new System.Windows.Forms.TextBox();
            this.Struck3 = new System.Windows.Forms.TextBox();
            this.Regions = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.ComboBox();
            this.Flag = new System.Windows.Forms.PictureBox();
            this.Heights = new System.Windows.Forms.TextBox();
            this.Weights = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Fonts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Numbers = new System.Windows.Forms.TabPage();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.License.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flag)).BeginInit();
            this.Numbers.SuspendLayout();
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Child_s_Programm.Properties.Resources.Numbers;
            this.pictureBox2.Location = new System.Drawing.Point(16, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(455, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
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
            // Regions
            // 
            this.Regions.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Regions.Location = new System.Drawing.Point(355, 38);
            this.Regions.Multiline = true;
            this.Regions.Name = "Regions";
            this.Regions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Regions.Size = new System.Drawing.Size(77, 38);
            this.Regions.TabIndex = 5;
            this.Regions.Text = "76";
            this.Regions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Country
            // 
            this.Country.DisplayMember = "0";
            this.Country.FormattingEnabled = true;
            this.Country.Items.AddRange(new object[] {
            "RUS",
            "EN",
            "BRL"});
            this.Country.Location = new System.Drawing.Point(333, 85);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(64, 21);
            this.Country.TabIndex = 6;
            this.Country.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Flag
            // 
            this.Flag.Location = new System.Drawing.Point(403, 85);
            this.Flag.Name = "Flag";
            this.Flag.Size = new System.Drawing.Size(44, 21);
            this.Flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flag.TabIndex = 7;
            this.Flag.TabStop = false;
            // 
            // Heights
            // 
            this.Heights.Location = new System.Drawing.Point(78, 182);
            this.Heights.Name = "Heights";
            this.Heights.Size = new System.Drawing.Size(49, 20);
            this.Heights.TabIndex = 8;
            this.Heights.Text = "2";
            // 
            // Weights
            // 
            this.Weights.Location = new System.Drawing.Point(78, 229);
            this.Weights.Name = "Weights";
            this.Weights.Size = new System.Drawing.Size(49, 20);
            this.Weights.TabIndex = 9;
            this.Weights.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Высота";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ширина";
            // 
            // Fonts
            // 
            this.Fonts.FormattingEnabled = true;
            this.Fonts.Items.AddRange(new object[] {
            "Times New Roman",
            "Calibri",
            "Arial"});
            this.Fonts.Location = new System.Drawing.Point(74, 145);
            this.Fonts.Name = "Fonts";
            this.Fonts.Size = new System.Drawing.Size(121, 21);
            this.Fonts.TabIndex = 12;
            this.Fonts.SelectedIndexChanged += new System.EventHandler(this.Font_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Стиль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "/Максиму 29СМ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "/Максиму 21СМ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(14, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Только запятые!";
            // 
            // Numbers
            // 
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(277, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Изменить цвет";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flag)).EndInit();
            this.Numbers.ResumeLayout(false);
            this.Numbers.PerformLayout();
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
    }
}

