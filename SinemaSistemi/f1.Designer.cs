namespace SinemaSistemi
{
    partial class f1
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
            button1 = new Button();
            button2 = new Button();
            lblOyuncular = new Label();
            lblVizyon = new Label();
            lblTur = new Label();
            lblSure = new Label();
            lblYonetmen = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.f1_filmi_2025620114413b86557b650264179ac3e71d4f42310dc1;
            pictureBox1.Location = new Point(34, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Transparent;
            button1.Image = Properties.Resources.director;
            button1.Location = new Point(623, 188);
            button1.Name = "button1";
            button1.Size = new Size(94, 74);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.undo1;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.DialogResult = DialogResult.Yes;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(623, 98);
            button2.Name = "button2";
            button2.Size = new Size(94, 81);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblOyuncular
            // 
            lblOyuncular.BackColor = Color.Transparent;
            lblOyuncular.Font = new Font("Segoe UI", 12F);
            lblOyuncular.ForeColor = Color.White;
            lblOyuncular.Location = new Point(318, 271);
            lblOyuncular.Name = "lblOyuncular";
            lblOyuncular.Size = new Size(205, 70);
            lblOyuncular.TabIndex = 14;
            lblOyuncular.Text = "label5";
            // 
            // lblVizyon
            // 
            lblVizyon.AutoSize = true;
            lblVizyon.BackColor = Color.Transparent;
            lblVizyon.Font = new Font("Segoe UI", 12F);
            lblVizyon.ForeColor = Color.White;
            lblVizyon.Location = new Point(318, 227);
            lblVizyon.Name = "lblVizyon";
            lblVizyon.Size = new Size(65, 28);
            lblVizyon.TabIndex = 13;
            lblVizyon.Text = "label4";
            // 
            // lblTur
            // 
            lblTur.AutoSize = true;
            lblTur.BackColor = Color.Transparent;
            lblTur.Font = new Font("Segoe UI", 12F);
            lblTur.ForeColor = Color.White;
            lblTur.Location = new Point(318, 180);
            lblTur.Name = "lblTur";
            lblTur.Size = new Size(65, 28);
            lblTur.TabIndex = 12;
            lblTur.Text = "label3";
            // 
            // lblSure
            // 
            lblSure.AutoSize = true;
            lblSure.BackColor = Color.Transparent;
            lblSure.Font = new Font("Segoe UI", 12F);
            lblSure.ForeColor = Color.White;
            lblSure.Location = new Point(318, 140);
            lblSure.Name = "lblSure";
            lblSure.Size = new Size(65, 28);
            lblSure.TabIndex = 11;
            lblSure.Text = "label2";
            // 
            // lblYonetmen
            // 
            lblYonetmen.AutoSize = true;
            lblYonetmen.BackColor = Color.Transparent;
            lblYonetmen.Font = new Font("Segoe UI", 12F);
            lblYonetmen.ForeColor = Color.White;
            lblYonetmen.Location = new Point(318, 101);
            lblYonetmen.Name = "lblYonetmen";
            lblYonetmen.Size = new Size(45, 28);
            lblYonetmen.TabIndex = 9;
            lblYonetmen.Text = "text";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(318, 45);
            label1.Name = "label1";
            label1.Size = new Size(48, 38);
            label1.TabIndex = 15;
            label1.Text = "F1";
            // 
            // f1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ChatGPT_Image_22_Ara_2025_02_22_56;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblOyuncular);
            Controls.Add(lblVizyon);
            Controls.Add(lblTur);
            Controls.Add(lblSure);
            Controls.Add(lblYonetmen);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "f1";
            Text = "f1";
            Load += f1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Label lblOyuncular;
        private Label lblVizyon;
        private Label lblTur;
        private Label lblSure;
        private Label lblYonetmen;
        private Label label1;
    }
}