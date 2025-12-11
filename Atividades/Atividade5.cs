//Criar uma lógica que identifique se o número digitado é primo ou não 
namespace Atividade5;
public class Program
{
    public static void Main()
    {
        int i = 0;
        int contagem = 0;
        Console.WriteLine("Digite um número até 2bi: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        do
        {

            i++;
            int mod = num2 % i;
            if (mod == 0)
            {
                contagem++;
            }

        }
        while (i <= num2);
        Console.WriteLine($"\nDivisores encontrados: {contagem}");
        if (contagem == 2)
        {
            Console.WriteLine("\nO número é primo");
        }
        else
        {
            Console.WriteLine("\nO número não é primo");
        }
    }
}
