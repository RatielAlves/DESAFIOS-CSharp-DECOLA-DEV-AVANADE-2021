/*Desafio
Você terá o desafio de ler um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma loja, e informe-o expresso no formato horas:minutos:segundos.

Entrada
O arquivo de entrada contém um valor inteiro N.

Saída
Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.*/



using System;

class MinhaClasse {
  public static void Main (string[] args) {
    int tempoTotalEmSegundos = int.Parse(Console.ReadLine());
    
    int quantidadeDeHoras = tempoTotalEmSegundos / 3600;
    int quantidadeDeMinutos = (tempoTotalEmSegundos % 3600) / 60;
    int quantidadeDeSegundos = (tempoTotalEmSegundos % 3600) % 60;
    
    Console.Write($"{quantidadeDeHoras}:{quantidadeDeMinutos}:{quantidadeDeSegundos}");
      
  }
}