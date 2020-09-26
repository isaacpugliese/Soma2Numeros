using System;

namespace soma2numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;
            int resposta;

            Console.Write("primeiro valor: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("segundo valor: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            resposta = numero1 + numero2;

            Console.WriteLine($"A soma dos numeros é {resposta}");
        }
    }
}
