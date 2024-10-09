using Museu_Pim.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museu_Pim.Modulos
{
    public partial class msgfeedback : Form
    {
        public msgfeedback()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void msgfeedback_Load(object sender, EventArgs e)
        {

        }

        private void desinButtons1_Click(object sender, EventArgs e)
        {
            Form Janela_Formularios = new Formulariosquiz();
            Janela_Formularios.Show();
            this.Close();
        }
    }
}
