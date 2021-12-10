/* Tipos de triângulo
Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o
lado A representa o maior dos 3 lados. A seguir, determine o tipo de triângulo que estes 
três lados formam, com base nos seguintes casos, sempre escrevendo uma mensagem adequada:

se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO
se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES
Entrada
A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B (0 < B) e C (0 < C).

Saída
Imprima todas as classificações do triângulo especificado na entrada.*/

using System;
using System.Collections.Generic;

namespace desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> ordem = new List<double>();
            string[] s = Console.ReadLine().Split(' ');
            ordem.Add(double.Parse(s[0]));
            ordem.Add(double.Parse(s[1]));
            ordem.Add(double.Parse(s[2]));
            ordem.Sort();
            ordem.Reverse();
            if (ordem[0] >= (ordem[1] + ordem[2]))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if (Math.Pow(ordem[0], 2) == (Math.Pow(ordem[1], 2) + Math.Pow(ordem[2], 2)))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (Math.Pow(ordem[0], 2) > (Math.Pow(ordem[1], 2) + Math.Pow(ordem[2], 2)))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if (Math.Pow(ordem[0], 2) < (Math.Pow(ordem[1], 2) + Math.Pow(ordem[2], 2)))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if (ordem[0] == ordem[1] && ordem[0] == ordem[2] && ordem[1] == ordem[2])
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            if ((ordem[0] == ordem[1] && ordem[1] != ordem[2]) || (ordem[1] == ordem[2] && ordem[2] != ordem[0]) || (ordem[2] == ordem[0] && ordem[1] != ordem[0]))
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
