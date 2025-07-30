

//using BethanysPieShopHRM;

//Console.WriteLine("Creating an employee");
//Console.WriteLine("--------------------\n");

//Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);


//bethany.DisplayEmployeeDetails();

//bethany.PerformWork();
//bethany.PerformWork();
//bethany.PerformWork(5);
//bethany.PerformWork();

//double receivedWageBethany = bethany.ReceiveWage(true);
//Console.WriteLine($"Wage paid (message from Program): {receivedWageBethany}");

//bethany.firstName = "John";
//bethany.hourlyRate = 10;

//bethany.DisplayEmployeeDetails();
//bethany.PerformWork();
//bethany.PerformWork(12);
//bethany.PerformWork();
//bethany.ReceiveWage();


//Console.WriteLine("Creating an employee");
//Console.WriteLine("--------------------\n");

//Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30);

//george.DisplayEmployeeDetails();
//george.PerformWork();
//george.PerformWork();
//george.PerformWork(3);
//george.PerformWork();
//george.PerformWork(8);

//var receivedWageGeorge = george.ReceiveWage(true);

//// basic method with return statement
//public int addTwoNumbers(int a, int b)
//{
//    if (a > b)
//    {
//        return a + b;
//    }
//    return 1;
//}

//Console.WriteLine(addTwoNumbers(4, 3));
//Console.ReadLine();

// If method just writes a line to the console, doesn't need a return statement
// Use void tag instead

//void displaySum(int a, int b)
//{
//    int sum = a + b;
//    Console.WriteLine(sum);
//}

////Calling the method
//displaySum(1, 2);
//displaySum(177, 42);

//Console.ReadLine();


// more method practice

//using BethanysPieShopHRM;

//Console.WriteLine("Enter employees monthly wage: ");
//int amount = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter number of months worked: ");
//int months = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter the bonus: ");
//int bonus = int.Parse(Console.ReadLine());


////static int calculateWage(int monthlyWage, int numberOfMonthsWorked)
////{
////    // $ like an f string in python
////    //Console.WriteLine($"Yearly Wage: {monthlyWage * numberOfMonthsWorked}");
////    //return monthlyWage * numberOfMonthsWorked;
////    if (numberOfMonthsWorked == 12) // bonus! 
////    {
////        return monthlyWage * (numberOfMonthsWorked + 1);
////    }
////    return monthlyWage * numberOfMonthsWorked;
////}

//int yearlyWage = Utilities.CalculateWage(amount, months, bonus);
//Console.WriteLine($"The annual salary for this employee is ${yearlyWage}");


//Console.ReadLine();

// String functions
//Console.WriteLine("Please enter your first name");
//string firstName = Console.ReadLine();
//Console.WriteLine("Please enter your last name");
//string lastName = Console.ReadLine();

//string username = string.Concat(firstName.ToLower().Substring(0, 1), lastName.ToLower(),"@hrydousa.com");
//Console.WriteLine($"Your new username is: {username}");
//Console.WriteLine(username.Length);

//if (username.Contains("ashole"))
//{
//    string NewUser = username.Replace("ashole",string.Concat(firstName,".",lastName));
//    Console.WriteLine(NewUser);
//}
//Console.ReadLine();


Console.WriteLine("Enter the wage");
string wage = Console.ReadLine();

int wageValue;

if (int.TryParse(wage, out wageValue))
    Console.WriteLine("Parse Successful : " + wageValue);
else
{
    Console.WriteLine("Parse Failed");
}

Console.WriteLine("{0} {1}", float.MinValue, byte.MaxValue);

Console.ReadLine();



