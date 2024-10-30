//obs: utilizando array:
//Problema "negativos"
//Faça um programa que leia um número inteiro positivo N (máximo = 10) e depois N números inteiros
//e armazene-os em um vetor. Em seguida, mostrar na tela todos os números negativos lidos. 

using System.ComponentModel;

namespace NumerosNegativosVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("NUMEROS NEGATIVOS:");
            for (int i = 0; i < n; i++)
            {
                if (vet[i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }
        }
    }
}
