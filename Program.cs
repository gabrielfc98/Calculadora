using Calculadora.Operacoes;
using System;

namespace Calculadora
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                int opcao;

                Console.Write(@"Escolha a operação a ser realizada: 
1 - Soma 
2 - Subtração 
3 - Multiplicação
4 - Divisão
5 - Sair do programa
");
                Console.WriteLine();
                opcao = int.Parse(Console.ReadLine());
                double n1;
                double n2;

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Você escolheu soma!");
                        Console.Write("Digite o primeiro número a ser somado: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número a ser somado: ");
                        n2 = double.Parse(Console.ReadLine());
                        Soma soma = new Soma();
                        Console.WriteLine($"O resultado da soma é: {soma.Calculadora(n1, n2)}");
                        break;

                    case 2:
                        Console.WriteLine("Você escolheu subtração!");
                        Console.Write("Digite o primeiro número a ser subtraído: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número a ser subtraído: ");
                        n2 = double.Parse(Console.ReadLine());
                        Subtracao subtracao = new Subtracao();
                        Console.WriteLine($"O resultado da subtração é: {subtracao.Calculadora(n1, n2)}");
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("Você escolheu multriplicação!");
                        Console.Write("Digite o primeiro número a ser multiplicado: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número a ser multiplicado: ");
                        n2 = double.Parse(Console.ReadLine());
                        Multiplicacao multiplicacao = new Multiplicacao();
                        Console.WriteLine($"O resultado da multiplicação é: {multiplicacao.Calculadora(n1, n2)}");
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine("Você escolheu divisão!");
                        Console.Write("Digite o número dividendo: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o número divisor: ");
                        n2 = double.Parse(Console.ReadLine());
                        Divisao divisao = new Divisao();
                        Console.WriteLine($"O resultado da divisão é: {divisao.Calculadora(n1, n2)}");
                        Console.WriteLine();
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Opção inválida");
                        Console.WriteLine();
                        break;
                }
            }

        }
    }
}
