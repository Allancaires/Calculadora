namespace Calculadora
{
    public class CalculadoraBasica
    {
        EntidadeCalculadora entidade = new EntidadeCalculadora();
        public decimal Calcular(decimal N1, decimal N2, string operacao)
        {
             switch (operacao)
            {
            case "+":
                entidade.Resultado = N1 + N2;
            break;
            
            case "-":
                entidade.Resultado = N1 - N2;
            break;

            case "*":
                entidade.Resultado = N1 * N2;
            break;

            case "/":
                entidade.Resultado = N1 / N2;
            break;
            }

        return entidade.Resultado;
        }
    }
}