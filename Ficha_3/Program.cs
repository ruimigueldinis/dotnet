using System;
using System.Linq;
using System.Security.AccessControl;

namespace Ficha_3
{
    class Program
    {
        static double Problema1()
        {
             // Primeira linha - cabeçalho da tabela
            Console.WriteLine("                     Menu                        ");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("1. Converter Celsius para Fahrenheit (Cº para Fº)");
            Console.WriteLine("2. Converter Fahrenheit para Celsius (Fº para Cº)");
            Console.WriteLine("3. Sair do programa                              ");

            double temp = 0;
            double temp_user = 0;
            while (true) // Loop infinito
            {
                Console.WriteLine("Escolha uma opção? (Digite 3 para sair)");
                int codigo = int.Parse(Console.ReadLine());
                if (codigo == 3)
                {
                    break;
                }

                switch (codigo)
                {
                    case 1:
                        Console.WriteLine("Digite a temperatura em Celsius:");
                        temp_user = double.Parse(Console.ReadLine());
                        temp = (temp_user * 9 / 5) + 32;
                        Console.WriteLine($"A temperatura em Fahrenheit é: {temp} Fº");
                        break;
                    case 2:
                        Console.WriteLine("Digite a temperatura em Fahrenheit:");
                        temp_user = double.Parse(Console.ReadLine());
                        temp = (temp_user - 32) * 5 / 9;
                        Console.WriteLine($"A temperatura em Celsius é: {temp} Cº");
                        break;
                    default:
                        Console.WriteLine("Código inválido");
                        continue;
                }
            }
            return temp;
        }

        static double Problema2()
        {
             // Primeira linha - cabeçalho da tabela
            Console.WriteLine("                     Menu                        ");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Raiz Quadrada");
            Console.WriteLine("6. Potência");
            Console.WriteLine("7. Sair");

            double a,b,resultado = 0;
            while (true) // Loop infinito
            {
                Console.WriteLine("Escolha uma opção? (Digite 3 para sair)");
                int codigo = int.Parse(Console.ReadLine());
                if (codigo == 7)
                {
                    break;
                }

                switch (codigo)
                {
                    case 1:
                        Console.WriteLine("Digite o primeiro número:");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número:");
                        b = double.Parse(Console.ReadLine());
                        resultado = a+b;
                        Console.WriteLine($"{a}+{b} = {resultado}");
                        break;

                    case 2:
                        Console.WriteLine("Digite o primeiro número:");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número:");
                        b = double.Parse(Console.ReadLine());
                        resultado = a-b;
                        Console.WriteLine($"{a}-{b} = {resultado}");
                        break;

                    case 3:
                        Console.WriteLine("Digite o primeiro número:");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número:");
                        b = double.Parse(Console.ReadLine());
                        resultado = a*b;
                        Console.WriteLine($"{a}*{b} = {resultado}");
                        break;

                    case 4:
                        Console.WriteLine("Digite o primeiro número:");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número:");
                        b = double.Parse(Console.ReadLine());
                        resultado = a/b;
                        Console.WriteLine($"{a}/{b} = {resultado}");
                        break;

                    case 5:
                        Console.WriteLine("Digite um número:");
                        a = double.Parse(Console.ReadLine());
                        resultado = Math.Sqrt(a);
                        Console.WriteLine($"Sqrt({a}) = {resultado}");
                        break;

                    case 6:
                        Console.WriteLine("Digite o primeiro número:");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número:");
                        b = double.Parse(Console.ReadLine());
                        resultado = Math.Pow(a,b);
                        Console.WriteLine($"{a}^{b} = {resultado}");
                        break;

                    default:
                        Console.WriteLine("Código inválido");
                        continue;
                }
            }
            return resultado;
        }

