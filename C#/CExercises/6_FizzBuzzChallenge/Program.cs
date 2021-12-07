// See https://aka.ms/new-console-template for more information
public class Program
{
	public static void Main(string[] args)
	{

        for (int i = 1; i <= 1000; i++)
        {
            if (i % 3 == 0)
            {
                if (i % 5 == 0) Console.WriteLine("FizzBuzz");
                else Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0) Console.WriteLine("Buzz");
            else Console.WriteLine(i);

        }

	}

}
