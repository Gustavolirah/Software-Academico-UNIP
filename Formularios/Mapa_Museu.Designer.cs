namespace Museu_Pim.Formularios
{
    partial class Mapa_Museu
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
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            obrasToolStripMenuItem = new ToolStripMenuItem();
            exposiçõesToolStripMenuItem = new ToolStripMenuItem();
            formulariosToolStripMenuItem = new ToolStripMenuItem();
            mapaMuseuToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = Properties.Resources.mapa_pim_3_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.mapa_pim_31;
            pictureBox1.Location = new Point(0, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1264, 673);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Indigo;
            menuStrip1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { obrasToolStripMenuItem, mapaMuseuToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1264, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // obrasToolStripMenuItem
            // 
            obrasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exposiçõesToolStripMenuItem, formulariosToolStripMenuItem });
            obrasToolStripMenuItem.Name = "obrasToolStripMenuItem";
            obrasToolStripMenuItem.Size = new Size(75, 29);
            obrasToolStripMenuItem.Text = "Obras";
            // 
            // exposiçõesToolStripMenuItem
            // 
            exposiçõesToolStripMenuItem.Name = "exposiçõesToolStripMenuItem";
            exposiçõesToolStripMenuItem.Size = new Size(187, 30);
            exposiçõesToolStripMenuItem.Text = "Exposições";
            exposiçõesToolStripMenuItem.Click += exposiçõesToolStripMenuItem_Click;
            // 
            // formulariosToolStripMenuItem
            // 
            formulariosToolStripMenuItem.Name = "formulariosToolStripMenuItem";
            formulariosToolStripMenuItem.Size = new Size(187, 30);
            formulariosToolStripMenuItem.Text = "Formularios";
            formulariosToolStripMenuItem.Click += formulariosToolStripMenuItem_Click;
            // 
            // mapaMuseuToolStripMenuItem
            // 
            mapaMuseuToolStripMenuItem.Name = "mapaMuseuToolStripMenuItem";
            mapaMuseuToolStripMenuItem.Size = new Size(132, 29);
            mapaMuseuToolStripMenuItem.Text = "Mapa Museu";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(57, 29);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // Mapa_Museu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1264, 711);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Mapa_Museu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mapa_Museu";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem obrasToolStripMenuItem;
        private ToolStripMenuItem mapaMuseuToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem exposiçõesToolStripMenuItem;
        private ToolStripMenuItem formulariosToolStripMenuItem;
    }
}