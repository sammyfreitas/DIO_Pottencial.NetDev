/*
-------------------------------------------------------------------------
Desafios de Código Intermediário C# - Pottencial
2 / 3 - Aumento de Salário
-------------------------------------------------------------------------
 Básico
 Princípios Básicos
-------------------------------------------------------------------------

Desafio
-------------------------------------------------------------------------
A corrida de tartarugas é um esporte que cresceu muito nos últimos anos, fazendo com que vários competidores se dediquem a capturar tartarugas rápidas, e treina-las para faturar milhões em corridas pelo mundo. Porém a tarefa de capturar tartarugas não é uma tarefa muito fácil, pois quase todos esses répteis são bem lentos. Cada tartaruga é classificada em um nível dependendo de sua velocidade:


Nível 1: Se a velocidade é menor que 10 cm/h .
Nível 2: Se a velocidade é maior ou igual a 10 cm/h e menor que 20 cm/h .
Nível 3: Se a velocidade é maior ou igual a 20 cm/h .

Sua tarefa é identificar qual o nível de velocidade da tartaruga mais veloz de um grupo.									

Entrada
-------------------------------------------------------------------------
A entrada consiste de múltiplos casos de teste, e cada um consiste em duas linhas: A primeira linha contém um inteiro L (1 ≤ L ≤ 500) representando o número de tartarugas do grupo, e a segunda linha contém L inteiros Vi (1 ≤ Vi ≤ 50) representando as velocidades de cada tartaruga do grupo.

Saída
-------------------------------------------------------------------------
Para cada caso de teste, imprima uma única linha indicando o nível de velocidade da tartaruga mais veloz do grupo.


Exemplo de Entrada					Exemplo de Saída
10									
10 10 10 10 15 18 20 15 11 10		3
10									
1 5 2 9 5 5 8 4 4 3					1
10
19 9 1 4 5 8 6 11 9 7				2

*/

using System;

class Desafio {
  public static void Main() {
    int quantidadeEntradas = 3;
      
    while (quantidadeEntradas > 0) {
      //Console.WriteLine("Digite a quantidade de tartarugas: ");
      var numeroQuantidade = Int32.Parse(Console.ReadLine());
        
      if (numeroQuantidade >= 1 && numeroQuantidade <= 500) {
        //Console.WriteLine("Digite as velocidades separadas por espaço: ");
        string[] tartarugas = Console.ReadLine().Split(" ");
        var maiorVelocidade = Int32.Parse(tartarugas[0]);
          
// TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (int i = 0; i < tartarugas.Length; i++) {
          var tartaruga = Int32.Parse(tartarugas[i]);
            
          if (maiorVelocidade < tartaruga) {
            maiorVelocidade = tartaruga;
          }
        }
        //Console.WriteLine("Nível da tartaruga mais rápida: ");
        if(maiorVelocidade < 10) {
          Console.WriteLine(1);
        } else if (maiorVelocidade >= 10 && maiorVelocidade < 20) {
          Console.WriteLine(2);
        } else if (maiorVelocidade >= 20) {
          Console.WriteLine(3);
        }
        quantidadeEntradas--;
      } else {
        Console.WriteLine("Insira um número entre 1 e 500");
      }
    }
  }
}