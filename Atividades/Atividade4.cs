//Criar uma lógica que exibe os números de 1 a 100, mas substitui os múltiplos de 3
//por “Fizz”, os múltiplos de 5 por “Buzz” e os múltiplos de ambos por “FizzBuzz”.
using System;

public class Class1
{
	public Class1()
	{
        Console.WriteLine("======= FizzBuzz =========");

        for (int i = 1; i <= 100; i++)
        {

            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else
            if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else { Console.WriteLine(i); }
        }
}
