// See https://aka.ms/new-console-template for more information
public class Program
{
	public static void Main(string[] args)
	{

		int num1 = 5;
		int num2 = 3;
		bool test = false;

		Console.WriteLine("Result of Increment from " + num1 + ": " + Increment(num1));
		Console.WriteLine("Result of Decrement from " + num1 + ": " + Decrement(num1));
		Console.WriteLine("Not " + test + " is " + Not(test));
		Console.WriteLine("Negative " + num1 + " is " + Negate(num1));
		Console.WriteLine("Adding " + num1 + " to " + num2 + " is equal to " + Sum(num1,num2));
		Console.WriteLine("Subtracting " + num2 + " from " + num1 + " is equal to " + Diff(num1, num2));
		Console.WriteLine("Multiplying " + num1 + " and " + num2 + " is equal to " + Product(num1,num2));
		Console.WriteLine("Dividing " + num1 + " by " + num2 + " is equal to " + Quotient(num1,num2));
		Console.WriteLine("Dividing " + num1 + " by " + num2 + " has a remainder of " + Remainder(num1,num2));
		Console.WriteLine("The statement: " + num1 + " is not equal to 0, and in fact it is greater than " + num2 + " is " + And(num1,num2));
		Console.WriteLine("The statement: " + num1 + " is equal to " + num2 + ", or " + num1 + " is less than 0 is " + Or(num1,num2));
	}

	public static int Increment(int num) {

		num++;
		return num;

	}

	public static int Decrement(int num) {

		num--;
		return num;

	}

	public static bool Not(bool input) {

		input = !input;
		return input;

	}

	public static int Negate(int num){

		int negate = -num;
		return negate;

	}

	public static int Sum(int num1, int num2){

		int sum = num1 + num2;
		return sum;

	}

	public static int Diff(int num1, int num2){

		int diff = num1 - num2;
		return diff;

	}

	public static int Product(int num1, int num2){

		int prod = num1 * num2;
		return prod;

	}

	public static int Quotient(int num1, int num2) {

		int quot = num1 / num2;
		return quot;

	}

	public static int Remainder(int num1, int num2) {

		int rem = num1 % num2;
		return rem;

	}

	public static bool And(int num1, int num2){

		bool and = num1 != 0 && num1 > num2;
		return and;

	}

	public static bool Or(int num1, int num2){

		bool or = num1 == num2 || num1 < 0;
		return or;

	}

}

