// Comparing Numbers
Console.WriteLine("Comparing Numbers\n");

Console.WriteLine("Enter integer X variable");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Enter integer Y variable");
int y = int.Parse(Console.ReadLine());

if ( x > y ) { Console.WriteLine("X is greater than Y"); }
else if ( x < y ) { Console.WriteLine("X is less than Y"); }
else { Console.WriteLine("X is equal to Y"); }