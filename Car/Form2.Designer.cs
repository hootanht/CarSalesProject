namespace Car
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAdvertisementRegistration = new System.Windows.Forms.Button();
            this.CarInfo = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Area = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.CarInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAdvertisementRegistration
            // 
            this.BtnAdvertisementRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdvertisementRegistration.Location = new System.Drawing.Point(407, 340);
            this.BtnAdvertisementRegistration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAdvertisementRegistration.Name = "BtnAdvertisementRegistration";
            this.BtnAdvertisementRegistration.Size = new System.Drawing.Size(130, 47);
            this.BtnAdvertisementRegistration.TabIndex = 0;
            this.BtnAdvertisementRegistration.Text = "ثبت آگهی";
            this.BtnAdvertisementRegistration.UseVisualStyleBackColor = true;
            // 
            // CarInfo
            // 
            this.CarInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CarInfo.Controls.Add(this.textBox5);
            this.CarInfo.Controls.Add(this.textBox4);
            this.CarInfo.Controls.Add(this.textBox3);
            this.CarInfo.Controls.Add(this.listBox1);
            this.CarInfo.Controls.Add(this.textBox2);
            this.CarInfo.Controls.Add(this.Area);
            this.CarInfo.Controls.Add(this.checkBox1);
            this.CarInfo.Controls.Add(this.label8);
            this.CarInfo.Controls.Add(this.label7);
            this.CarInfo.Controls.Add(this.label6);
            this.CarInfo.Controls.Add(this.label5);
            this.CarInfo.Controls.Add(this.label4);
            this.CarInfo.Controls.Add(this.label3);
            this.CarInfo.Controls.Add(this.label2);
            this.CarInfo.Controls.Add(this.textBox1);
            this.CarInfo.Controls.Add(this.label1);
            this.CarInfo.Location = new System.Drawing.Point(14, 16);
            this.CarInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CarInfo.Name = "CarInfo";
            this.CarInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CarInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CarInfo.Size = new System.Drawing.Size(523, 316);
            this.CarInfo.TabIndex = 1;
            this.CarInfo.TabStop = false;
            this.CarInfo.Text = "مشخصات";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "مدل ماشین:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "سال تولید:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "تیپ ماشین:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "مدت بیمه:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "کارکرد:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "قیمت:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(418, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "منطقه آگهی:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(397, 257);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox1.Size = new System.Drawing.Size(113, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = ":رنگ خوردگی";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Area
            // 
            this.Area.FormattingEnabled = true;
            this.Area.ItemHeight = 20;
            this.Area.Items.AddRange(new object[] {
            "تهران",
            "فارس",
            "اصفهان",
            "تبریز",
            "یزد",
            "بندرعباس",
            "بوشهر",
            "همدان",
            "کرج"});
            this.Area.Location = new System.Drawing.Point(276, 47);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(136, 24);
            this.Area.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 96);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(391, 27);
            this.textBox2.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "1380",
            "1381",
            "1382",
            "1383",
            "1384",
            "1385",
            "1386",
            "1387",
            "1388",
            "1389",
            "1390",
            "1391",
            "1392",
            "1393",
            "1394",
            "1395",
            "1396",
            "1397",
            "1398",
            "1399",
            "1400",
            "1401"});
            this.listBox1.Location = new System.Drawing.Point(283, 150);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(136, 24);
            this.listBox1.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(26, 147);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 27);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(283, 201);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 27);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(26, 198);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(136, 27);
            this.textBox5.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 403);
            this.Controls.Add(this.CarInfo);
            this.Controls.Add(this.BtnAdvertisementRegistration);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مشخصات ماشین";
            this.CarInfo.ResumeLayout(false);
            this.CarInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnAdvertisementRegistration;
        private GroupBox CarInfo;
        private TextBox textBox1;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private TextBox textBox4;
        private TextBox textBox3;
        private ListBox listBox1;
        private TextBox textBox2;
        private ListBox Area;
        private CheckBox checkBox1;
        private TextBox textBox5;
    }
}