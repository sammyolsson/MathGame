Console.WriteLine("Please type your name");
var name = Console.ReadLine();
var date = DateTime.UtcNow;

Console.WriteLine("----------------------------------------");
Console.WriteLine($"Hello {name}. It's {date}. This is your math's game. That's great that you are working on improving yourself");
Console.WriteLine("\n");
Console.WriteLine($@"What game whould you like to play today? Choose from the options below:
A - Addition
S - Subtracion
M - Multiplication
D - Divison
Q - Quit the program");
Console.WriteLine("----------------------------------------");
