using System;
using System.Linq;
using System.Security.AccessControl;

namespace Ficha_2
{
    class Program
    {
        static void Problema1(int nAlunos)
        {
            // declaração de arrays
            string[] nomes = new string[nAlunos];
            double[] notaPortugues = new double[nAlunos];
            double[] notaMatematica = new double[nAlunos];
            double[] notaIngles = new double[nAlunos];
            double[] media = new double[nAlunos];

            for (int i = 0; i < nAlunos; i++)
            {
                Console.WriteLine($"Digite o nome do Aluno {i}:");
                nomes[i] = Console.ReadLine();

                double nota;
                do
                {
                    Console.WriteLine("Digite a nota do Aluno a Português (0 a 20):");
                    nota = double.Parse(Console.ReadLine());
                } while (!IsValidGrade(nota));
                notaPortugues[i] = nota;

                do
                {
                    Console.WriteLine("Digite a nota do Aluno a Matemática (0 a 20):");
                    nota = double.Parse(Console.ReadLine());
                } while (!IsValidGrade(nota));
                notaMatematica[i] = nota;

                do
                {
                    Console.WriteLine("Digite a nota do Aluno a Inglês (0 a 20):");
                    nota = double.Parse(Console.ReadLine());
                } while (!IsValidGrade(nota));
                notaIngles[i] = nota;

                media[i] = (notaPortugues[i] + notaMatematica[i] + notaIngles[i]) / 3; // São 3 disciplinas.
            }

            for (int i = 0; i < nAlunos; i++)
            {
                Console.WriteLine($"O aluno {nomes[i]} obteve a média de {media[i]}");
            }

            (double maiorMedia, int posicao) = EncontrarMaiorValorEPosicao(media);
            Console.WriteLine($"A maior média é: {maiorMedia}, obtida pelo aluno {nomes[posicao]}");
        }

        // Function to check if the grade is valid
        static bool IsValidGrade(double grade)
        {
            return grade >= 0 && grade <= 20;
        }

        static (double, int) EncontrarMaiorValorEPosicao(double[] array)
        {
            double maiorValor = array[0];
            int posicao = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maiorValor)
                {
                    maiorValor = array[i];
                    posicao = i;
                }
            }

