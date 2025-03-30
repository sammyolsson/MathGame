Console.WriteLine("Please type your name");
var name = Console.ReadLine();
var date = DateTime.UtcNow;

Console.WriteLine("----------------------------------------");
Console.WriteLine($"Hello {name}. It's {date}. This is your math's game. That's great that you are working on improving yourself");
Console.WriteLine("\n");
Console.WriteLine($@"What game whould you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Divison
Q - Quit the program");
Console.WriteLine("----------------------------------------");

var gameSelected = Console.ReadLine();

if (gameSelected.Trim().ToLower() == "a")
{
   AdditionGame("You have selected Addition game");
}
else if (gameSelected.Trim().ToLower() == "s")
{
    SubtractionGame("You have selected Subtraction game");
}
else if (gameSelected.Trim().ToLower() == "m")
{
    MultipiplicationGame("You have selected Multiplication game");
}
else if (gameSelected.Trim().ToLower() == "d")
{
    DivisionGame("You have selected Division game");
    
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

void DivisionGame(string message)
{
    Console.WriteLine(message);
}

void MultipiplicationGame(string message)
{
    Console.WriteLine(message);
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);
}

void AdditionGame(string message) 
{
    Console.WriteLine(message);
}