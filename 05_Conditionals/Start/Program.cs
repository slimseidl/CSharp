
Console.WriteLine("Enter the age of the applicant: ");
int age = int.Parse(Console.ReadLine());

//if ((age < 18) || (age > 35))
//{
//    if (age < 18)
//    {
//        Console.WriteLine("This applicant is too young for hire");
//        Console.WriteLine("Send rejection email");
//    }
//    else
//    {
//        Console.WriteLine("This applicant is over the age threshold for hire");
//        Console.WriteLine("Send rejection email");
//    }
//}
//else
//{
//    Console.WriteLine("Applicant may continue with the application");
//}

switch (age)
{
    case < 18:
        Console.WriteLine("This applicant is too young for hire");
        break;
    case > 65:
        Console.WriteLine("This applicant is over the age threshold for hire");
        break;
    case 42:
        Console.WriteLine("Wow, exactly what we're looking for");
        break;
    default:
        Console.WriteLine("Great, you can continue");
        break;
}

Console.ReadLine();

