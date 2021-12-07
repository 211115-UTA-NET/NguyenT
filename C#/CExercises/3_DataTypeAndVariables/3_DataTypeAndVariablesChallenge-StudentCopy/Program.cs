// See https://aka.ms/new-console-template for more information
public class Program
{
	public static void Main(string[] args)
	{
		byte myByte = 7;
		Console.WriteLine(myByte);
		sbyte mySbyte = -3; 
		Console.WriteLine(mySbyte);
		int myInt = 666;
		Console.WriteLine(myInt);
		uint myUint = 4000000000;
		Console.WriteLine(myUint);
		short myShort = -100;
		Console.WriteLine(myShort);
		ushort myUShort = 66;
		Console.WriteLine(myUShort);
		float myFloat = 6.666f;
		Console.WriteLine(myFloat);
		double myDouble = -2.420420;
		Console.WriteLine(myDouble);
		char myCharacter = 'H';
		Console.WriteLine(myCharacter);
		bool myBool = true;
		Console.WriteLine(myBool);
		string myText = "I control text";
		Console.WriteLine(myText);
		string numText = "42";
		Console.WriteLine(numText);
		//object newObject;
		Text2Num(myText);

	}

	public static void Text2Num(string x)
	{
		int num;
		Console.WriteLine("Can this string be converted into an integer?");
		Console.WriteLine("String value: " + x);
		bool conversion = int.TryParse(x, out num);
		if (conversion)
		{
			Console.WriteLine("Yes, it can!");
		}
		else {
            Console.WriteLine("No, it cannot!");
        }
	}
}