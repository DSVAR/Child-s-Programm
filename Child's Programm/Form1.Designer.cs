
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
            this.Numbers = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.License = new System.Windows.Forms.TabPage();
            this.DateOfBrith = new System.Windows.Forms.MonthCalendar();
            this.DateOfIssue = new System.Windows.Forms.MonthCalendar();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FullName = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.Numbers.SuspendLayout();
            this.License.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.License);
            this.tabControl1.Controls.Add(this.Numbers);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(515, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // Numbers
            // 
            this.Numbers.Controls.Add(this.pictureBox3);
            this.Numbers.Controls.Add(this.comboBox1);
            this.Numbers.Controls.Add(this.textBox4);
            this.Numbers.Controls.Add(this.textBox3);
            this.Numbers.Controls.Add(this.textBox2);
            this.Numbers.Controls.Add(this.textBox1);
            this.Numbers.Controls.Add(this.pictureBox2);
            this.Numbers.Controls.Add(this.button2);
            this.Numbers.Location = new System.Drawing.Point(4, 22);
            this.Numbers.Name = "Numbers";
            this.Numbers.Padding = new System.Windows.Forms.Padding(3);
            this.Numbers.Size = new System.Drawing.Size(507, 410);
            this.Numbers.TabIndex = 1;
            this.Numbers.Text = "Номера";
            this.Numbers.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(424, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // License
            // 
            this.License.BackgroundImage = global::Child_s_Programm.Properties.Resources.Права;
            this.License.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.License.Controls.Add(this.DateOfBrith);
            this.License.Controls.Add(this.DateOfIssue);
            this.License.Controls.Add(this.FirstName);
            this.License.Controls.Add(this.pictureBox1);
            this.License.Controls.Add(this.FullName);
            this.License.Location = new System.Drawing.Point(4, 22);
            this.License.Name = "License";
            this.License.Padding = new System.Windows.Forms.Padding(3);
            this.License.Size = new System.Drawing.Size(507, 410);
            this.License.TabIndex = 0;
            this.License.Text = "Права";
            this.License.UseVisualStyleBackColor = true;
            this.License.Click += new System.EventHandler(this.License_Click);
            // 
            // DateOfBrith
            // 
            this.DateOfBrith.Location = new System.Drawing.Point(161, 254);
            this.DateOfBrith.Name = "DateOfBrith";
            this.DateOfBrith.TabIndex = 3;
            // 
            // DateOfIssue
            // 
            this.DateOfIssue.Location = new System.Drawing.Point(329, 254);
            this.DateOfIssue.Name = "DateOfIssue";
            this.DateOfIssue.TabIndex = 4;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(209, 147);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(269, 20);
            this.FirstName.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(256, 104);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(222, 20);
            this.FullName.TabIndex = 0;
            this.FullName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(26, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 44);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "AA";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(109, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 44);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "588";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(240, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(77, 44);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "ED";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(355, 38);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox4.Size = new System.Drawing.Size(77, 38);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "76";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "0";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "RUS",
            "EN",
            "BRL"});
            this.comboBox1.Location = new System.Drawing.Point(333, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(64, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(403, 85);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 21);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Numbers.ResumeLayout(false);
            this.Numbers.PerformLayout();
            this.License.ResumeLayout(false);
            this.License.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage License;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.TabPage Numbers;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.MonthCalendar DateOfIssue;
        private System.Windows.Forms.MonthCalendar DateOfBrith;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

