
//using BethanysPieShopHRM;

//Console.WriteLine("Welcome to Bethany's Pie Shop HRM");


//int amount = 1234;
//int months = 12;
//int bonus = 1000;

//int yearlyWage = Utilities.CalculateYearlyWage(amount, months);
//int yearlyWageWithBonus = Utilities.CalculateYearlyWage(amount, months, bonus);

//Console.WriteLine($"Yearly wage: {yearlyWage}");


//double amountDouble = 1500.0;
//double monthsDouble = 12;
//double bonusDouble = 1000;

//double yearlyWageWithBonusDouble = Utilities.CalculateYearlyWage(amountDouble, monthsDouble, bonusDouble);

//Utilities.UsingOptionalParameters();

//Utilities.UsingNamedArguments();

// Basic loop
//int i = 0;
//while (i < 10) 
//{
//    Console.WriteLine(i);
//    i++;
//}

//// While i is less than value input given
//Console.WriteLine("Enter a value: ");
//int max = int.Parse(Console.ReadLine());
//int i = 0;
//while (i < max)
//{
//    Console.WriteLine(i);
//    i++;
//}

//Console.WriteLine("Loop Complete");

// Loop around switch statement, makes user input a value to exit options
//Console.WriteLine("Choose from the following menu: ");
//Console.WriteLine("1. Add employee");
//Console.WriteLine("2. Update employee");
//Console.WriteLine("3. Delete employee");
//string selectedAction = Console.ReadLine();

//while (selectedAction != "99")
//{
//    switch (selectedAction)
//    {
//        case "1":
//            Console.WriteLine("Adding new empployee to database");
//            break;
//        case "2":
//            Console.WriteLine("Updating employee in database");
//            break;
//        case "3":
//            Console.WriteLine("Deleting employee");
//            break;
//        default:
//            Console.WriteLine("Invalid selection");
//            break;
//    }
//    Console.WriteLine("Choose from the following menu: ");
//    Console.WriteLine("1. Add employee");
//    Console.WriteLine("2. Update employee");
//    Console.WriteLine("3. Delete employee");
//    Console.WriteLine("99. Exit Menu");
//    selectedAction = Console.ReadLine();
//}
//Console.WriteLine("Closing application");

// For Loops
// for (initialize, boolean)
// for (int i =0, i < 10; i++)

//do While loops
//string selectedAction;
//do
//{
//    Console.WriteLine("Choose from the following menu: ");
//    Console.WriteLine("1. Add employee");
//    Console.WriteLine("2. Update employee");
//    Console.WriteLine("3. Delete employee");
//    selectedAction = Console.ReadLine();


//    switch (selectedAction)
//    {
//        case "1":
//            Console.WriteLine("Adding new empployee to database");
//            break;
//        case "2":
//            Console.WriteLine("Updating employee in database");
//            break;
//        case "3":
//            Console.WriteLine("Deleting employee");
//            break;
//        default:
//            Console.WriteLine("Invalid selection");
//            break;
//    }
//} while (selectedAction != "99");
//Console.WriteLine("Closing application");


// For loops 

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

Console.ReadLine();


