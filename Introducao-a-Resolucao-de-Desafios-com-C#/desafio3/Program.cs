/*Conversão de tempo
Você terá o desafio de ler um valor inteiro, que é o tempo de duração em segundos de 
um determinado evento em uma loja, e informe-o expresso no formato horas:minutos:segundos.

Entrada
O arquivo de entrada contém um valor inteiro N.

Saída
Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.
*/

using System;

namespace desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeInSeconds = int.Parse(Console.ReadLine());
            var hours = timeInSeconds / 3600;
            var minutes = (timeInSeconds - (hours * 3600)) / 60;
            var seconds = (timeInSeconds - (hours * 3600) - (minutes * 60));
            Console.WriteLine($"{hours}:{minutes}:{seconds}", hours, minutes, seconds);        
        }
    }
}
