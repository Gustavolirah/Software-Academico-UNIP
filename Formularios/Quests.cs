using Museu_Pim.Formularios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Museu_Pim.Modulos
{
    public partial class Quests : Form
    {
        mensagebox mensage;
        int perguntacorreta;
        int numeroperguntas = 1;
        int pontuacao;
        private int porcentagem;
        int totalperguntas;
        private int mediaint;

        public Quests()
        {
            InitializeComponent();
            Atraçao(numeroperguntas);
            totalperguntas = 5;
        }

        public Quests(int mediaint, int porcentagem)
        {
            this.mediaint = mediaint;
            this.porcentagem = porcentagem;
        }

        internal Calculo Calculo
        {
            get => default;
            set
            {
            }
        }

        private void Verificarevento(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == perguntacorreta)
            {
                pontuacao++;
            }

            if (numeroperguntas == totalperguntas)
            {

                Calculo calculo = new Calculo(pontuacao, totalperguntas);


                this.porcentagem = calculo.Porcentagem;
                this.mediaint = calculo.MediaInt;

                mensage = new mensagebox(pontuacao,totalperguntas,porcentagem,mediaint);
                mensage.Show();
                this.Close();
                

               // MessageBox.Show("Teste final" +
               //     Environment.NewLine + "Você respondeu " + pontuacao + " perguntas corretas de " + totalperguntas + "." +
               //     Environment.NewLine + "Sua pontuação foi de " + porcentagem + "%" +
               //     Environment.NewLine + "A média do museu é de " + mediaint + "%" +
               //     Environment.NewLine + "Obrigado por participar do quiz do museu", "RESULTADO QUIZ");

                
            }
            else
            {
                numeroperguntas++;
                Atraçao(numeroperguntas);
            }
        }

        private void Atraçao(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.pergunta1;
                    LblAtraçao.Text = "Quem foi a primeira pessoa a ir para a lua?";
                    button1.Text = "Alan Shepard";
                    button2.Text = "Neil Armstrong";
                    button3.Text = "David Scott";
                    button4.Text = "Gugu";
                    perguntacorreta = 2;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.pergunta2;
                    LblAtraçao.Text = "Como se chamava a mulher de Neil Armstrong?";
                    button1.Text = "Eliana";
                    button2.Text = "Faustão";
                    button3.Text = "Janet Shearon";
                    button4.Text = "Paola Oliveira";
                    perguntacorreta = 3;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.pergunta3;
                    LblAtraçao.Text = "Quando a missão Apollo ocorreu?";
                    button1.Text = "16 de Julho";
                    button2.Text = "7 de Setembro";
                    button3.Text = "22 de Março";
                    button4.Text = "11 de Setembro";
                    perguntacorreta = 1;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.pergunra4;
                    LblAtraçao.Text = "Como a filha de Neil morreu?";
                    button1.Text = "Caiu de paraquedas";
                    button2.Text = "Afogada";
                    button3.Text = "Não morreu";
                    button4.Text = "Tumor cerebral";
                    perguntacorreta = 4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.pergunta5;
                    LblAtraçao.Text = "O que Neil Falou para Buzz na lua?";
                    button1.Text = "Pedido de namoro";
                    button2.Text = "Confessou um crime";
                    button3.Text = "É um pequeno passo para o homem um grande passo para a humanidade";
                    button4.Text = "Indepedencia ou morte";
                    perguntacorreta = 3;
                    break;
            }
        }

        private void Forms_Load(object sender, EventArgs e) { }

        private void Quests_Load(object sender, EventArgs e) { }

        private void LblAtraçao_Click(object sender, EventArgs e)
        {

        }
    }
}
