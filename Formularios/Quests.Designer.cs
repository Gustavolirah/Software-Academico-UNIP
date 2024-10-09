namespace Museu_Pim.Modulos
{
    partial class Quests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quests));
            pictureBox1 = new PictureBox();
            LblAtraçao = new Label();
            button1 = new DesinButtons();
            button2 = new DesinButtons();
            button3 = new DesinButtons();
            button4 = new DesinButtons();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(159, 41);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(631, 312);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LblAtraçao
            // 
            LblAtraçao.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAtraçao.ForeColor = Color.MediumPurple;
            LblAtraçao.Location = new Point(67, 355);
            LblAtraçao.Name = "LblAtraçao";
            LblAtraçao.Size = new Size(802, 52);
            LblAtraçao.TabIndex = 1;
            LblAtraçao.Text = "Atrações";
            LblAtraçao.TextAlign = ContentAlignment.MiddleCenter;
            LblAtraçao.Click += LblAtraçao_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSlateBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(69, 409);
            button1.Name = "button1";
            button1.Size = new Size(356, 56);
            button1.TabIndex = 9;
            button1.Tag = "1";
            button1.Text = "desinButtons1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Verificarevento;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSlateBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(499, 410);
            button2.Name = "button2";
            button2.Size = new Size(356, 56);
            button2.TabIndex = 10;
            button2.Tag = "2";
            button2.Text = "desinButtons2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Verificarevento;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSlateBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(69, 480);
            button3.Name = "button3";
            button3.Size = new Size(356, 56);
            button3.TabIndex = 11;
            button3.Tag = "3";
            button3.Text = "desinButtons3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Verificarevento;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumSlateBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(499, 480);
            button4.Name = "button4";
            button4.Size = new Size(356, 56);
            button4.TabIndex = 12;
            button4.Tag = "4";
            button4.Text = "desinButtons4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += Verificarevento;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(427, -2);
            label1.Name = "label1";
            label1.Size = new Size(92, 41);
            label1.TabIndex = 13;
            label1.Text = "Quiz";
            // 
            // Quests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(953, 552);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(LblAtraçao);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button4);
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Quests";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Questionario";
            Load += Quests_Load;
            Click += Verificarevento;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LblAtraçao;
        private DesinButtons button1;
        private DesinButtons button2;
        private DesinButtons button3;
        private DesinButtons button4;
        private Label label1;
    }
}