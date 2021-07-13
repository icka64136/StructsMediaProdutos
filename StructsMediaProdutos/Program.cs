using System;
using System.Globalization;

namespace StructsMediaProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos Produtos ?");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];//Vetor Tipo Struct
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nome do Produto : ");
                string name = Console.ReadLine();
                Console.Write("Preço do Produto :$");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Nome = name, Price = price };//Instanciação sem Construtor


            }
            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Price;//.Price indica a Posição que desejo mecher no vetor. Ex: no Preço, .Name Meche no Nome e sem Indicação usa como um Todo!
            }
            double avg = soma / n;
            Console.WriteLine();
            Console.WriteLine("Média de Valor : $" + avg.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
