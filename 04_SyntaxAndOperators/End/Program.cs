
//int age = 23;

//// Return true if age = 23
//bool a = age == 23;

//Console.WriteLine("Age is 23: " + a);

//bool b = age > 24;
//Console.WriteLine("Age greater than 24: " + b);

//bool c = (age >= 18) && (age <= 65);
//Console.WriteLine("Age between 18 and 65: " + c);

Console.WriteLine("Please enter your age: ");
int age = int.Parse(Console.ReadLine());

// If statement practice, if age less than 18 or greater than 65 check
// can also use else if
// if there is only one statement, can omit curly braces
if ((age < 18) || (age > 65)) {
    if (age < 18)
    {
        Console.WriteLine("We cannot hire anyone under the age of 18.");
    }
    else
    {
        Console.WriteLine("We cannot hire anyone over the age of 65.");
    }
}
else
{
    Console.WriteLine("You are eligible to continue.");
}



Console.ReadLine();
