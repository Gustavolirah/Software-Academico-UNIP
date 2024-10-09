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
    public partial class MissaoApolo : Form
    {
        public MissaoApolo()
        {
            InitializeComponent();
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            Form Janela_Home = new Home();
            Janela_Home.Show();
            this.Close();
        }

        private void Btn_ProximaObra_Click(object sender, EventArgs e)
        {
            Form Janela_Bibliografia = new Bibliografia();
            Janela_Bibliografia.Show();
            this.Close();
        }

        private void btn_formulario_Click(object sender, EventArgs e)
        {
            Form Janela_Formulario = new Formulariosquiz();
            Janela_Formulario.Show();
            this.Close();
        }

        private void Btn_home_Click_1(object sender, EventArgs e)
        {
            Form Janela_Home = new Home();
            Janela_Home.Show();
            this.Close();
        }

        private void Btn_formulario_Click_1(object sender, EventArgs e)
        {
            Form Janela_Formulario = new Formulariosquiz();
            Janela_Formulario.Show();
            this.Close();
        }

        private void Btn_proxima_Click(object sender, EventArgs e)
        {
            Form Janela_Bibliografia = new Bibliografia();
            Janela_Bibliografia.Show();
            this.Close();
        }
    }
}
