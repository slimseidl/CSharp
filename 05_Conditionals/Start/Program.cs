
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


// Using switch for multiple if statements
// Can combine multiple cases into one
//switch (age)
//{
//    case < 18:
//    case > 65:
//        Console.WriteLine("Not within the age range we're looking for.");
//        break;
//    //case > 65:
//    //    Console.WriteLine("This applicant is over the age threshold for hire");
//    //    break;
//    case 42:
//        Console.WriteLine("Wow, exactly what we're looking for");
//        break;
//    default:
//        Console.WriteLine("Great, you can continue");
//        break;
//}

// More switch practice
Console.WriteLine("Choose from the following menu: ");
Console.WriteLine("1. Add employee");
Console.WriteLine("2. Update employee");
Console.WriteLine("3. Delete employee");
string selectedAction = Console.ReadLine();

switch (selectedAction)
{
    case "1":
        Console.WriteLine("Adding new empployee to database");
        break;
    case "2":
        Console.WriteLine("Updating employee in database");
        break;
    case "3":
        Console.WriteLine("Deleting employee");
        break;
    default:
        Console.WriteLine("Invalid selection");
        break;
}



Console.ReadLine();

