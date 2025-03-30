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

var gameSelected = Console.ReadLine();

if (gameSelected.Trim().ToLower() == "a")
{
    Console.WriteLine("You have selected Addition game");
}
else if (gameSelected.Trim().ToLower() == "s")
{
    Console.WriteLine("You have selected Subtraction game");
}
else if (gameSelected.Trim().ToLower() == "m")
{
    Console.WriteLine("You have selected Multiplication game");
}
else if (gameSelected.Trim().ToLower() == "d")
{
    Console.WriteLine("You have selected Division game");
}
else if (gameSelected.Trim().ToLower() == "q")
{
    Console.WriteLine("Goodbye");
    Environment.Exit(1);
}
else
{
   Console.WriteLine("Invalid selection. Please try again!");
}
