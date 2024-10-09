namespace Museu_Pim.Formularios
{
    partial class Bibliografia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bibliografia));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Btn_titulo = new Modulos.DesinButtons();
            Btn_formularios = new Modulos.DesinButtons();
            Btn_Home = new Modulos.DesinButtons();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(32, 133);
            label1.Name = "label1";
            label1.Size = new Size(568, 440);
            label1.TabIndex = 8;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(881, 170);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 9;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(636, 142);
            label3.Name = "label3";
            label3.Size = new Size(602, 220);
            label3.TabIndex = 10;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(636, 399);
            label4.Name = "label4";
            label4.Size = new Size(612, 100);
            label4.TabIndex = 11;
            label4.Text = resources.GetString("label4.Text");
            // 
            // Btn_titulo
            // 
            Btn_titulo.BackColor = Color.MediumSlateBlue;
            Btn_titulo.FlatAppearance.BorderSize = 0;
            Btn_titulo.FlatStyle = FlatStyle.Flat;
            Btn_titulo.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_titulo.ForeColor = Color.White;
            Btn_titulo.Location = new Point(360, 24);
            Btn_titulo.Name = "Btn_titulo";
            Btn_titulo.Size = new Size(487, 73);
            Btn_titulo.TabIndex = 14;
            Btn_titulo.Text = "Bibliografia";
            Btn_titulo.UseVisualStyleBackColor = false;
            // 
            // Btn_formularios
            // 
            Btn_formularios.BackColor = Color.MediumSlateBlue;
            Btn_formularios.FlatAppearance.BorderSize = 0;
            Btn_formularios.FlatStyle = FlatStyle.Flat;
            Btn_formularios.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_formularios.ForeColor = Color.White;
            Btn_formularios.Location = new Point(636, 600);
            Btn_formularios.Name = "Btn_formularios";
            Btn_formularios.Size = new Size(278, 72);
            Btn_formularios.TabIndex = 15;
            Btn_formularios.Text = "Formuláios";
            Btn_formularios.UseVisualStyleBackColor = false;
            Btn_formularios.Click += Btn_formularios_Click;
            // 
            // Btn_Home
            // 
            Btn_Home.BackColor = Color.MediumSlateBlue;
            Btn_Home.FlatAppearance.BorderSize = 0;
            Btn_Home.FlatStyle = FlatStyle.Flat;
            Btn_Home.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Home.ForeColor = Color.White;
            Btn_Home.Location = new Point(322, 600);
            Btn_Home.Name = "Btn_Home";
            Btn_Home.Size = new Size(278, 72);
            Btn_Home.TabIndex = 16;
            Btn_Home.Text = "Home";
            Btn_Home.UseVisualStyleBackColor = false;
            Btn_Home.Click += Btn_Home_Click;
            // 
            // Bibliografia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1284, 711);
            ControlBox = false;
            Controls.Add(Btn_Home);
            Controls.Add(Btn_formularios);
            Controls.Add(Btn_titulo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Bibliografia";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bibliografia";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Modulos.DesinButtons Btn_titulo;
        private Modulos.DesinButtons Btn_formularios;
        private Modulos.DesinButtons Btn_Home;
    }
}