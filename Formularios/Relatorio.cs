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
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            StreamReader txt = new StreamReader(@"C:\dados\pessoa.txt");
            string Linha;
            string[] campo;

            while ((Linha = txt.ReadLine()) != null)
            {
                campo = Linha.Split(";");
                dataGridView1.Rows.Add(campo);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_home_Click(object sender, EventArgs e)
        {
            Form Janela_Home = new Home();
            Janela_Home.Show();
            this.Close();
        }

        private void Btn_formularios_Click(object sender, EventArgs e)
        {
            Form Janela_Formularios = new Formulariosquiz();
            Janela_Formularios.Show();
            this.Close();
        }
    }
}
