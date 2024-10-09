namespace Museu_Pim.Formularios
{
    partial class Home
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
            menuStrip1 = new MenuStrip();
            obrasToolStripMenuItem = new ToolStripMenuItem();
            exposiçõesToolStripMenuItem = new ToolStripMenuItem();
            formuláriosToolStripMenuItem = new ToolStripMenuItem();
            mapaMuseuToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            Btn_Historia = new Modulos.DesinButtons();
            Btn_Missao = new Modulos.DesinButtons();
            Btn_biografia = new Modulos.DesinButtons();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Indigo;
            menuStrip1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { obrasToolStripMenuItem, mapaMuseuToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1300, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // obrasToolStripMenuItem
            // 
            obrasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exposiçõesToolStripMenuItem, formuláriosToolStripMenuItem });
            obrasToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            obrasToolStripMenuItem.ImageTransparentColor = Color.MediumPurple;
            obrasToolStripMenuItem.Name = "obrasToolStripMenuItem";
            obrasToolStripMenuItem.Size = new Size(68, 27);
            obrasToolStripMenuItem.Text = "Obras";
            // 
            // exposiçõesToolStripMenuItem
            // 
            exposiçõesToolStripMenuItem.Name = "exposiçõesToolStripMenuItem";
            exposiçõesToolStripMenuItem.Size = new Size(172, 28);
            exposiçõesToolStripMenuItem.Text = "Exposições";
            exposiçõesToolStripMenuItem.Click += exposiçõesToolStripMenuItem_Click;
            // 
            // formuláriosToolStripMenuItem
            // 
            formuláriosToolStripMenuItem.Name = "formuláriosToolStripMenuItem";
            formuláriosToolStripMenuItem.Size = new Size(172, 28);
            formuláriosToolStripMenuItem.Text = "Formulários";
            formuláriosToolStripMenuItem.Click += formuláriosToolStripMenuItem_Click;
            // 
            // mapaMuseuToolStripMenuItem
            // 
            mapaMuseuToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            mapaMuseuToolStripMenuItem.Name = "mapaMuseuToolStripMenuItem";
            mapaMuseuToolStripMenuItem.Size = new Size(118, 27);
            mapaMuseuToolStripMenuItem.Text = "Mapa Museu";
            mapaMuseuToolStripMenuItem.Click += mapaMuseuToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(51, 27);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.viagem_do_homem_a_lua;
            pictureBox1.Location = new Point(65, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(409, 648);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(518, 148);
            label1.Name = "label1";
            label1.Size = new Size(754, 74);
            label1.TabIndex = 5;
            label1.Text = "\"esse é um pequeno passso para o homem mas \r\num grande passo pra humanidade\"\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Apollo11;
            pictureBox2.Location = new Point(542, 457);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(178, 226);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Linda_lua_cheia_cinza_brilhante___Foto_Grátis;
            pictureBox3.Location = new Point(1069, 272);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(178, 144);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // Btn_Historia
            // 
            Btn_Historia.BackColor = Color.MediumSlateBlue;
            Btn_Historia.FlatAppearance.BorderSize = 0;
            Btn_Historia.FlatStyle = FlatStyle.Flat;
            Btn_Historia.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Historia.ForeColor = Color.White;
            Btn_Historia.Location = new Point(813, 281);
            Btn_Historia.Name = "Btn_Historia";
            Btn_Historia.Size = new Size(174, 46);
            Btn_Historia.TabIndex = 8;
            Btn_Historia.Text = "Historia";
            Btn_Historia.UseVisualStyleBackColor = false;
            Btn_Historia.Click += desinButtons1_Click;
            // 
            // Btn_Missao
            // 
            Btn_Missao.BackColor = Color.MediumSlateBlue;
            Btn_Missao.FlatAppearance.BorderSize = 0;
            Btn_Missao.FlatStyle = FlatStyle.Flat;
            Btn_Missao.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Missao.ForeColor = Color.White;
            Btn_Missao.Location = new Point(813, 360);
            Btn_Missao.Name = "Btn_Missao";
            Btn_Missao.Size = new Size(174, 46);
            Btn_Missao.TabIndex = 9;
            Btn_Missao.Text = "Missão Apollo";
            Btn_Missao.UseVisualStyleBackColor = false;
            Btn_Missao.Click += desinButtons2_Click;
            // 
            // Btn_biografia
            // 
            Btn_biografia.BackColor = Color.MediumSlateBlue;
            Btn_biografia.FlatAppearance.BorderSize = 0;
            Btn_biografia.FlatStyle = FlatStyle.Flat;
            Btn_biografia.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_biografia.ForeColor = Color.White;
            Btn_biografia.Location = new Point(813, 439);
            Btn_biografia.Name = "Btn_biografia";
            Btn_biografia.Size = new Size(174, 46);
            Btn_biografia.TabIndex = 10;
            Btn_biografia.Text = "Biografia";
            Btn_biografia.UseVisualStyleBackColor = false;
            Btn_biografia.Click += desinButtons3_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1300, 750);
            ControlBox = false;
            Controls.Add(Btn_biografia);
            Controls.Add(Btn_Missao);
            Controls.Add(Btn_Historia);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Home";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".";
            WindowState = FormWindowState.Maximized;
            Load += Home_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem obrasToolStripMenuItem;
        private ToolStripMenuItem exposiçõesToolStripMenuItem;
        private ToolStripMenuItem formuláriosToolStripMenuItem;
        private ToolStripMenuItem mapaMuseuToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button Btn_Biografia;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Modulos.DesinButtons desinButtons1;
        private Modulos.DesinButtons Btn_Missao;
        private Modulos.DesinButtons Btn_biografia;
        private Modulos.DesinButtons Btn_Historia;
    }
}