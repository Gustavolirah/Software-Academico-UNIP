using Museu_Pim.Modulos;
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
    public partial class Formulariosquiz : Form
    {
        public Formulariosquiz()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Home_Click(object sender, EventArgs e)
        {
            Form Janela_Home = new Home();
            Janela_Home.Show();
            this.Close();
        }

        private void Btn_Relatorio_Click(object sender, EventArgs e)
        {
            Form Janela_Relatorio = new Relatorio();
            Janela_Relatorio.Show();
            this.Close();
        }

        private void Btn_Qustionarios_Click(object sender, EventArgs e)
        {
            Form Janela_Quests = new Quests();
            Janela_Quests.ShowDialog();
        }

        private void Formularios_Load(object sender, EventArgs e)
        {

        }

        private void Brn_Feeadback_Click(object sender, EventArgs e)
        {
            Form janela_Feedback = new Feedback();
            janela_Feedback.Show();
            this.Close();
        }

        private void Btn_Questionario_Click(object sender, EventArgs e)
        {
            Form Janela_Quests = new Quests();
            Janela_Quests.ShowDialog();
        }

        private void Btn_feedback_Click(object sender, EventArgs e)
        {
            Form janela_Feedback = new Feedback();
            janela_Feedback.Show();
            this.Close();
        }

        private void Btn_Relatorio_Click_1(object sender, EventArgs e)
        {
            Form Janela_Relatorio = new Relatorio();
            Janela_Relatorio.Show();
            this.Close();
        }

        private void Btn_home_Click(object sender, EventArgs e)
        {
            Form Janela_Home = new Home();
            Janela_Home.Show();
            this.Close();
        }

        private void Btn_ralatorios_Click(object sender, EventArgs e)
        {
            Form Janela_relatorio = new Relatorio();
            Janela_relatorio.Show();
            this.Close();
        }
    }
}
