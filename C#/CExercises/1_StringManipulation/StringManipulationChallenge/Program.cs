// See https://aka.ms/new-console-template for more information
public class Program
{
	public static void Main(string[] args)
	{	
		string userInputString;	//this will hold your users message
		int elementNum;		//this will hold the element number within the messsage that your user indicates
		char char1;			//this will hold the char value that your user wants to search for in the message.
		string fName;		//this will hold the users first name
		string lName;		//this will hold the users last name

		//user input for message and integer value
		Console.WriteLine("Please enter your message and press 'Enter'.");
		userInputString = Console.ReadLine();
		Console.WriteLine("Please enter a number LESS THAN the length of your string and press 'Enter'.");
		elementNum = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter the letter you want the Console to search for.");
		char1 = char.Parse(Console.ReadLine());
		Console.WriteLine("Enter your first name.");
		fName = Console.ReadLine();
		Console.WriteLine("Enter your last name.");
		lName = Console.ReadLine();

		string upper = StringToUpper(userInputString);
		string lower = StringToLower(userInputString);
		string trim = StringTrim(userInputString);
		string substring = StringSubstring(userInputString, elementNum);
		int search = SearchChar(userInputString, char1);
		string concat = ConcatNames(fName, lName);

		Console.WriteLine("StringToUpper: " + upper);
		Console.WriteLine("StringToLower: " + lower);
		Console.WriteLine("StringTrim: " + trim);
		Console.WriteLine("StringSubstring: " + substring);
		Console.WriteLine("SearchChar: " + search);
		Console.WriteLine("ConcatNames: " + concat);
	}

	public static string StringToUpper(string x){
		x = x.ToUpper();
		return x;
	}

	public static string StringToLower(string x){
		x = x.ToLower();
		return x;
	}

	public static string StringTrim(string x){
		x = x.Trim();
		return x;
	}

	public static string StringSubstring(string x, int elementNum){
		x = x.Substring(elementNum);
		return x;
	}

	public static int SearchChar(string userInputString, char x){
		int search = userInputString.IndexOf(x);
		return search;
	}

	public static string ConcatNames(string fName, string lName){
		string concat = String.Concat(fName, lName);
		return concat;
	}
}//end of program