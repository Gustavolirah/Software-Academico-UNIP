namespace Museu_Pim.Formularios
{
    partial class Relatorio
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Sobrenome = new DataGridViewTextBoxColumn();
            Idade = new DataGridViewTextBoxColumn();
            Feedback = new DataGridViewTextBoxColumn();
            label1 = new Label();
            Btn_home = new Modulos.DesinButtons();
            Btn_formularios = new Modulos.DesinButtons();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.MediumSlateBlue;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Indigo;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, Sobrenome, Idade, Feedback });
            dataGridView1.GridColor = Color.DarkSlateBlue;
            dataGridView1.Location = new Point(39, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 128, 255);
            dataGridViewCellStyle6.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.Indigo;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(64, 0, 64);
            dataGridViewCellStyle7.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(64, 0, 64);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.Size = new Size(1213, 439);
            dataGridView1.TabIndex = 0;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 0, 64);
            Nome.DefaultCellStyle = dataGridViewCellStyle2;
            Nome.DividerWidth = 10;
            Nome.HeaderText = "Nome";
            Nome.MaxInputLength = 200;
            Nome.MinimumWidth = 10;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 225;
            // 
            // Sobrenome
            // 
            Sobrenome.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(64, 0, 64);
            Sobrenome.DefaultCellStyle = dataGridViewCellStyle3;
            Sobrenome.DividerWidth = 10;
            Sobrenome.HeaderText = "Sobrenome";
            Sobrenome.MinimumWidth = 10;
            Sobrenome.Name = "Sobrenome";
            Sobrenome.ReadOnly = true;
            Sobrenome.Width = 200;
            // 
            // Idade
            // 
            Idade.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle4.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(64, 0, 64);
            Idade.DefaultCellStyle = dataGridViewCellStyle4;
            Idade.DividerWidth = 10;
            Idade.HeaderText = "Idade";
            Idade.MinimumWidth = 10;
            Idade.Name = "Idade";
            Idade.ReadOnly = true;
            Idade.Width = 200;
            // 
            // Feedback
            // 
            Feedback.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle5.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(64, 0, 64);
            Feedback.DefaultCellStyle = dataGridViewCellStyle5;
            Feedback.DividerWidth = 50;
            Feedback.HeaderText = "Feedback";
            Feedback.MinimumWidth = 50;
            Feedback.Name = "Feedback";
            Feedback.ReadOnly = true;
            Feedback.Width = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(527, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 42);
            label1.TabIndex = 1;
            label1.Text = "Relatório";
            label1.Click += label1_Click;
            // 
            // Btn_home
            // 
            Btn_home.BackColor = Color.MediumSlateBlue;
            Btn_home.FlatAppearance.BorderSize = 0;
            Btn_home.FlatStyle = FlatStyle.Flat;
            Btn_home.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_home.ForeColor = Color.White;
            Btn_home.Location = new Point(323, 608);
            Btn_home.Name = "Btn_home";
            Btn_home.Size = new Size(236, 57);
            Btn_home.TabIndex = 2;
            Btn_home.Text = "Home";
            Btn_home.UseVisualStyleBackColor = false;
            Btn_home.Click += Btn_home_Click;
            // 
            // Btn_formularios
            // 
            Btn_formularios.BackColor = Color.MediumSlateBlue;
            Btn_formularios.FlatAppearance.BorderSize = 0;
            Btn_formularios.FlatStyle = FlatStyle.Flat;
            Btn_formularios.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_formularios.ForeColor = Color.White;
            Btn_formularios.Location = new Point(644, 608);
            Btn_formularios.Name = "Btn_formularios";
            Btn_formularios.Size = new Size(236, 57);
            Btn_formularios.TabIndex = 3;
            Btn_formularios.Text = "Formulários";
            Btn_formularios.UseVisualStyleBackColor = false;
            Btn_formularios.Click += Btn_formularios_Click;
            // 
            // Relatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1284, 711);
            Controls.Add(Btn_formularios);
            Controls.Add(Btn_home);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Relatorio";
            Text = "Relatorio";
            WindowState = FormWindowState.Maximized;
            Load += Relatorio_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Modulos.DesinButtons Btn_home;
        private Modulos.DesinButtons Btn_formularios;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Sobrenome;
        private DataGridViewTextBoxColumn Idade;
        private DataGridViewTextBoxColumn Feedback;
    }
}