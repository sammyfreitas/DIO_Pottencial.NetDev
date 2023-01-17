/*
-------------------------------------------------------------------------
Desafios de Código Intermediário C# - Pottencial
1 / 3 - Elemento Majoritário
-------------------------------------------------------------------------
 Básico
 Ordenação
-------------------------------------------------------------------------

Desafio
-------------------------------------------------------------------------
Dado um array nums de tamanho n, retorne o elemento majoritário, isto é, o elemento que aparece o maior número de vezes no seu array.

Entrada
-------------------------------------------------------------------------
A primeira linha da entrada deverá ser o número referente ao tamanho do seu array. As demais linhas nums serão os valores da sua array.

Saída
-------------------------------------------------------------------------
A saída deverá retornar o número que aparece o maior número de vezes na sua array, ou seja, o elemento majoritário.

Exemplo 1
-------------------------------------------------------------------------
Entrada		Saída
3			7					
7			
5
7											

Exemplo 2
-------------------------------------------------------------------------
Entrada		Saída
9			2
2
1
1
1
2
2
2
1
2

*/

using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(String[] args)
    {
        //Console.WriteLine("Digite a quantidade de números: ");
        int n = int.Parse(Console.ReadLine());
        int[] num = new int[n];
    
// TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (int i = 0; i < num.Length; i++)
        {
            //Console.WriteLine("Digite o número: ");
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(MajorityElement(num));
        
    }
    public static int MajorityElement(int[] nums)
    {
        int major = nums[0];
        int count = 0;
        int auxcount = 0;
        for (int i = 0; i < nums.Length; i++)
        {
           for (int j = 0; j < nums.Length; j++){
                if(nums[i] != major){
                    if(nums[i] == nums[j]){
                      count++;
                    }
                }
            }
            if (count > auxcount){
                major = nums[i];
                auxcount = count;
                count = 0;
            }
        }
        return major;
    }
}