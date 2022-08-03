// See https://aka.ms/new-console-template for more information

string fullName = string.Empty;
int age;
double salary;
char gender = char.MinValue;
bool working = false;

//Prompt user for input

Console.Write("Please enter your name: ");
fullName = Console.ReadLine();

Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary: ");
salary = Convert.ToDouble(Console.ReadLine());

Console.Write("Please enter your gender, (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working: (True or False)");
working = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine($"Your name is {fullName}, you are {age} years old and you are a {gender}. You have a salary of {salary}, and {working}.");