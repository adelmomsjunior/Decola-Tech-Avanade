/* O maior
Desenvolva um programa capaz de ler três valores e apresentar o maior deles 
e adicionar a mensagem “ eh o maior”. Use a seguinte forma como base:

MAIORAB = (a + b + Math.Abs(a - b)) / 2;

Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). 
Um segundo passo, portanto é necessário para chegar no resultado esperado.

Entrada
O arquivo de entrada contém três valores inteiros.

Saída
Imprima o maior dos três valores seguido pela mensagem " eh o maior".*/

using System;

namespace desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            var a = int.Parse(vet[0]);
            var b = int.Parse(vet[1]);
            var c = int.Parse(vet[2]);
            int d = (a + b + Math.Abs(a - b)) / 2;
            int MAIOR = (c + d + Math.Abs(c - d)) / 2;
            Console.WriteLine($"{MAIOR} eh o maior");
        }
    }
}
