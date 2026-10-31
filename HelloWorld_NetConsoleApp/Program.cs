Console.WriteLine("What is your name?");
var name = Console.ReadLine();
Console.WriteLine("What is your last name?");
var last_name = Console.ReadLine();
var currentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Hello, {name} {last_name}, on {currentDate:d} at {currentDate:t}!");
Console.Write($"{Environment.NewLine}Press Enter to exit...");
Console.Read();