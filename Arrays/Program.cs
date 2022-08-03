// See https://aka.ms/new-console-template for more information

//Declared Fixed Size Array

// 5 space addresses
int[] grades = new int[5];

// Add values to the array
Console.WriteLine("Enter All Grades");
for (int i = 0; i < grades.Length; i++)
{
    Console.Write("Enter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

// Print values in Fixed Size Array
Console.WriteLine("The grades you have entered are");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine(grades[i]);
}

// Declare variables sized array
string[] studentNames = new string[5];

Console.WriteLine("Enter All Names");
for (int i = 0; i < studentNames.Length; i++)
{
    Console.Write("Enter names: ");
    studentNames[i] = Console.ReadLine();
}

Console.WriteLine("The names you have entered are");
for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine(studentNames[i]);
}