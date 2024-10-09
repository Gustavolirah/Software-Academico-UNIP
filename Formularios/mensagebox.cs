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
    public partial class mensagebox : Form
    {
        public mensagebox(int pontuacao, int totalperguntas, int porcentagem, int mediaint)
        {
            InitializeComponent();
            lbl_pontuaçao.Text = "Você acertou " +pontuacao.ToString()+ " de " + totalperguntas.ToString() + ".";
            Lbl_totalmedia.Text = "A media de acertos do museu é de : " + mediaint.ToString() + " %.";
            Lbl_porcentagem.Text = "Sua porcentagem foi de " + porcentagem.ToString() + " % de acertos.";
          
            
        }

        private void mensagebox_Load(object sender, EventArgs e)
        {

        }

        private void desinButtons1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
