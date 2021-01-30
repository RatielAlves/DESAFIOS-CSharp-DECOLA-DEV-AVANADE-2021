/*Desafio
Você terá o desafio de ler um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. 

Entrada
O arquivo de entrada contém um valor inteiro.

Saída
Imprima a saída conforme exemplo fornecido.*/


using System;

class MinhaClasse {
  public static void Main (string[] args) {
    const int qtdDiasAno = 365; // Considerando quantidade de dias como definido no problema, sem anos bissextos 
    const int qtdDiasMes = 30; // Considerando quantidade de dias como definido no problema
    var idadeEmDias = int.Parse(Console.ReadLine());
    var anos = idadeEmDias / qtdDiasAno; // Implemente aqui o calculo dos anos
    var meses = (idadeEmDias % qtdDiasAno) / qtdDiasMes; // Implemente aqui o calculo dos meses 
    var dias = (idadeEmDias % qtdDiasAno) % qtdDiasMes; // Implemente aqui o calculo dos dias

    Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)");
  }
}