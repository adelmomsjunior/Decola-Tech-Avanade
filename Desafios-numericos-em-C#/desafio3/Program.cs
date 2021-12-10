﻿/*Validação de nota
Para ajudar a calcular as notas referentes às duas avaliações dos alunos, uma professora 
pediu para que você desenvolva um programa que calcule e imprima a média semestral. 
Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao 
intervalo [0,10]). Cada nota deve ser validada separadamente.

Entrada
A entrada contém vários valores reais, positivos ou negativos. O programa deve ser 
encerrado quando forem lidas duas notas válidas.

Saída
Se uma nota inválida  for lida, deve ser impressa a mensagem "nota invalida".
Quando duas notas válidas forem lidas, deve ser impressa a mensagem "media = " 
seguido do valor do cálculo. O valor deve ser apresentado com duas casas após o ponto decimal.*/

using System;
using System.Collections.Generic;

namespace desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota;
            double media;
            List<double> duasnotas = new List<double>(); 
            while(duasnotas.Count != 2)
            {
                try
                {
                    nota = double.Parse(Console.ReadLine());
                    if (nota < 0 || nota > 10) 
                    {
                        Console.WriteLine("nota invalida");
                    }
                    else
                    {
                        duasnotas.Add(nota);
                    }
                        
                }
                catch
                {
                        Console.WriteLine("nota invalida");
                }
            }
            media = (duasnotas[0] + duasnotas[1]) / duasnotas.Count;
            Console.WriteLine("media = {0}", media.ToString("F2"));
        }
    }
}