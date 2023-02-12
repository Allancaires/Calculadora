
using System.Linq.Expressions;
using Calculadora;
using static Calculadora.EntidadeCalculadora;

CalculadoraBasica calculo = new CalculadoraBasica();
EntidadeCalculadora entidade = new EntidadeCalculadora();

Console.WriteLine("Calculadora Básica");
Console.WriteLine();

Console.WriteLine("Entre com o primeiro numero: ");
entidade.N1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Escolha a operação");
entidade.operacao = Console.ReadLine();

Console.WriteLine("Entre com o segundo numero: ");
entidade.N2 = Convert.ToDecimal(Console.ReadLine());

if (entidade.operacao != "")
{
    ;
    Console.WriteLine(calculo.Calcular(entidade.N1, entidade.N2, entidade.operacao));   
}
else
{
    Console.WriteLine("Opção inválida!");
}
