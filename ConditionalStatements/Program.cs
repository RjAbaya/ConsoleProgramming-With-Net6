// See https://aka.ms/new-console-template for more information


/*Console.WriteLine("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

//if statement
if (num1 > num2)
{
    Console.WriteLine($"{num1} is greater than {num2}");
}
else if (num1 < num2)
{
    Console.WriteLine($"{num1} is less than {num2}");
}
else if (num1 == num2)
{
    Console.WriteLine($"{num1} is the same as {num2}");
}
else
{
    Console.WriteLine("Invalid input");
}


Console.WriteLine("Enter final grade: ");
int grade = Convert.ToInt32(Console.ReadLine());   
//switch statement
switch (grade)
{
    case int n when n >= 0 && n <= 59:
        Console.WriteLine("You failed");
        break;
    case int n when n >= 60 && n <= 100:
        Console.WriteLine("You passed");
        break;
    case 101:
        Console.WriteLine("Single Case Example");
        break;
    default:
        Console.WriteLine("INvalid grade");
        break;
}

//ternary operator
Console.WriteLine("How many apples you have?");
int numberOfApples = Convert.ToInt32(Console.ReadLine());  

Console.WriteLine("How many oranges you have?");
int numberOfOranges = Convert.ToInt32(Console.ReadLine());

var message = numberOfApples > numberOfOranges ? "You have more Apples" : "You have more Oranges";
Console.WriteLine(message);
*/

//for loop
/*for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);

}*/
/*int n = 0;

while (n < 5)
{
    Console.WriteLine("Input a number");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Your entered {n}: ");
}*/

/*int n = 0;

do
{
    Console.WriteLine("Input a number");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Your entered {n}: ");
} while (n < 5);*/

/*foreach (var item in collection)
{

}*/

//void functions 

void PrintName()
{
    Console.WriteLine("Jowena Abaya");
}


PrintName();

void Addition(int num1, int num2, int num3)
{
    Console.WriteLine($"The sum of {num1}, {num2} and {num3} is {num1 + num2 + num3}");
}

int LargestNumber(int num1, int num2, int num3)
{
    int largest = num1;
    
    if(largest < num2)
    {
        largest = num2;
    }
    
    if (largest < num3)
    {
        largest = num3;
    }
    return largest;
}

Console.WriteLine("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());


Addition(number1, number2, number3);
Console.WriteLine("End of Void Function");

int result = LargestNumber(number1, number2, number3);
Console.WriteLine($"The largest number is {result}");