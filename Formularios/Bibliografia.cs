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
    public partial class Bibliografia : Form
    {
        public Bibliografia()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Janela_Home = new Home();
            Janela_Home.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Janela_Formulario = new Formulariosquiz();
            Janela_Formulario.Show();
            this.Close();

        }

        private void Btn_formularios_Click(object sender, EventArgs e)
        {
            Form Janela_Formulario = new Formulariosquiz();
            Janela_Formulario.Show();
            this.Close();
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            Form Janela_Home = new Home();
            Janela_Home.Show();
            this.Close();
        }
    }
}