         static double Problema3()
        {
             // Primeira linha - cabeçalho da tabela
            Console.WriteLine("                     Menu                        ");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("              Conversor de moeda                 ");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("1. Converter Euro para Dolar (€ para $)          ");
            Console.WriteLine("2. Converter Euro para Libra (€ para £)          ");
            Console.WriteLine("2. Converter Euro para ? moeda (€ para ?)          ");
            Console.WriteLine("4. Sair do Conversor                             ");

            double euros=0;
            while (true) // Loop infinito
            {
                Console.WriteLine("Escolha uma opção? (Digite 4 para sair)");
                int codigo = int.Parse(Console.ReadLine());
                if (codigo == 4)
                {
                    break;
                }

                switch (codigo)
                {
                    case 1:
                        Console.WriteLine("Digite o número de Euros a converter para Dolar:");
                        euros = double.Parse(Console.ReadLine());
                        double dolar = euros * 1.12;
                        Console.WriteLine($"{euros}€ = {dolar}$");
                        break;
                    case 2:
                        Console.WriteLine("Digite o número de Euros a converter para Dolar:");
                        euros = double.Parse(Console.ReadLine());
                        double libra = euros * 0.85;
                        Console.WriteLine($"{euros}€ = {libra}£");
                        break;
                    case 3:
                        Console.WriteLine("Digite o número de Euros a converter para uma outra moeda:");
                        euros = double.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o nome da moeda?");
                        string moeda = Console.ReadLine();
                        Console.WriteLine("Digite a taxa de conversão da outra moeda:");
                        double taxa = double.Parse(Console.ReadLine());
                        double resultado = euros * taxa;
                        Console.WriteLine($"{euros}€ = {resultado} {moeda}");
                        break;
                    default:
                        Console.WriteLine("Código inválido");
                        continue;
                }
            }
            return euros;
        }

        // Sub-funções
        static double euro2dolar(double euro)
        {
            return euro * 1.12;
        }

        static double euro2libra(double euro)
        {
            return euro * 0.85;
        }

        static double euro2moeda(double euro, double taxa)
        {
            return euro * taxa;
        }

        // Exercício 3 com funções auxiliares

        static double Problema3_FuncaoAuxiliar()
        {
             // Primeira linha - cabeçalho da tabela
            Console.WriteLine("                     Menu                        ");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("              Conversor de moeda                 ");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("1. Converter Euro para Dolar (€ para $)          ");
            Console.WriteLine("2. Converter Euro para Libra (€ para £)          ");
            Console.WriteLine("2. Converter Euro para ? moeda (€ para ?)          ");
            Console.WriteLine("4. Sair do Conversor                             ");

            double euros=0;
            while (true) // Loop infinito
            {
                Console.WriteLine("Escolha uma opção? (Digite 4 para sair)");
                int codigo = int.Parse(Console.ReadLine());
                if (codigo == 4)
                {
                    break;
                }

                switch (codigo)
                {
                    case 1:
                        Console.WriteLine("Digite o número de Euros a converter para Dolar:");
                        euros = double.Parse(Console.ReadLine());
                        double dolar = euro2dolar(euros);
                        Console.WriteLine($"{euros}€ = {dolar}$");
                        break;
                    case 2:
                        Console.WriteLine("Digite o número de Euros a converter para Dolar:");
                        euros = double.Parse(Console.ReadLine());
                        double libra = euro2libra(euros);
                        Console.WriteLine($"{euros}€ = {libra}£");
                        break;
                    case 3:
                        Console.WriteLine("Digite o número de Euros a converter para uma outra moeda:");
                        euros = double.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o nome da moeda?");
                        string moeda = Console.ReadLine();
                        Console.WriteLine("Digite a taxa de conversão da outra moeda:");
                        double taxa = double.Parse(Console.ReadLine());
                        double resultado = euro2moeda(euros, taxa);
                        Console.WriteLine($"{euros}€ = {resultado} {moeda}");
                        break;
                    default:
                        Console.WriteLine("Código inválido");
                        continue;
                }
            }
            return euros;
        }

        static void Main(string[] args)
        {
            //Problema1();
            //Problema2();
            Problema3_FuncaoAuxiliar(); // Exercício 3 com funções auxiliares

        }
    }
}
