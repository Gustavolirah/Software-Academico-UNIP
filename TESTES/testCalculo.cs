using Microsoft.VisualStudio.TestTools.UnitTesting;
using Museu_Pim.Modulos;
using System;

namespace Museu_Pim.Tests.Modulos
{
    [TestClass]
    public class CalculoTests
    {
        [TestMethod]
        public void TestCalculo_Executar_ComputaPorcentagem()
        {

            int pontuacao = 80;
            int totalPerguntas = 100;
            var calculo = new Calculo(pontuacao, totalPerguntas);


            int porcentagem = calculo.Porcentagem;


            Assert.AreEqual(80, porcentagem);
        }

        [TestMethod]
        public void TestCalculo_Executar_ComputaMediaInt()
        {

            int pontuacao1 = 80;
            int totalPerguntas1 = 100;
            var calculo1 = new Calculo(pontuacao1, totalPerguntas1);

            int pontuacao2 = 60;
            int totalPerguntas2 = 100;
            var calculo2 = new Calculo(pontuacao2, totalPerguntas2);


            int mediaInt = calculo2.MediaInt;


            Assert.AreEqual(70, mediaInt);
        }

        [TestMethod]
        public void TestCalculo_CalcularMediaPontuacoes_ComputaMedia()
        {
            // Arrange
            int pontuacao1 = 80;
            int totalPerguntas1 = 100;
            var calculo1 = new Calculo(pontuacao1, totalPerguntas1);

            int pontuacao2 = 60;
            int totalPerguntas2 = 100;
            var calculo2 = new Calculo(pontuacao2, totalPerguntas2);

            // Act
            double mediaPontuacoes = Calculo.CalcularMediaPontuacoes();

            // Assert
            Assert.AreEqual(70.0, mediaPontuacoes, 0.01);
        }

        [TestMethod]
        public void TestCalculo_CalcularMediaPorcentagens_ComputaMediaCorretamente()
        {
            // Arrange
            int pontuacao1 = 80;
            int totalPerguntas1 = 100;
            var calculo1 = new Calculo(pontuacao1, totalPerguntas1);

            int pontuacao2 = 60;
            int totalPerguntas2 = 100;
            var calculo2 = new Calculo(pontuacao2, totalPerguntas2);

            // Act
            double mediaPorcentagens = Calculo.CalcularMediaPorcentagens();

            // Assert
            Assert.AreEqual(70.0, mediaPorcentagens, 0.01);
        }
    }
}