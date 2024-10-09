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
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void Btn_irHome_Click(object sender, EventArgs e)
        {
            Form Janela_home = new Home();
            Janela_home.Show();
            this.Close();
        }

        private void Btn_irLogin_Click(object sender, EventArgs e)
        {
            Form Janela_Formularios = new Formulariosquiz();
            Janela_Formularios.Show();
            this.Close();
        }

        public void EnviarFeedback()
        {
            Controle controle = new Controle(txb_Nome.Text, txb_Sobrenome.Text, txb_Idade.Text, Txb_Feedback.Text);
            if (controle.Mensagem.Equals(""))
            {
                msgfeedback m = new msgfeedback();
                m.Show();
            }
            else
            {
                msgerrofeedback e = new msgerrofeedback();
                e.Show();
            }
        }

        private void Btn_EnviarFeedback_Click(object sender, EventArgs e)
        {
            this.EnviarFeedback();
        }

        TextBox selecionado;

        private void btn_Aspas_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true)
            {
                selecionado.Text += ("\"");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("'");
            }
        }

        private void btn_esclamacao_Click(object sender, EventArgs e)
        {
            selecionado.Text += "!";
        }

        private void btn_Arroba_Click(object sender, EventArgs e)
        {
            selecionado.Text += "@";
        }

        private void btn_hastag_Click(object sender, EventArgs e)
        {
            selecionado.Text += "#";
        }

        private void btn_sifrao_Click(object sender, EventArgs e)
        {
            selecionado.Text += "$";
        }

        private void btn_Porcetagem_Click(object sender, EventArgs e)
        {
            selecionado.Text += "%";
        }

        private void btn_doispontoscima_Click(object sender, EventArgs e)
        {
            selecionado.Text += "¨";
        }

        private void btn_Ecomercial_Click(object sender, EventArgs e)
        {
            selecionado.Text += "&";
        }

        private void btn_Asteristico_Click(object sender, EventArgs e)
        {
            selecionado.Text += "*";
        }

        private void Btn_Backspage_Click(object sender, EventArgs e)
        {
            selecionado.Text = string.Empty;
        }

        private void btn_UnderlaineeMenos_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true)
            {
                selecionado.Text += ("_");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("-");
            }
        }

        private void Btn_AssentoS_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true)
            {
                selecionado.Text += ("`");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("´");

            }
        }

        private void Btn_AbreChaves_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true)
            {
                selecionado.Text += ("{");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("[");
            }
        }

        private void Btn_Dividir_Click(object sender, EventArgs e)
        {
            selecionado.Text += ("/");
        }

        private void Btn_Q_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("Q");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("q");
            }
        }

        private void Btn_W_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("W");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("w");
            }
        }

        private void Btn_E_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("E");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("e");
            }
        }

        private void Btn_R_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("R");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("r");
            }
        }

        private void Btn_T_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("T");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("t");
            }
        }

        private void Btn_Y_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("Y");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("y");

            }
        }

        private void Btn_U_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("U");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("u");
            }
        }

        private void Btn_I_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("I");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("i");
            }
        }

        private void Btn_O_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("O");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("o");
            }
        }

        private void Btn_P_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("P");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("p");
            }
        }

        private void Btn_Ponto_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true)
            {
                selecionado.Text += (">");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += (".");
            }
        }

        private void Btn_PontoVirgila_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true)
            {
                selecionado.Text += (":");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += (";");
            }
        }

        private void Btn_Sete_Click(object sender, EventArgs e)
        {
            selecionado.Text += ("7");
        }

        private void Btn_Oito_Click(object sender, EventArgs e)
        {
            selecionado.Text += ("8");
        }

        private void Btn_Nove_Click(object sender, EventArgs e)
        {
            selecionado.Text += ("9");
        }

        private void Btn_Quatro_Click(object sender, EventArgs e)
        {
            selecionado.Text += ("4");
        }

        private void Btn_Cinco_Click(object sender, EventArgs e)
        {
            selecionado.Text += ("5");
        }

        private void Btn_Seis_Click(object sender, EventArgs e)
        {
            selecionado.Text += ("6");
        }

        private void Btn_Um_Click(object sender, EventArgs e)
        {
            selecionado.Text += ("1");
        }

        private void Btn_Dois_Click(object sender, EventArgs e)
        {
            selecionado.Text += ("2");
        }

        private void Btn_Tres_Click(object sender, EventArgs e)
        {
            selecionado.Text += ("3");
        }

        private void Btn_Zero_Click(object sender, EventArgs e)
        {
            selecionado.Text += ("0");
        }

        private void chn_CapsLock_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Btn_A_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("A");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("a");
            }
        }

        private void Btn_S_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("S");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("s");
            }
        }

        private void Btn_D_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("D");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("d");
            }
        }

        private void Btn_F_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("F");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("f");
            }
        }

        private void Btn_G_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("G");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("g");
            }
        }

        private void Btn_H_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("H");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("h");
            }
        }

        private void Btn_J_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("J");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("j");
            }
        }

        private void Btn_K_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("K");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("k");
            }
        }

        private void Btn_L_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("L");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("l");
            }
        }

        private void Btn_Virgula_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true)
            {
                selecionado.Text += ("<");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += (",");
            }
        }

        private void Btn_FechsChaves_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true)
            {
                selecionado.Text += ("}");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("]");
            }
        }

        private void Chn_Shift_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Z_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("Z");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("z");
            }
        }

        private void Btn_X_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("X");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("x");
            }
        }

        private void Btn_C_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("C");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("c");
            }
        }

        private void Btn_V_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("V");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("v");
            }
        }

        private void Btn_B_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("B");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("b");
            }
        }

        private void Btn_N_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("N");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("n");
            }
        }

        private void Btn_M_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("M");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("m");
            }
        }

        private void Btn_Ç_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true || chn_CapsLock.Checked == true)
            {
                selecionado.Text += ("Ç");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("ç");
            }
        }

        private void Btn_Interogacao_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true)
            {
                selecionado.Text += ("?");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("/");
            }
        }

        private void Btn_ChapeueCobra_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true)
            {
                selecionado.Text += ("^");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("~");
            }
        }

        private void Btn_MaisIgual_Click(object sender, EventArgs e)
        {
            if (Chn_Shift.Checked == true)
            {
                selecionado.Text += ("+");
                Chn_Shift.Checked = false;
            }
            else
            {
                selecionado.Text += ("=");
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            selecionado.Text += (" ");
        }

        private void Btn_Menos_Click(object sender, EventArgs e)
        {
            selecionado.Text += ("-");
        }

        private void btn_AbriParetenses_Click(object sender, EventArgs e)
        {
            selecionado.Text += ("(");
        }

        private void btn_FechaParetenses_Click(object sender, EventArgs e)
        {
            selecionado.Text += (")");
        }

        private void Btn_Multiplicar_Click(object sender, EventArgs e)
        {
            selecionado.Text += ("*");
        }

        private void Btn_PontoDir_Click(object sender, EventArgs e)
        {
            selecionado.Text += (".");
        }

        private void Btn_Soma_Click(object sender, EventArgs e)
        {
            selecionado.Text += ("+");
        }

        private void Btn_VirgulaDir_Click(object sender, EventArgs e)
        {
            selecionado.Text += (",");
        }

        private void Txb_Feedback_TextChanged(object sender, EventArgs e)
        {
            selecionado = (TextBox)sender;
        }

        private void txb_Fedback_CLick(object sender, EventArgs e)
        {
            selecionado = (TextBox)sender;
        }

        private void txb_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Sobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Idade_TextChanged(object sender, EventArgs e)
        {

        }

        private void desinButtons1_Click(object sender, EventArgs e)
        {
            this.EnviarFeedback();
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            Form Janela_home = new Home();
            Janela_home.Show();
            this.Close();
        }

        private void Btn_Formulario_Click(object sender, EventArgs e)
        {
            Form Janela_Formularios = new Formulariosquiz();
            Janela_Formularios.Show();
            this.Close();
        }

        private void Txb_Nome_click(object sender, EventArgs e)
        {
            selecionado = (TextBox)sender;
        }

        private void Txb_sobrenome_Click(object sender, EventArgs e)
        {
            selecionado = (TextBox)sender;
        }

        private void Txb_Idade_click(object sender, EventArgs e)
        {
            selecionado = (TextBox)sender;
        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            txb_Nome.Focus();
        }

        public Controle Controle
        {
            get => default;
            set
            {
            }
        }
    }
}
