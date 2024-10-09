namespace Museu_Pim.Formularios
{
    partial class Exposicoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exposicoes));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            desinButtons1 = new Modulos.DesinButtons();
            Btn_formulario = new Modulos.DesinButtons();
            Btn_Home = new Modulos.DesinButtons();
            Btn_Proxima = new Modulos.DesinButtons();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Neil_Armstrong_postcard;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(824, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(428, 631);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(33, 155);
            label1.Name = "label1";
            label1.Size = new Size(688, 310);
            label1.TabIndex = 2;
            label1.Text = resources.GetString("label1.Text");
            // 
            // desinButtons1
            // 
            desinButtons1.BackColor = Color.MediumSlateBlue;
            desinButtons1.FlatAppearance.BorderSize = 0;
            desinButtons1.FlatStyle = FlatStyle.Flat;
            desinButtons1.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            desinButtons1.ForeColor = Color.White;
            desinButtons1.Location = new Point(103, 25);
            desinButtons1.Name = "desinButtons1";
            desinButtons1.Size = new Size(500, 67);
            desinButtons1.TabIndex = 6;
            desinButtons1.Text = "História";
            desinButtons1.UseVisualStyleBackColor = false;
            // 
            // Btn_formulario
            // 
            Btn_formulario.BackColor = Color.MediumSlateBlue;
            Btn_formulario.FlatAppearance.BorderSize = 0;
            Btn_formulario.FlatStyle = FlatStyle.Flat;
            Btn_formulario.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_formulario.ForeColor = Color.White;
            Btn_formulario.Location = new Point(242, 616);
            Btn_formulario.Name = "Btn_formulario";
            Btn_formulario.Size = new Size(224, 54);
            Btn_formulario.TabIndex = 9;
            Btn_formulario.Text = "Formulário";
            Btn_formulario.UseVisualStyleBackColor = false;
            Btn_formulario.Click += Btn_formulario_Click;
            // 
            // Btn_Home
            // 
            Btn_Home.BackColor = Color.MediumSlateBlue;
            Btn_Home.FlatAppearance.BorderSize = 0;
            Btn_Home.FlatStyle = FlatStyle.Flat;
            Btn_Home.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Home.ForeColor = Color.White;
            Btn_Home.Location = new Point(12, 616);
            Btn_Home.Name = "Btn_Home";
            Btn_Home.Size = new Size(224, 54);
            Btn_Home.TabIndex = 10;
            Btn_Home.Text = "Home";
            Btn_Home.UseVisualStyleBackColor = false;
            Btn_Home.Click += Btn_Home_Click;
            // 
            // Btn_Proxima
            // 
            Btn_Proxima.BackColor = Color.MediumSlateBlue;
            Btn_Proxima.FlatAppearance.BorderSize = 0;
            Btn_Proxima.FlatStyle = FlatStyle.Flat;
            Btn_Proxima.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Proxima.ForeColor = Color.White;
            Btn_Proxima.Location = new Point(472, 616);
            Btn_Proxima.Name = "Btn_Proxima";
            Btn_Proxima.Size = new Size(283, 54);
            Btn_Proxima.TabIndex = 11;
            Btn_Proxima.Text = "Próxima Obra";
            Btn_Proxima.UseVisualStyleBackColor = false;
            Btn_Proxima.Click += Btn_Proxima_Click;
            // 
            // Exposicoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1284, 711);
            ControlBox = false;
            Controls.Add(Btn_Proxima);
            Controls.Add(Btn_Home);
            Controls.Add(Btn_formulario);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(desinButtons1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Exposicoes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exposicoes";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Modulos.DesinButtons desinButtons1;
        private Modulos.DesinButtons desinButtons2;
        private Modulos.DesinButtons desinButtons3;
        private Modulos.DesinButtons Btn_formulario;
        private Modulos.DesinButtons Btn_Home;
        private Modulos.DesinButtons Btn_Proxima;
    }
}