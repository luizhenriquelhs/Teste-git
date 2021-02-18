using System;
using System.Globalization;

namespace Secao6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("Altura média" + avg.ToString("f2", CultureInfo.InvariantCulture));
            
             ----------------VETOR DE CLASSE-----------------------

            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i =0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Nome = nome, Preco = preco };
            }

            double soma = 0.0;

            for(int i = 0; i < n; i++)
            {
                soma += vect[i].Preco;
            }

            double avg = soma / n;

            Console.WriteLine("Preço Médio: " + avg.ToString("f02", CultureInfo.InvariantCulture));
            
             ----------------EXECICIO DE FIXAÇÃO----------*/
            Aluguel[] vect = new Aluguel[10];

            Console.Write("Quantos quartos você pretende alugar: ");
            int n = int.Parse(Console.ReadLine());

                        
            for( int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Aluguel #{i}: ");                

                Console.Write("nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Aluguel(nome, email, quarto);
            }
            Console.WriteLine("Quartos Alugados: ");

            for (int i = 1; i <= 10; i++)
            {
                if(vect[i] != null)
                    Console.WriteLine(i + ": " + vect[i]);

            }

            
        }
    }
}
