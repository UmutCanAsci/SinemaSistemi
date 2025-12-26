namespace SinemaSistemi
{
    partial class SinemaBiletSistemi
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
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            nmrMisirAdet = new NumericUpDown();
            nmrIcecekAdet = new NumericUpDown();
            comboBox4 = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            comboBox3 = new ComboBox();
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            cmbOdemeYontemi = new ComboBox();
            txtKartNo = new TextBox();
            labelKart = new Label();
            label9 = new Label();
            label10 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrMisirAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrIcecekAdet).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(171, 33);
            label1.Name = "label1";
            label1.Size = new Size(57, 31);
            label1.TabIndex = 0;
            label1.Text = "text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(46, 82);
            label2.Name = "label2";
            label2.Size = new Size(45, 28);
            label2.TabIndex = 1;
            label2.Text = "text";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(202, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 36);
            comboBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(46, 142);
            label3.Name = "label3";
            label3.Size = new Size(150, 28);
            label3.TabIndex = 3;
            label3.Text = "Sinema Salonu :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(50, 195);
            label4.Name = "label4";
            label4.Size = new Size(119, 28);
            label4.TabIndex = 4;
            label4.Text = "Seans Saati :";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(202, 195);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 36);
            comboBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(50, 277);
            button1.Name = "button1";
            button1.Size = new Size(303, 65);
            button1.TabIndex = 6;
            button1.Text = "Koltuk Numarası Seç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.HighlightText;
            label5.Location = new Point(46, 358);
            label5.Name = "label5";
            label5.Size = new Size(110, 28);
            label5.TabIndex = 7;
            label5.Text = "Koltuk No :";
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = SystemColors.HighlightText;
            label6.Location = new Point(161, 358);
            label6.Name = "label6";
            label6.Size = new Size(188, 74);
            label6.TabIndex = 8;
            label6.Click += label6_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(nmrMisirAdet);
            groupBox1.Controls.Add(nmrIcecekAdet);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(416, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 158);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ekstra";
            // 
            // nmrMisirAdet
            // 
            nmrMisirAdet.Location = new Point(316, 43);
            nmrMisirAdet.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nmrMisirAdet.Name = "nmrMisirAdet";
            nmrMisirAdet.Size = new Size(86, 34);
            nmrMisirAdet.TabIndex = 4;
            // 
            // nmrIcecekAdet
            // 
            nmrIcecekAdet.Location = new Point(316, 101);
            nmrIcecekAdet.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nmrIcecekAdet.Name = "nmrIcecekAdet";
            nmrIcecekAdet.Size = new Size(86, 34);
            nmrIcecekAdet.TabIndex = 17;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(159, 100);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 36);
            comboBox4.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 103);
            label8.Name = "label8";
            label8.Size = new Size(74, 28);
            label8.TabIndex = 2;
            label8.Text = "İçecek :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 45);
            label7.Name = "label7";
            label7.Size = new Size(113, 28);
            label7.TabIndex = 1;
            label7.Text = "Mısır Boyu :";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(159, 42);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 36);
            comboBox3.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(416, 232);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(417, 172);
            listBox1.TabIndex = 10;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(416, 182);
            button2.Name = "button2";
            button2.Size = new Size(417, 44);
            button2.TabIndex = 11;
            button2.Text = " Sepet Tutarı Görüntüle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(727, 476);
            button3.Name = "button3";
            button3.Size = new Size(106, 63);
            button3.TabIndex = 12;
            button3.Text = "Satın Al";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(50, 461);
            button4.Name = "button4";
            button4.Size = new Size(106, 63);
            button4.TabIndex = 13;
            button4.Text = "Geri Dön";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // cmbOdemeYontemi
            // 
            cmbOdemeYontemi.Font = new Font("Segoe UI", 12F);
            cmbOdemeYontemi.FormattingEnabled = true;
            cmbOdemeYontemi.Items.AddRange(new object[] { "Nakit", "Kredi Kartı", "QR Ödeme" });
            cmbOdemeYontemi.Location = new Point(638, 424);
            cmbOdemeYontemi.Name = "cmbOdemeYontemi";
            cmbOdemeYontemi.Size = new Size(195, 36);
            cmbOdemeYontemi.TabIndex = 14;
            cmbOdemeYontemi.SelectedIndexChanged += cmbOdemeYontemi_SelectedIndexChanged;
            // 
            // txtKartNo
            // 
            txtKartNo.Font = new Font("Segoe UI", 12F);
            txtKartNo.Location = new Point(525, 490);
            txtKartNo.Name = "txtKartNo";
            txtKartNo.Size = new Size(179, 34);
            txtKartNo.TabIndex = 15;
            txtKartNo.Visible = false;
            // 
            // labelKart
            // 
            labelKart.AutoSize = true;
            labelKart.BackColor = Color.Transparent;
            labelKart.Font = new Font("Segoe UI", 12F);
            labelKart.ForeColor = SystemColors.HighlightText;
            labelKart.Location = new Point(416, 493);
            labelKart.Name = "labelKart";
            labelKart.Size = new Size(80, 28);
            labelKart.TabIndex = 16;
            labelKart.Text = "Kart No";
            labelKart.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = SystemColors.HighlightText;
            label9.Location = new Point(416, 427);
            label9.Name = "label9";
            label9.Size = new Size(217, 28);
            label9.TabIndex = 17;
            label9.Text = "Ödeme Yöntemi Seçiniz";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label10.ForeColor = SystemColors.HighlightText;
            label10.Location = new Point(50, 33);
            label10.Name = "label10";
            label10.Size = new Size(124, 31);
            label10.TabIndex = 18;
            label10.Text = "Film İsmi :";
            // 
            // SinemaBiletSistemi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ChatGPT_Image_22_Ara_2025_02_56_58;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(992, 580);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(labelKart);
            Controls.Add(txtKartNo);
            Controls.Add(cmbOdemeYontemi);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SinemaBiletSistemi";
            Text = "SinemaBiletSistemi";
            Load += SinemaBiletSistemi_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrMisirAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrIcecekAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox2;
        private Button button1;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private Label label7;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label8;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        public Label label1;
        public Label label2;
        private Button button4;
        private ComboBox cmbOdemeYontemi;
        private TextBox txtKartNo;
        private Label labelKart;
        private NumericUpDown nmrMisirAdet;
        private NumericUpDown nmrIcecekAdet;
        private Label label9;
        public Label label10;
    }
}