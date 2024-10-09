using Museu_Pim.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Museu_Pim.Modulos
{
    public class Calculo
    {
        public static List<int> pontuacoesUsuarios = new List<int>();
        public static List<int> BancoPorcentagem = new List<int>();

        private int porcentagem;
        private int pontuacao;
        private int totalPerguntas;
        private int mediaInt;


        public int Porcentagem { get => porcentagem; }
        public int MediaInt { get => mediaInt; }
        public int Pontuacao { get => pontuacao; set => pontuacao = value; }
        public int TotalPerguntas { get => totalPerguntas; set => totalPerguntas = value; }

        public mensagebox mensagebox
        {
            get => default;
            set
            {
            }
        }

        public Calculo(int pontuacao, int totalPerguntas)
        {
            this.Pontuacao = pontuacao;
            this.TotalPerguntas = totalPerguntas;
            this.Executar();
        }

        public void Executar()
        {
            porcentagem = (int)Math.Round((double)(Pontuacao * 100) / TotalPerguntas);

            pontuacoesUsuarios.Add(Pontuacao);
            BancoPorcentagem.Add(porcentagem);

            mediaInt = (int)Math.Round(BancoPorcentagem.Average());

            Console.WriteLine("Pontuação adicionada: " + Pontuacao);
            Console.WriteLine("Porcentagem adicionada: " + porcentagem);
            Console.WriteLine("Média das porcentagens: " + BancoPorcentagem.Average());
            Console.WriteLine("Média inteira das porcentagens: " + mediaInt);
        }

        public static double CalcularMediaPontuacoes()
        {
            if (pontuacoesUsuarios.Count == 0)
                return 0;

            return pontuacoesUsuarios.Average();
        }

        public static double CalcularMediaPorcentagens()
        {
            if (BancoPorcentagem.Count == 0)
                return 0;

            return BancoPorcentagem.Average();
        }
    }
}
