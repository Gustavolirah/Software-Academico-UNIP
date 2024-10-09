using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museu_Pim.Formularios
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void exposiçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Janela_Exposicoes = new Exposicoes();
            Janela_Exposicoes.Show();
            this.Visible = false;
        }

        private void formuláriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Janela_Formularios = new Formulariosquiz();
            Janela_Formularios.Show();
            this.Visible = false;
        }

        private void mapaMuseuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Janela_Mapa_Museu = new Mapa_Museu();
            Janela_Mapa_Museu.Show();
            this.Visible = false;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Janela_visitante = new Visitante();
            Janela_visitante.Show();
            this.Visible = false;
        }

        private void Btn_Historia_Click(object sender, EventArgs e)
        {
            Form Janela_Exposicoes = new Exposicoes();
            Janela_Exposicoes.Show();
            this.Visible = false;
        }

        private void Btn_MissaoApollo_Click(object sender, EventArgs e)
        {
            Form Janela_MissaoApolo = new MissaoApolo();
            Janela_MissaoApolo.Show();
            this.Visible = false;
        }

        private void Btn_Biografia_Click(object sender, EventArgs e)
        {
            Form Janela_Bibliografia = new Bibliografia();
            Janela_Bibliografia.Show();
            this.Visible = false;
        }

        private void desinButtons1_Click(object sender, EventArgs e)
        {
            Form Janela_Exposicoes = new Exposicoes();
            Janela_Exposicoes.Show();
            this.Visible = false;
        }

        private void desinButtons2_Click(object sender, EventArgs e)
        {
            Form Janela_MissaoApolo = new MissaoApolo();
            Janela_MissaoApolo.Show();
            this.Visible = false;
        }

        private void desinButtons3_Click(object sender, EventArgs e)
        {
            Form Janela_Bibliografia = new Bibliografia();
            Janela_Bibliografia.Show();
            this.Visible = false;
        }
    }
}
