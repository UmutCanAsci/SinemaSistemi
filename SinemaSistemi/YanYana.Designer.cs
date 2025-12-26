namespace SinemaSistemi
{
    partial class YanYana
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
            lblSuree = new Label();
            lblTur = new Label();
            lblVizyon = new Label();
            lblOyuncular = new Label();
            lblFilmAdi = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.yanyana;
            pictureBox1.Location = new Point(50, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 364);
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
            lblYonetmen.Location = new Point(394, 134);
            lblYonetmen.Name = "lblYonetmen";
            lblYonetmen.Size = new Size(119, 28);
            lblYonetmen.TabIndex = 1;
            lblYonetmen.Text = "Film Bilgileri";
            lblYonetmen.Click += lblYonetmen_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Black;
            button1.Image = Properties.Resources.director;
            button1.Location = new Point(730, 213);
            button1.Name = "button1";
            button1.Size = new Size(111, 87);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Image = Properties.Resources.undo;
            button2.Location = new Point(730, 117);
            button2.Name = "button2";
            button2.Size = new Size(111, 90);
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
            lblSure.Location = new Point(394, 179);
            lblSure.Name = "lblSure";
            lblSure.Size = new Size(119, 28);
            lblSure.TabIndex = 4;
            lblSure.Text = "Film Bilgileri";
            lblSure.Click += lblSure_Click;
            // 
            // lblSuree
            // 
            lblSuree.AutoSize = true;
            lblSuree.BackColor = Color.Transparent;
            lblSuree.Font = new Font("Segoe UI", 12F);
            lblSuree.ForeColor = Color.White;
            lblSuree.Location = new Point(394, 224);
            lblSuree.Name = "lblSuree";
            lblSuree.Size = new Size(119, 28);
            lblSuree.TabIndex = 5;
            lblSuree.Text = "Film Bilgileri";
            // 
            // lblTur
            // 
            lblTur.AutoSize = true;
            lblTur.BackColor = Color.Transparent;
            lblTur.Font = new Font("Segoe UI", 12F);
            lblTur.ForeColor = Color.White;
            lblTur.Location = new Point(394, 263);
            lblTur.Name = "lblTur";
            lblTur.Size = new Size(119, 28);
            lblTur.TabIndex = 6;
            lblTur.Text = "Film Bilgileri";
            // 
            // lblVizyon
            // 
            lblVizyon.AutoSize = true;
            lblVizyon.BackColor = Color.Transparent;
            lblVizyon.Font = new Font("Segoe UI", 12F);
            lblVizyon.ForeColor = Color.White;
            lblVizyon.Location = new Point(394, 303);
            lblVizyon.Name = "lblVizyon";
            lblVizyon.Size = new Size(65, 28);
            lblVizyon.TabIndex = 7;
            lblVizyon.Text = "label1";
            lblVizyon.Click += lblVizyon_Click;
            // 
            // lblOyuncular
            // 
            lblOyuncular.BackColor = Color.Transparent;
            lblOyuncular.Font = new Font("Segoe UI", 12F);
            lblOyuncular.ForeColor = Color.White;
            lblOyuncular.Location = new Point(394, 347);
            lblOyuncular.Name = "lblOyuncular";
            lblOyuncular.Size = new Size(233, 72);
            lblOyuncular.TabIndex = 8;
            lblOyuncular.Text = "label1";
            // 
            // lblFilmAdi
            // 
            lblFilmAdi.AutoSize = true;
            lblFilmAdi.BackColor = Color.Transparent;
            lblFilmAdi.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFilmAdi.ForeColor = Color.White;
            lblFilmAdi.Location = new Point(394, 82);
            lblFilmAdi.Name = "lblFilmAdi";
            lblFilmAdi.Size = new Size(99, 38);
            lblFilmAdi.TabIndex = 9;
            lblFilmAdi.Text = "label1";
            // 
            // YanYana
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = Properties.Resources.ChatGPT_Image_22_Ara_2025_02_22_56;
            ClientSize = new Size(967, 508);
            Controls.Add(lblFilmAdi);
            Controls.Add(lblOyuncular);
            Controls.Add(lblVizyon);
            Controls.Add(lblTur);
            Controls.Add(lblSuree);
            Controls.Add(lblSure);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblYonetmen);
            Controls.Add(pictureBox1);
            Name = "YanYana";
            Text = "YanYana";
            Load += YanYana_Load;
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
        private Label lblSuree;
        private Label lblTur;
        private Label lblVizyon;
        private Label lblOyuncular;
        private Label lblFilmAdi;
    }
}