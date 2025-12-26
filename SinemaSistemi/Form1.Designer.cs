namespace SinemaSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(388, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 289);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Üye Ol";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.ForeColor = SystemColors.Control;
            button2.Image = Properties.Resources.smile_plus__2_;
            button2.Location = new Point(281, 227);
            button2.Name = "button2";
            button2.Size = new Size(94, 46);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tam", "Öğrenci" });
            comboBox1.Location = new Point(250, 185);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 36);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Image = Properties.Resources.customer;
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(29, 188);
            label5.Name = "label5";
            label5.Size = new Size(147, 28);
            label5.TabIndex = 12;
            label5.Text = "     Kullanıcı Tipi";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 12F);
            textBox6.Location = new Point(250, 137);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 34);
            textBox6.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Image = Properties.Resources.phone_call;
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(29, 140);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 10;
            label6.Text = "     Telefon";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(250, 85);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 34);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.Location = new Point(250, 37);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 34);
            textBox4.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Image = Properties.Resources.lock__1_;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(29, 88);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 8;
            label3.Text = "     Şifre";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Image = Properties.Resources.id_card__3_;
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(29, 48);
            label4.Name = "label4";
            label4.Size = new Size(145, 28);
            label4.TabIndex = 6;
            label4.Text = "     Kullanıcı Adı";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(28, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(344, 188);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giriş Yap";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Image = Properties.Resources.user_trust;
            button1.Location = new Point(223, 130);
            button1.Name = "button1";
            button1.Size = new Size(105, 45);
            button1.TabIndex = 4;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Image = Properties.Resources.id_card__3_;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(20, 45);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 0;
            label1.Text = "     Kullanıcı Adı";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(186, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 34);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(186, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 34);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Image = Properties.Resources.lock__1_;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(20, 82);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 2;
            label2.Text = "     Şifre";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            BackgroundImage = Properties.Resources.ChatGPT_Image_22_Ara_2025_01_59_14;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(798, 489);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private Button button2;
        public ComboBox comboBox1;
        private GroupBox groupBox2;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
    }
}
