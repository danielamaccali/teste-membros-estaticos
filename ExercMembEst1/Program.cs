using System;

namespace ExercMembEst1
{
    class Program
    {
        static void Main(string[] args)

            /*Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda
para ser responsável pelos cálculos.*/
        {
            Console.WriteLine("Valor a ser comprado em U$: ");
            double ValorCompra = double.Parse(Console.ReadLine());
            Console.WriteLine("Cotação dólar: ");
            double CotDolar = double.Parse(Console.ReadLine());

            double ValorFinal = CalculadoraDolar.Conversor(CotDolar, ValorCompra);
            Console.WriteLine($"Valor a ser pago em Reais: {ValorFinal}");

            Console.ReadKey();

        }
    }
}
