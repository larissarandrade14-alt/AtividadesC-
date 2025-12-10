
//Criar uma lógica que lê uma sequência de 10 números e mostra quantos deles são pares.
namespace Ativ_pares;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("=======Número Par=========");
        int contagem = 0;
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Digite o {i}º número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                contagem++;
            }

        }
        Console.WriteLine("A quantidade de números pares é: " + contagem);
    }
}