namespace Museu_Pim.Modulos
{
    partial class msgerrofeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(msgerrofeedback));
            panel1 = new Panel();
            desinButtons1 = new DesinButtons();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 214);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 19);
            panel1.TabIndex = 0;
            // 
            // desinButtons1
            // 
            desinButtons1.BackColor = Color.MediumSlateBlue;
            desinButtons1.FlatAppearance.BorderSize = 0;
            desinButtons1.FlatStyle = FlatStyle.Flat;
            desinButtons1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            desinButtons1.ForeColor = Color.White;
            desinButtons1.Location = new Point(399, 154);
            desinButtons1.Name = "desinButtons1";
            desinButtons1.Size = new Size(215, 44);
            desinButtons1.TabIndex = 1;
            desinButtons1.Text = "OK";
            desinButtons1.UseVisualStyleBackColor = false;
            desinButtons1.Click += desinButtons1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(319, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 50);
            label1.TabIndex = 2;
            label1.Text = "Erro!";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(319, 98);
            label2.Name = "label2";
            label2.Size = new Size(338, 25);
            label2.TabIndex = 3;
            label2.Text = "Por Favor Digite Informações Corretas";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // msgerrofeedback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(688, 233);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(desinButtons1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "msgerrofeedback";
            Text = "msgerrofeedback";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DesinButtons desinButtons1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}