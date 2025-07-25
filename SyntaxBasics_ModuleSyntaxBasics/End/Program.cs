﻿See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("Welcome to Bethany's Pie Shop HRM");
//Console.WriteLine("Enter your name:");

//The following will accept the name
//string name = Console.ReadLine();

/*
    Here are some tests around working with valid identifiers in C#
    We can write here as much as we want, this is all comment
*/

//string name2 = Console.ReadLine();
// string name_2 = Console.ReadLine();
// string Name_2 = Console.ReadLine();

// string 2name = Console.ReadLine();

 // Can add commas to declare multiple vairables on one line
var monthlyWage = 1234;
int months = 12, bonus = 1000;


bool isActive = true;
double rating = 99.25;
// byte numberOfEmployees = 300;
// byte cannot be > 255

// Test
int hoursWorked;

hoursWorked = 125;

hoursWorked = 148;

//monthlyWage = true; already initialized as an int 

// const = constant = variable will NEVER change
const double interestRate = 0.07;
//interestRate = 0.08; compiler flags the error

// Creating a string
string firstName = "Bethany";
string lastName = "Smith";

string emptyString = "";

string s;

s = firstName;

int bonus = 1000;


// Operators
double ratePerHour = 12.34;
int numberOfHoursWorked = 165;

double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;

Console.WriteLine(currentMonthWage);

ratePerHour += 3;
Console.WriteLine(ratePerHour);

if (currentMonthWage > 2000)
    Console.WriteLine("Top paid employee");

int numberOfEmployees = 15;
numberOfEmployees--;
Console.WriteLine(numberOfEmployees);


// Checks the min and max value for an integer data type
int intMaxValue = int.MaxValue;
int intMinValue = int.MinValue;

char userSelection = 'a';

// Capitalizes the selection
char upperVersion = char.ToUpper(userSelection);

// Is it a digit?
bool isDigit = char.IsDigit(userSelection);
// Is it a letter? Returns True
bool isLetter = char.IsLetter(userSelection);


// Initializing a new date variable and outputting
DateTime hireDate = new DateTime(2022, 3, 28, 14, 30, 0);
Console.WriteLine(hireDate);

DateTime exitDate = new DateTime(2025, 12, 11);

//DateTime invalidDate = new DateTime(2025, 15, 11); month is not possible

// Adding 15 days to hire date for StartDate
DateTime startDate = hireDate.AddDays(15);
Console.WriteLine(startDate);

var currentDate = DateTime.Now;
bool areWeInDst = currentDate.IsDaylightSavingTime();

// Creating a start / end hour with a time span 
DateTime startHour = DateTime.Now;
TimeSpan workTime = new TimeSpan(8, 35, 0);
DateTime endHour = startHour.Add(workTime);

// Console.WriteLine(startHour);
// Console.WriteLine(endHour);

// Using a long date string for outputting as month full name 
Console.WriteLine(startHour.ToLongDateString());
Console.WriteLine(endHour.ToShortTimeString());

long veryLongMonth = numberOfHoursWorked;//works fine!

double d = 123456789.0;
int x = d; // will not work
int x = (int)d; // will work 


int intVeryLongMonth = (int)veryLongMonth;//might fail

Console.ReadLine();
