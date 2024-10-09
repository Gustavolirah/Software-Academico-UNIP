using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Museu_Pim.Modulos
{
    public class Pessoas
    {
        private string nome;
        private string sobrenome;
        private int idade;
        private string feedback;

        public Pessoas(string nome,string sobrenome, int idade,string Feedback)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.idade = idade;   
            this.feedback = Feedback;
        }

        public Formularios.Relatorio Relatorio
        {
            get => default;
            set
            {
            }
        }

        public bool Salvar(Pessoas pessoa)
        {
            try
            {
                using (var Linhas = new StreamWriter("C:\\dados\\pessoa.txt", true))
                {
                    Linhas.WriteLine(this.nome + ";" + this.sobrenome + ";" + this.idade + ";" + this.feedback + ";");
                }
                return true;
            } 
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
