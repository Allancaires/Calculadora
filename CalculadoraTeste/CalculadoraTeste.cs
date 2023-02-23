using Xunit;

namespace Calculadora.CalculadoraTeste
{
    public class CalculadoraTeste
    {
        [Theory]
        [InlineData(10, 15, "+")]
        [InlineData(30, 5, "-")]
        [InlineData(5, 5, "*")]
        [InlineData(100, 5, "/")]
        public void Calcular(int N1, int N2, string operacao)
        {
            var CalculadoraBasica = new CalculadoraBasica();

            var Resultado = CalculadoraBasica.Calcular(N1, N2, operacao);

            Assert.Equal(25, Resultado);
        }
    }
}
