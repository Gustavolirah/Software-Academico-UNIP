namespace Museu_Pim.Formularios
{
    partial class Formulariosquiz
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
            Conhe = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Btn_Questionario = new Modulos.DesinButtons();
            Btn_feedback = new Modulos.DesinButtons();
            Btn_home = new Modulos.DesinButtons();
            Btn_ralatorios = new Modulos.DesinButtons();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Conhe
            // 
            Conhe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Conhe.AutoSize = true;
            Conhe.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Conhe.ForeColor = Color.MediumSlateBlue;
            Conhe.Location = new Point(261, 185);
            Conhe.Name = "Conhe";
            Conhe.Size = new Size(704, 87);
            Conhe.TabIndex = 3;
            Conhe.Text = "Agora que você ja visualizou nossas obras venha descobrir \r\nseu conhecimento seu aprendizado e deixar seu feedback \r\n    sobre nosso museu\r\n";
            Conhe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Lua_Primeiro_quarto_First_quarter_moon;
            pictureBox1.Location = new Point(866, -40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(429, 531);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.AMOLED_Space_Wallpaper_21___Fondos_de_pantalla_de_iphone__Fotos_de_la_tierra__Imagenes_abstractas;
            pictureBox2.Location = new Point(0, 328);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(433, 401);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Btn_Questionario
            // 
            Btn_Questionario.BackColor = Color.MediumSlateBlue;
            Btn_Questionario.FlatAppearance.BorderSize = 0;
            Btn_Questionario.FlatStyle = FlatStyle.Flat;
            Btn_Questionario.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Questionario.ForeColor = Color.White;
            Btn_Questionario.Location = new Point(526, 356);
            Btn_Questionario.Name = "Btn_Questionario";
            Btn_Questionario.Size = new Size(210, 52);
            Btn_Questionario.TabIndex = 7;
            Btn_Questionario.Text = "Inicie o Questionário";
            Btn_Questionario.UseVisualStyleBackColor = false;
            Btn_Questionario.Click += Btn_Questionario_Click;
            // 
            // Btn_feedback
            // 
            Btn_feedback.BackColor = Color.MediumSlateBlue;
            Btn_feedback.FlatAppearance.BorderSize = 0;
            Btn_feedback.FlatStyle = FlatStyle.Flat;
            Btn_feedback.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_feedback.ForeColor = Color.White;
            Btn_feedback.Location = new Point(526, 424);
            Btn_feedback.Name = "Btn_feedback";
            Btn_feedback.Size = new Size(210, 52);
            Btn_feedback.TabIndex = 8;
            Btn_feedback.Text = "Feedback";
            Btn_feedback.UseVisualStyleBackColor = false;
            Btn_feedback.Click += Btn_feedback_Click;
            // 
            // Btn_home
            // 
            Btn_home.BackColor = Color.MediumSlateBlue;
            Btn_home.FlatAppearance.BorderSize = 0;
            Btn_home.FlatStyle = FlatStyle.Flat;
            Btn_home.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_home.ForeColor = Color.White;
            Btn_home.Location = new Point(526, 560);
            Btn_home.Name = "Btn_home";
            Btn_home.Size = new Size(210, 52);
            Btn_home.TabIndex = 10;
            Btn_home.Text = "Home";
            Btn_home.UseVisualStyleBackColor = false;
            Btn_home.Click += Btn_home_Click;
            // 
            // Btn_ralatorios
            // 
            Btn_ralatorios.BackColor = Color.MediumSlateBlue;
            Btn_ralatorios.FlatAppearance.BorderSize = 0;
            Btn_ralatorios.FlatStyle = FlatStyle.Flat;
            Btn_ralatorios.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_ralatorios.ForeColor = Color.White;
            Btn_ralatorios.Location = new Point(526, 493);
            Btn_ralatorios.Name = "Btn_ralatorios";
            Btn_ralatorios.Size = new Size(210, 52);
            Btn_ralatorios.TabIndex = 11;
            Btn_ralatorios.Text = "Relatório";
            Btn_ralatorios.UseVisualStyleBackColor = false;
            Btn_ralatorios.Click += Btn_ralatorios_Click;
            // 
            // Formulariosquiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1284, 711);
            ControlBox = false;
            Controls.Add(Btn_ralatorios);
            Controls.Add(Btn_home);
            Controls.Add(Btn_feedback);
            Controls.Add(Btn_Questionario);
            Controls.Add(pictureBox2);
            Controls.Add(Conhe);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formulariosquiz";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formularios";
            WindowState = FormWindowState.Maximized;
            Load += Formularios_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Qustionarios;
        private Button Btn_Relatorio;
        private Button Btn_Voltar_Home;
        private Label Conhe;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button Brn_Feeadback;
        private Modulos.DesinButtons Btn_Questionario;
        private Modulos.DesinButtons Btn_feedback;
        private Modulos.DesinButtons Btn_home;
        private Modulos.DesinButtons Btn_ralatorios;
    }
}