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
    public partial class Mapa_Museu : Form
    {
        public Mapa_Museu()
        {
            InitializeComponent();
        }

        private void exposiçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Janela_Home = new Home();
            Janela_Home.Show();
            this.Close();
           
        }

        private void formulariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Janela_Formularios = new Formulariosquiz();
            Janela_Formularios.Show();
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Janela_visitante = new Visitante();
            Janela_visitante.Show();
            this.Close();
        }
    }
}
