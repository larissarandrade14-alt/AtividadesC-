namespace Tabuada10;
public class Program
{
	public static void Main()
	{
		Console.WriteLine("=======Tabuada========");
		Console.WriteLine("Digite um número: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		int i = 0;
		do
		{
			i++;
			Console.WriteLine($"{num1} x {i} = " + num1 * i);
		}
		while (i < 10);

	}
}