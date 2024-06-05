using Course3;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* USANDO MATRIZ COM DADOS STRUCT
             * 
             * //double? number = 10; //valor opcional, isto é, aceita valores nulos
            Console.Write("Informe o total de alturas que será informado: ");
            int numero = int.Parse(Console.ReadLine());
            double[] vect = new double[numero]; //criação de um vetor
            for (int i = 0; i < numero; i++) //laço de repetição para inserir os valores no vetor
            {
                vect[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0.00; //variável para soma

            for (int i = 0; i < numero; i++) //laço de repetição para somar os valores do vetor
            {
                sum += vect[i];
            }

            double avg = sum / numero; //média das alturas

            Console.WriteLine("AVERAGE HEIGHT: " + avg.ToString("F2", CultureInfo.InvariantCulture));

            //Console.WriteLine(vect[numero]);

            //Console.WriteLine(number.GetValueOrDefault()); //retona o valor ou o default do tipo
            //Console.WriteLine(number.HasValue); //função booleana, retorna se é verdadeiro que contém valor ou não
            //Console.WriteLine(numero.GetType()); //retorna o tipo do campo
            */

            /* USANDO MATRIZ COM DADOS REFEREMCIA/CLASSE
             * 
            Console.Write("Informe a quantidade de produtos que será inserido: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados dos produtos: ");
            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Informe o nome do " + (i+1) + " produto: ");
                string nome = Console.ReadLine();
                Console.Write("Informe o preco do " + (i+1) + " produto: ");
                double preco = double.Parse(Console.ReadLine());
                vect[i] = new Product(nome, preco);
            }
            double sum = 0.00;

            for (int i = 0; i < n; i++)
            {
                sum += vect[i].priceProduct;
            }

            double avg = sum / n;

            Console.WriteLine("Média de preço dos produtos é " + avg.ToString("F2"), CultureInfo.InvariantCulture);

            */

            /* ALUGUEL DE QUARTOS USANDO VETORES
             * 
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Cadastro[] vector = new Cadastro[10];

            for (int i = 0; i < n; i++)
            { 
                Console.WriteLine("Aluguel #" + (i+1)+ ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numQuarto = int.Parse(Console.ReadLine());
                vector[numQuarto] = new Cadastro(nome, email);
            }

            Console.WriteLine("");
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vector[i] != null)
                {
                    Console.WriteLine(i + ": " + vector[i]);
                }
            }
            */

            // int soma1 = Calculadora.Sum(2, 3, 4);
            // Console.WriteLine(soma1);


            /* USO DO FOREACH
            string[] vect = new string[] { "Jorge", "Antonio", "Claudio" };

            for (int i = 0; i < vect.Length; i++) 
            {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("---------------------------------------");

            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
            */

            /* USO DE LISTAS E SUAS FUNÇÕES/ INCLUINDO UM POUCO DE LAMBDA
             * 
            List<string> lista = new List<string>(); //criação da lista

            Console.WriteLine("Lista inicial: ");

            lista.Add("Maria"); //sempre insere na ultima posição da lista
            lista.Add("Carlos");
            lista.Add("Paulo");
            lista.Add("Ana");
            //lista.Insert(3, Console.ReadLine()); //é possível escolher a posição que será inserida na lista
            //lista.Insert(4, Console.ReadLine());
            //lista.Insert(1, Console.ReadLine());
            Console.WriteLine("----------------------------------");

            foreach (string obj in lista) //laço de repetição para imprimir os dados da lista
            {   
                Console.WriteLine(obj);
            }

            Console.WriteLine("");

            Console.WriteLine("Total da lista: " + lista.Count); //conta o total da lista

            Console.WriteLine("---------------------------------------");

            string s1 = lista.Find(x => x[0] == 'C'); //Localiza o primeiro elemento que satisfaça a condição lambda
            Console.WriteLine("Primeiro 'C': " + s1);

            string s2 = lista.FindLast(x => x[0] == 'A'); //Localiza o ultimo elemento que satisfaça a condição lambda
            Console.WriteLine("Ultimo 'A': " + s2);

            int pos = lista.FindIndex(x => x[0] == 'M'); //Localiza a posição do primeiro elemento que satisfaça a condição lambda
            Console.WriteLine("Primeira Posição 'M': " + pos);

            int pos2 = lista.FindLastIndex(x => x[0] == 'P'); //Localiza a posição do ultimo elemento que satisfaça a condição lambda
            Console.WriteLine("Ultima Posição 'P': " + pos2);

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Lista com somente elementos que tenham tamanho 5: ");

            List<string> lista2 = lista.FindAll(x => x.Length == 5); //retorna todos os elementos que satisfaçam a condição
            foreach(string obj in lista2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Lista com -1: ");

            lista.Remove("Paulo"); //remove o elemento da lista
            foreach(string obj in lista)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Lista com -1: ");

            lista.RemoveAll(x => x[0] == 'A'); //remove todos que satisfaçam a condição lambda
            foreach(string obj in lista)
            {
                Console.WriteLine(obj);
            }

            lista.RemoveAt(1);
            foreach(string obj in lista)
            {
                Console.WriteLine(obj);
            }
            */

            /* USO DE MATRIZ E SUAS FUNÇÕES DE FORMA SIMPLES
             * 
            int[,] mat = new int[2, 3];

            Console.WriteLine(mat.Length);

            Console.WriteLine(mat.Rank);

            Console.WriteLine(mat.GetLength(0));

            Console.WriteLine(mat.GetLength(1));
            */


            /* USO DE MATRIZ COMPLETO
             * 
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine();
            Console.Write("Diagonal principal: ");

            for (int i = 0; i < n; i++)
            { 
                Console.Write(mat[i, i] + " ");
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Numeros negativos: " + count);

            */


            /* USO DE SWITCH CASE
             * 
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("Um!");
                    break;
                case 2:
                    Console.WriteLine("Dois!");
                    break;
                case 3:
                    Console.WriteLine("Três!");
                    break;
                default:
                    Console.WriteLine("Inválido!");
                    break;
            }
            */


        }
    }
}