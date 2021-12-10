/*Sequência lógica 2
Você terá desafio de escrever um programa que leia dois valores X e Y. 
A seguir, mostre uma sequência de 1 até Y, passando para a próxima linha a cada X números.

Entrada
O arquivo de entrada contém dois valores inteiros, (1 < X < 20) e (X < Y < 100000).

Saída
Cada sequência deve ser impressa em uma linha apenas, com 1 espaço em branco 
entre cada número, conforme exemplo abaixo. Não deve haver espaço em branco 
após o último valor da linha.
*/

using System;
namespace desafio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);
            int cont = 1;

            for (int i = 1; i <= y; i++)
            {
                if (cont < x)
                {
                    Console.Write(i + " ");
                    cont++;
                }
                else
                {
                    Console.WriteLine(i);
                    cont = 1;
                }
            }
        }
    }
}
