// Compute the Average
Console.WriteLine("Compute the Average\n");

Console.WriteLine("Enter the number of times you want to add:");
int t = int.Parse(Console.ReadLine());
float sum = 0;
for (int i = 1; i <= t; i++) {
    Console.WriteLine("Enter integer #" + i + ":");
    int number = int.Parse(Console.ReadLine());
    sum += (float)number;
}

Console.WriteLine("The average is:" + (sum/(float)t));