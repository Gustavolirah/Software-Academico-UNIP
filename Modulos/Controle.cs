using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museu_Pim.Modulos
{
    public class Controle
    {
        private string nome;
        private string sobrenome;
        private string idade;
        private string Feedback;

        private string mensagem;
        public string Mensagem { get => mensagem; }

        public Validacao Validacao
        {
            get => default;
            set
            {
            }
        }

        public Pessoas Pessoas
        {
            get => default;
            set
            {
            }
        }

        public Controle(string nome,string sobrenome, string idade,string Feedback) 
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.idade = idade;
            this.Feedback = Feedback;
            this.Executar();
        }

        private void Executar()
        {
            this.mensagem = "";
            Validacao validacao = new Validacao(this.nome, this.sobrenome, this.idade,this.Feedback);
            if (validacao.Mensagem.Equals(""))
            {
                Pessoas pessoa = new Pessoas(validacao.Nome,validacao.Sobrenome,validacao.Idade11,validacao.Feedback);
                pessoa.Salvar(pessoa);            
            }
            else
            {
                this.mensagem = validacao.Mensagem;
            }
        }


    }
}
