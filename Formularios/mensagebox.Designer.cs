namespace Museu_Pim.Formularios
{
    partial class mensagebox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mensagebox));
            lbl_pontuaçao = new Label();
            Lbl_porcentagem = new Label();
            Lbl_totalmedia = new Label();
            panel1 = new Panel();
            desinButtons1 = new Modulos.DesinButtons();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_pontuaçao
            // 
            lbl_pontuaçao.AutoSize = true;
            lbl_pontuaçao.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            lbl_pontuaçao.ForeColor = SystemColors.ButtonFace;
            lbl_pontuaçao.Location = new Point(407, 12);
            lbl_pontuaçao.Name = "lbl_pontuaçao";
            lbl_pontuaçao.Size = new Size(68, 29);
            lbl_pontuaçao.TabIndex = 1;
            lbl_pontuaçao.Text = "label2";
            // 
            // Lbl_porcentagem
            // 
            Lbl_porcentagem.AutoSize = true;
            Lbl_porcentagem.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            Lbl_porcentagem.ForeColor = SystemColors.ButtonFace;
            Lbl_porcentagem.Location = new Point(407, 54);
            Lbl_porcentagem.Name = "Lbl_porcentagem";
            Lbl_porcentagem.Size = new Size(68, 29);
            Lbl_porcentagem.TabIndex = 5;
            Lbl_porcentagem.Text = "label2";
            // 
            // Lbl_totalmedia
            // 
            Lbl_totalmedia.AutoSize = true;
            Lbl_totalmedia.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            Lbl_totalmedia.ForeColor = SystemColors.ButtonFace;
            Lbl_totalmedia.Location = new Point(407, 101);
            Lbl_totalmedia.Name = "Lbl_totalmedia";
            Lbl_totalmedia.Size = new Size(68, 29);
            Lbl_totalmedia.TabIndex = 7;
            Lbl_totalmedia.Text = "label2";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Location = new Point(0, 277);
            panel1.Name = "panel1";
            panel1.Size = new Size(1046, 45);
            panel1.TabIndex = 8;
            // 
            // desinButtons1
            // 
            desinButtons1.BackColor = Color.MediumSlateBlue;
            desinButtons1.FlatAppearance.BorderSize = 0;
            desinButtons1.FlatStyle = FlatStyle.Flat;
            desinButtons1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            desinButtons1.ForeColor = Color.White;
            desinButtons1.Location = new Point(454, 213);
            desinButtons1.Name = "desinButtons1";
            desinButtons1.Size = new Size(242, 48);
            desinButtons1.TabIndex = 13;
            desinButtons1.Text = "OK";
            desinButtons1.UseVisualStyleBackColor = false;
            desinButtons1.Click += desinButtons1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(481, 259);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // mensagebox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(822, 312);
            Controls.Add(desinButtons1);
            Controls.Add(Lbl_totalmedia);
            Controls.Add(Lbl_porcentagem);
            Controls.Add(lbl_pontuaçao);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mensagebox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mensagebox";
            TopMost = true;
            Load += mensagebox_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_pontuaçao;
        private Label Lbl_Media;
        private Label label3;
        private Label Lbl_porcentagem;
        private Label label5;
        private Label Lbl_totalmedia;
        private Label label7;
        private Panel panel1;
        private Label label2;
        private Label label4;
        private Label label6;
        private Modulos.DesinButtons desinButtons1;
        private PictureBox pictureBox1;
        private Label label8;
    }
}