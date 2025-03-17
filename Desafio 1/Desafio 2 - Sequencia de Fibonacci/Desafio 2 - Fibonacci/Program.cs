using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Escreva um número de elementos iniciar a sequência de Fibonnaci: \b");
        // Informe no campo o número para determinar o limite do índice da sequência
        int numeroMaximo = int.Parse(Console.ReadLine());
        int numero = 0;
        int proximoNumero = 1;
       for (int i = 2; i <= numeroMaximo; i++)
        {
            int soma = numero + proximoNumero;
            Console.WriteLine($"O número da sequência é: {soma}. \b");
            numero = proximoNumero;
            proximoNumero = soma;
        }
      
    }
  

}