            return (maiorValor, posicao);
        }

        static void Problema2(int n)
        {
            int[] numeros = new int[n];
            string[] palavras = new string[n];
            int soma = 0;
            int mult = 1;
            // Insere os valores no array - Vai somando e multiplicando os valores
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero); // o que existe dentro do array? Isto serve de teste
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Digite {i + 1}º número:");
                numeros[i] = int.Parse(Console.ReadLine());
                soma += numeros[i]; // Soma os valores -> soma = soma + numeros[i]
                mult *= numeros[i]; // Multiplica os valores -> mult = mult * numeros[i]
                Console.WriteLine($"Digite {i + 1}º palavra:");
                palavras[i] = Console.ReadLine();
            }
            // Imprimir os valores -- Concatenar todas as palavras do array string
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Multiplicação: {mult}");
            Console.WriteLine($"Palavras: {string.Join(" ", palavras)}");
        }

        static double Problema3()
        {
            // Primeira linha - cabeçalho da tabela
            Console.WriteLine("* Item            * Código     * Preço (€) *");
            Console.WriteLine("------------------|------------|------------");
            Console.WriteLine("* Cachorro Quente * 101        *      1,20 *");
            Console.WriteLine("------------------|------------|------------");
            Console.WriteLine("* Sandes Simples  * 102        *      1,30 *");
            Console.WriteLine("------------------|------------|------------");
            Console.WriteLine("* Sandes com Ovo  * 103        *      1,50 *");
            Console.WriteLine("------------------|------------|------------");
            Console.WriteLine("* Hambúrguer      * 104        *      1,20 *");
            Console.WriteLine("------------------|------------|------------");
            Console.WriteLine("* Cheeseburger    * 105        *      1,30 *");
            Console.WriteLine("------------------|------------|------------");
            Console.WriteLine("* Refrigerante    * 106        *      1,00 *");
            Console.WriteLine("------------------|------------|------------");

            double total = 0;
            while (true) // Loop infinito
            {
                Console.WriteLine("Qual o código do produto que deseja? (Digite 0 para sair)");
                int codigo = int.Parse(Console.ReadLine());
                if (codigo == 0)
                {
                    break;
                }

                Console.WriteLine("Qual a quantidade?");
                int quantidade = int.Parse(Console.ReadLine());
                double preco = 0;

                switch (codigo)
                {
                    case 101:
                        preco = 1.20;
                        break;
                    case 102:
                        preco = 1.30;
                        break;
                    case 103:
                        preco = 1.50;
                        break;
                    case 104:
                        preco = 1.20;
                        break;
                    case 105:
                        preco = 1.30;
                        break;
                    case 106:
                        preco = 1.00;
                        break;
                    default:
                        Console.WriteLine("Código inválido");
                        continue;
                }

                double subtotal = preco * quantidade;
                total += subtotal;
                Console.WriteLine($"Subtotal para {quantidade} unidades do código {codigo}: {subtotal}€");
            }

            Console.WriteLine($"Total a pagar: {total}€");
            return total;
        }

        static double Problema3_Vectores()
        {
            int[] codigos = {101, 102, 103, 104, 105, 106 };
            string[] palavras = { "Cachorro Quente", "Sandes Simples", "Sandes com Ovo", "Hambúrguer", "Cheeseburger", "Refrigerante" };
            double[] precos = {1.20, 1.30, 1.50, 1.20, 1.30, 1.00 };

             // Primeira linha - cabeçalho da tabela
            Console.WriteLine("* Item            * Código     * Preço (€) *");
            Console.WriteLine("------------------|------------|------------");
            Console.WriteLine("* Cachorro Quente * 101        *      1,20 *");
            Console.WriteLine("------------------|------------|------------");
            Console.WriteLine("* Sandes Simples  * 102        *      1,30 *");
            Console.WriteLine("------------------|------------|------------");
            Console.WriteLine("* Sandes com Ovo  * 103        *      1,50 *");
            Console.WriteLine("------------------|------------|------------");
            Console.WriteLine("* Hambúrguer      * 104        *      1,20 *");
            Console.WriteLine("------------------|------------|------------");
            Console.WriteLine("* Cheeseburger    * 105        *      1,30 *");
            Console.WriteLine("------------------|------------|------------");
            Console.WriteLine("* Refrigerante    * 106        *      1,00 *");
            Console.WriteLine("------------------|------------|------------");

            double total = 0;
            while (true) // Loop infinito
            {
                Console.WriteLine("Qual o código do produto que deseja? (Digite 0 para sair)");
                int codigo = int.Parse(Console.ReadLine());
                if (codigo == 0)
                {
                    break;
                }

                Console.WriteLine("Qual a quantidade?");
                int quantidade = int.Parse(Console.ReadLine());
                double preco = 0;
                // Muito similar a Python, no sentido que há funções auxiliares já implementadas nas bibliotecas
                int posicao = Array.IndexOf(codigos, codigo); // Procura o código no array de códigos e retorna-me a posição
                if (posicao == -1)
                {
                    Console.WriteLine("Código inválido");
                    continue;
                }

                preco = precos[posicao];
                string palavra = palavras[posicao];
                double subtotal = preco * quantidade;
                total += subtotal; // eventualmente, o total irá ser a soma de todos os subtotais. 
                // Posso dar um print final depois do loop, para apresentar a conta final.
                Console.WriteLine($"Subtotal para {quantidade} unidades do código {codigo} ({palavra}): {subtotal}€");
            }
            return 0;
        }

        static double Problema3_Matrizes()
        {
            // O que estou a pensar é criar uma matriz de 2 dimensões, onde a primeira dimensão é o código e a segunda dimensão é o preço

            double[,] produtos = {
                {101, 1.20},
                {102, 1.30},
                {103, 1.50},
                {104, 1.20},
                {105, 1.30},
                {106, 1.00}
            };
             // Primeira linha - cabeçalho da tabela
            Console.WriteLine("* Item            * Código     * Preço (€) *");
            Console.WriteLine("------------------|------------|------------");
            Console.WriteLine("* Cachorro Quente * 101        *      1,20 *");
            Console.WriteLine("------------------|------------|------------");
            Console.WriteLine("* Sandes Simples  * 102        *      1,30 *");
            Console.WriteLine("------------------|------------|------------");
            Console.WriteLine("* Sandes com Ovo  * 103        *      1,50 *");
            Console.WriteLine("------------------|------------|------------");
            Console.WriteLine("* Hambúrguer      * 104        *      1,20 *");
            Console.WriteLine("------------------|------------|------------");
            Console.WriteLine("* Cheeseburger    * 105        *      1,30 *");
            Console.WriteLine("------------------|------------|------------");
            Console.WriteLine("* Refrigerante    * 106        *      1,00 *");
            Console.WriteLine("------------------|------------|------------");

            double total = 0;
            while (true) // Loop infinito
            {
                Console.WriteLine("Qual o código do produto que deseja? (Digite 0 para sair)");
                int codigo = int.Parse(Console.ReadLine());
                if (codigo == 0) // Caso de saída
                {
                    break;
                }

                Console.WriteLine("Qual a quantidade?");
                int quantidade = int.Parse(Console.ReadLine());
                double preco = 0;
                int posicao = -1;
                for (int i = 0; i < produtos.GetLength(0); i++) // Retorna-me o número de linhas
                {
                    if (produtos[i, 0] == codigo)
                    {
                        posicao = i;
                        break;
                    }
                }

                if (posicao == -1)
                {
                    Console.WriteLine("Código inválido");
                    continue;
                }

                //Printar matriz
                for (int i = 0; i < produtos.GetLength(0); i++)
                {
                    for (int j = 0; j < produtos.GetLength(1); j++)
                    {
                        Console.Write(produtos[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                /* 6 linhas, 2 colunas
                    101 1.2 
                    102 1.3 
                    103 1.5 
                    104 1.2 
                    105 1.3 
                    106 1 
                */
                preco = produtos[posicao, 1];
                string palavra = "";
                double subtotal = preco * quantidade;
                total += subtotal;
                Console.WriteLine($"Subtotal para {quantidade} unidades do código {codigo} ({palavra}): {subtotal}€");
            }

            return 0;
        }



        static void matriz()
        {
            int [,] matriz = new int[3,2] { {1,2}, {3,4}, {5,6} };
            // Vamos imprimir a matriz e mostrar na consola o número 6
            Console.WriteLine(matriz[2,1]);

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i,j] + " ");
                }
                Console.WriteLine();
            }
            // Inserir um novo número, substituindo o 3 por 10
            matriz[1,0] = 10;
            Console.WriteLine(matriz[1,0]);
        }

        static void Main(string[] args)
        {
            //Problema1(2);
            //Problema2(2);
            //Problema3();
            //Problema3_Vectores();
            //Problema3_Matrizes();
        }
    }
}