Console.WriteLine("Please enter a number between 1 and 10.");

int numEntry = int.Parse(Console.ReadLine());

if (numEntry > 0 && numEntry <= 10)
{
    Console.WriteLine("Valid entry.");
}
else
{
    Console.WriteLine("Invalid entry");
}

Console.WriteLine("Press any key to close.....");
Console.ReadLine();