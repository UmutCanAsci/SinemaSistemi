namespace SinemaSistemi
{
    partial class Zootropolis2
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
            pictureBox1 = new PictureBox();
            lblYonetmen = new Label();
            button1 = new Button();
            button2 = new Button();
            lblSure = new Label();
            lblTur = new Label();
            lblVizyon = new Label();
            lblOyuncular = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.zootropolis_2;
            pictureBox1.Location = new Point(33, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 320);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblYonetmen
            // 
            lblYonetmen.AutoSize = true;
            lblYonetmen.BackColor = Color.Transparent;
            lblYonetmen.Font = new Font("Segoe UI", 12F);
            lblYonetmen.ForeColor = Color.White;
            lblYonetmen.Location = new Point(318, 96);
            lblYonetmen.Name = "lblYonetmen";
            lblYonetmen.Size = new Size(45, 28);
            lblYonetmen.TabIndex = 1;
            lblYonetmen.Text = "text";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = Properties.Resources.director;
            button1.Location = new Point(609, 197);
            button1.Name = "button1";
            button1.Size = new Size(111, 77);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Image = Properties.Resources.undo1;
            button2.Location = new Point(609, 96);
            button2.Name = "button2";
            button2.Size = new Size(111, 77);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblSure
            // 
            lblSure.AutoSize = true;
            lblSure.BackColor = Color.Transparent;
            lblSure.Font = new Font("Segoe UI", 12F);
            lblSure.ForeColor = Color.White;
            lblSure.Location = new Point(318, 138);
            lblSure.Name = "lblSure";
            lblSure.Size = new Size(65, 28);
            lblSure.TabIndex = 5;
            lblSure.Text = "label2";
            // 
            // lblTur
            // 
            lblTur.AutoSize = true;
            lblTur.BackColor = Color.Transparent;
            lblTur.Font = new Font("Segoe UI", 12F);
            lblTur.ForeColor = Color.White;
            lblTur.Location = new Point(318, 178);
            lblTur.Name = "lblTur";
            lblTur.Size = new Size(65, 28);
            lblTur.TabIndex = 6;
            lblTur.Text = "label3";
            // 
            // lblVizyon
            // 
            lblVizyon.AutoSize = true;
            lblVizyon.BackColor = Color.Transparent;
            lblVizyon.Font = new Font("Segoe UI", 12F);
            lblVizyon.ForeColor = Color.White;
            lblVizyon.Location = new Point(318, 225);
            lblVizyon.Name = "lblVizyon";
            lblVizyon.Size = new Size(65, 28);
            lblVizyon.TabIndex = 7;
            lblVizyon.Text = "label4";
            // 
            // lblOyuncular
            // 
            lblOyuncular.BackColor = Color.Transparent;
            lblOyuncular.Font = new Font("Segoe UI", 12F);
            lblOyuncular.ForeColor = Color.White;
            lblOyuncular.Location = new Point(318, 269);
            lblOyuncular.Name = "lblOyuncular";
            lblOyuncular.Size = new Size(205, 70);
            lblOyuncular.TabIndex = 8;
            lblOyuncular.Text = "label5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(318, 47);
            label1.Name = "label1";
            label1.Size = new Size(193, 38);
            label1.TabIndex = 9;
            label1.Text = "Zootropolis 2";
            // 
            // Zootropolis2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ChatGPT_Image_22_Ara_2025_02_22_561;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblOyuncular);
            Controls.Add(lblVizyon);
            Controls.Add(lblTur);
            Controls.Add(lblSure);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblYonetmen);
            Controls.Add(pictureBox1);
            Name = "Zootropolis2";
            Text = "Zootropolis2";
            Load += Zootropolis2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblYonetmen;
        private Button button1;
        private Button button2;
        private Label lblSure;
        private Label lblTur;
        private Label lblVizyon;
        private Label lblOyuncular;
        private Label label1;
    }
}