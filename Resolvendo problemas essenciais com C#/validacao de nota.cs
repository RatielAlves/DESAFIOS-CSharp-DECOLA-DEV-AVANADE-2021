/*Desafio
Para ajudar a calcular as notas referentes às duas avaliações dos alunos, uma professora pediu para que você desenvolva um programa que calcule e imprima a média semestral. Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente.

Entrada
A entrada contém vários valores reais, positivos ou negativos. O programa deve ser encerrado quando forem lidas duas notas válidas.

Saída
Se uma nota inválida  for lida, deve ser impressa a mensagem "nota invalida".
Quando duas notas válidas forem lidas, deve ser impressa a mensagem "media = " seguido do valor do cálculo. O valor deve ser apresentado com duas casas após o ponto decimal.*/


using System;

class Desafio {
  static void Main() {

    var n1 = float.Parse(Console.ReadLine());

    while (n1 > 10 || n1 < 0)
    {
      Console.WriteLine("nota invalida");
      n1 = float.Parse(Console.ReadLine());
    }

    var n2 = float.Parse(Console.ReadLine());

    while (n2 > 10 || n2 < 0)
    {
      Console.WriteLine("nota invalida");
      n2 = float.Parse(Console.ReadLine());
    }

    var media = (n1 + n2) / 2;
    string teste = media.ToString("N2");

    Console.WriteLine("media = " + teste);
  }
}