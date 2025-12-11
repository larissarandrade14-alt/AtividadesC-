//Criar uma lógica que soma todos os números de 1 até N, onde N é informado pelo usuário.
namespace Atividade1;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("===== Soma dos números =======");
        Console.WriteLine("Digite um número: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        int soma = 0;
        do
        {
            i++;
            soma = soma + i;
        }
        while (i < N);
        Console.WriteLine($"A soma de todos os números de 1 até {N} é: {soma}");
    }
}
