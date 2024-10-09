namespace Museu_Pim.Formularios
{
    partial class MissaoApolo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MissaoApolo));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            desinButtons1 = new Modulos.DesinButtons();
            Btn_home = new Modulos.DesinButtons();
            Btn_formulario = new Modulos.DesinButtons();
            Btn_proxima = new Modulos.DesinButtons();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(443, 96);
            label1.Name = "label1";
            label1.Size = new Size(808, 434);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Apollo_11_Photos_and_Premium_High_Res_Pictures;
            pictureBox1.Location = new Point(29, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(408, 579);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // desinButtons1
            // 
            desinButtons1.BackColor = Color.MediumSlateBlue;
            desinButtons1.FlatAppearance.BorderSize = 0;
            desinButtons1.FlatStyle = FlatStyle.Flat;
            desinButtons1.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            desinButtons1.ForeColor = Color.White;
            desinButtons1.Location = new Point(29, 26);
            desinButtons1.Name = "desinButtons1";
            desinButtons1.Size = new Size(399, 54);
            desinButtons1.TabIndex = 10;
            desinButtons1.Text = "Missão Apollo";
            desinButtons1.UseVisualStyleBackColor = false;
            // 
            // Btn_home
            // 
            Btn_home.BackColor = Color.MediumSlateBlue;
            Btn_home.FlatAppearance.BorderSize = 0;
            Btn_home.FlatStyle = FlatStyle.Flat;
            Btn_home.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_home.ForeColor = Color.White;
            Btn_home.Location = new Point(467, 645);
            Btn_home.Name = "Btn_home";
            Btn_home.Size = new Size(260, 54);
            Btn_home.TabIndex = 11;
            Btn_home.Text = "Home";
            Btn_home.UseVisualStyleBackColor = false;
            Btn_home.Click += Btn_home_Click_1;
            // 
            // Btn_formulario
            // 
            Btn_formulario.BackColor = Color.MediumSlateBlue;
            Btn_formulario.FlatAppearance.BorderSize = 0;
            Btn_formulario.FlatStyle = FlatStyle.Flat;
            Btn_formulario.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_formulario.ForeColor = Color.White;
            Btn_formulario.Location = new Point(733, 645);
            Btn_formulario.Name = "Btn_formulario";
            Btn_formulario.Size = new Size(260, 54);
            Btn_formulario.TabIndex = 12;
            Btn_formulario.Text = "Formulário";
            Btn_formulario.UseVisualStyleBackColor = false;
            Btn_formulario.Click += Btn_formulario_Click_1;
            // 
            // Btn_proxima
            // 
            Btn_proxima.BackColor = Color.MediumSlateBlue;
            Btn_proxima.FlatAppearance.BorderSize = 0;
            Btn_proxima.FlatStyle = FlatStyle.Flat;
            Btn_proxima.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_proxima.ForeColor = Color.White;
            Btn_proxima.Location = new Point(999, 645);
            Btn_proxima.Name = "Btn_proxima";
            Btn_proxima.Size = new Size(260, 54);
            Btn_proxima.TabIndex = 13;
            Btn_proxima.Text = "Próxima Obra";
            Btn_proxima.UseVisualStyleBackColor = false;
            Btn_proxima.Click += Btn_proxima_Click;
            // 
            // MissaoApolo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1284, 711);
            ControlBox = false;
            Controls.Add(Btn_proxima);
            Controls.Add(Btn_formulario);
            Controls.Add(Btn_home);
            Controls.Add(desinButtons1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MissaoApolo";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Missao Apollo";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_formulario;
        private Button Btn_ProximaObra;
        private Modulos.DesinButtons desinButtons1;
        private Modulos.DesinButtons Btn_home;
        private Modulos.DesinButtons Btn_formulario;
        private Modulos.DesinButtons Btn_proxima;
    }
}