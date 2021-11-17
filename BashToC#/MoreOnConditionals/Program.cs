// More on Conditionals
Console.WriteLine("More on Conditionals (Triangle)\n");

Console.WriteLine("Input integer for side 1");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Input integer for side 2");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Input integer for side 3");
int z = int.Parse(Console.ReadLine());

if ( x == y && x == z && y == z ) { Console.WriteLine("EQUILATERAL"); }
else if ( x != y && x != z && y != z ) { Console.WriteLine("SCALENE"); }
else { Console.WriteLine("ISOSCELES"); }
