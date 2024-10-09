namespace Museu_Pim.Modulos
{
    partial class msgfeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(msgfeedback));
            desinButtons1 = new DesinButtons();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // desinButtons1
            // 
            desinButtons1.BackColor = Color.MediumSlateBlue;
            desinButtons1.FlatAppearance.BorderSize = 0;
            desinButtons1.FlatStyle = FlatStyle.Flat;
            desinButtons1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            desinButtons1.ForeColor = Color.White;
            desinButtons1.Location = new Point(325, 145);
            desinButtons1.Name = "desinButtons1";
            desinButtons1.Size = new Size(205, 45);
            desinButtons1.TabIndex = 0;
            desinButtons1.Text = "OK";
            desinButtons1.UseVisualStyleBackColor = false;
            desinButtons1.Click += desinButtons1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 210);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 23);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Aquamarine;
            label1.Location = new Point(277, 15);
            label1.Name = "label1";
            label1.Size = new Size(183, 37);
            label1.TabIndex = 2;
            label1.Text = "Concluido!";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Aquamarine;
            label2.Location = new Point(275, 91);
            label2.Name = "label2";
            label2.Size = new Size(333, 25);
            label2.TabIndex = 3;
            label2.Text = "O Feedback foi Enviado com Sucesso";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-76, -43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 316);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // msgfeedback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(608, 233);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(desinButtons1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "msgfeedback";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += msgfeedback_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DesinButtons desinButtons1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}