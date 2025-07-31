/* Write a program to ask the user for input between 1 and 10
 * if valid input, write valid, else write invalid to the console */

//Console.WriteLine("Please enter a number between 1 and 10.");

//int numEntry = int.Parse(Console.ReadLine());

//if (numEntry > 0 && numEntry <= 10)
//{
//    Console.WriteLine("Valid entry.");
//}
//else
//{
//    Console.WriteLine("Invalid entry");
//}


// Exercise 2
// Write a program which takes two numbers from input and displays the max

//int num1 = int.Parse(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());

//int maxNum;

//if (num1 > num2)
//    maxNum = num1;
//else maxNum = num2;

//    Console.WriteLine($"The max value of your two numbers is: {maxNum}");

/* Write a program to ask the user to enter the width and height of an image
 * then tell if the orientation is landscape or portrait */
//  Exercise 3

//Console.WriteLine("Please enter the width of the image: ");
//double width = double.Parse(Console.ReadLine());

//Console.WriteLine("Please enter the height of the image: ");
//double height = double.Parse(Console.ReadLine());   

//if (width > height)
//    Console.WriteLine("Your image is in landscape orientation");
//else
//    Console.WriteLine("Your image is in portrait view");

// Exercise 4
/* Your job is to write a program for a speed camera. 
 * For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. 
 * Write a program that asks the user to enter the speed limit. 
 * Once set, the program asks for the speed of a car. 
 * If the user enters a value less than the speed limit, program should display Ok on the console. 
 * If the value is above the speed limit, the program should calculate the number of demerit points.
 * For every 5km/hr above the speed limit, 1 demerit points should be incurred 
 * and displayed on the console. If the number of demerit points is above 12, 
 * the program should display License Suspended. */

//Console.WriteLine("Please enter a speed limit:");
//int speedLimit = int.Parse(Console.ReadLine());

//Console.WriteLine("Please enter a speed:");
//int carSpeed = int.Parse(Console.ReadLine());

//if (carSpeed < speedLimit)
//    Console.WriteLine("OK");
//else
//{
//    const int overDemPoints = 5;
//    var points = (carSpeed - speedLimit) / overDemPoints;
//    if (points > 12)
//        Console.WriteLine("License Suspened");
//    else
//        Console.WriteLine($"Number of demerit points: {points}");
//}

// Loops 1
// Count nums between 1/100 divisible by 3 with no remainder

//var count = 0;
//for (var i = 1; i < 100; i++)
//    if (i % 3 == 0)
//        count++;
//Console.WriteLine($"There are {count} numbers between 1 and 100 divisible by 3");

// Loops 2 
/* Continuously ask user to input a number, or ok to exit
 * calculate sum of numbers and display it */

//var sum = 0;

//while (true)
//// while (true) continuously executes unless a break is used
//{
//    Console.WriteLine("Enter a number or 'ok' to exit:");
//    var input = Console.ReadLine();

//    if (input.ToLower() == "ok")
//        break;

//    sum += Convert.ToInt32(input);
//}
//Console.WriteLine($"The sum of all inputs is {sum}");


// Loops 3
/* Ask user to enter number. Computer factorial and print.
 * ex - user enters 5, program calcs 5 x 4 x 3 x 2 x 1 and displays as 5! = 120 */

//Console.WriteLine("Please enter a number");
//int number = int.Parse(Console.ReadLine());

//int product = 1;

//for (int i = 1; i <= number; i++)
//{
//    product *= i;
//}
//Console.WriteLine($"{number}! = {product}");


// Loops 4
/* Picks random num between 1 and 10. Give user 4 chances to guess. 
 * If right, "you won", else "You Lost" */

// Number Guessing Game

var number = new Random().Next(1, 100);


Console.WriteLine("Guess a number between 1 and 100");

for (var i =0; i < 5; i++)
{
    Console.WriteLine("Take a guess: ");
    var guess = int.Parse(Console.ReadLine());

    if (guess == number)
    {
        Console.WriteLine("\nYou won!\n");
        Console.ReadLine();
        return;
    }
    else if (guess > number)
        Console.WriteLine("\nLower\n");
    else
        Console.WriteLine("\nHigher\n");
}
Console.WriteLine($"You lost, the correct answer was {number}");



Console.WriteLine("Press any key to close.....");
Console.ReadLine();