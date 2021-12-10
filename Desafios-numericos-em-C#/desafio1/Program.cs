/*Tipo de combustivel
Você recebeu desafio para determinar qual dos produtos é o preferêncial dos clientes 
de um posto de abastecimento de combustível. Para isso você deve escrever um algoritmo 
para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 
2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da 
faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido). O programa 
será encerrado quando o código informado for o número 4.

Entrada
A entrada contém apenas valores inteiros e positivos.

Saída
Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que 
abasteceram cada tipo de combustível, conforme exemplo.*/

using System;

namespace desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            var alc = 0;var gas = 0;var dis = 0;var op=0;
            do
            {
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                            alc++;
                            break;
                    case 2:
                            gas++;
                            break;
                    case 3:
                            dis++;
                            break;
                    case 4:
                            Console.WriteLine("MUITO OBRIGADO");
                            break;
                    default:
                        continue;
                }
            }while (op!= 4 );
            Console.WriteLine("Alcool: {0}", alc);
            Console.WriteLine("Gasolina: {0}", gas);
            Console.WriteLine("Diesel: {0}", dis);
        }
    }
}
