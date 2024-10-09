using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Museu_Pim.Modulos
{
    public class Validacao
    {
        private string nome;
        private string sobrenome;
        private string idade;
        private string mensagem;
        private int Idade1;
        private string feedback;

        public string Nome { get => nome; }
        public string Sobrenome { get => sobrenome; }
        public int Idade11 { get => Idade1; }
        public string Mensagem { get => mensagem; }
        public bool Acesso { get; private set; }
        public string Feedback { get => feedback; }

        public Controle Controle
        {
            get => default;
            set
            {
            }
        }

        public Validacao(string nome, string sobrenome, string idade, string Feedback)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.idade = idade;
            this.feedback = Feedback;
            this.validar();
        }

        private void validar()
        {
            this.mensagem = "";
            try
            {
                this.Idade1 = Convert.ToInt32(this.idade);
                if (Regex.IsMatch(nome, @"^[a-zA-Z]*$")){}
                if (Regex.IsMatch(sobrenome, @"^[a-zA-Z]*$")) { }
                if (Regex.IsMatch(idade, @"^[0-9]*$")) { }
                if (Regex.IsMatch(feedback, @"^[a-zA-Z]*$")) { }

            }
            catch(Exception) {

                mensagem = "Digite informaçoes validas";
            }
        }
    }
}

