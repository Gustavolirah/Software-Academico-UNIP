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
    public partial class Exposicoes : Form
    {
        public Exposicoes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Janela_Formulario = new Formulariosquiz();
            Janela_Formulario.Show();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Janela_Home = new Home();
            Janela_Home.Show();
            this.Close();

        }

        private void btn_ProximaObra_Click(object sender, EventArgs e)
        {
            Form Janela_MissaoApolo = new MissaoApolo();
            Janela_MissaoApolo.Show();
            this.Close();

        }

        private void desinButtons2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            Form Janela_Home = new Home();
            Janela_Home.Show();
            this.Close();
        }

        private void Btn_formulario_Click(object sender, EventArgs e)
        {
            Form Janela_Form = new Formulariosquiz();
            Janela_Form.Show();
            this.Close();
        }

        private void Btn_Proxima_Click(object sender, EventArgs e)
        {
            Form Janela_Proxima = new MissaoApolo();
            Janela_Proxima.Show();
            this.Close();
        }
    }
}
