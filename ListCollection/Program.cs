// See https://aka.ms/new-console-template for more information

//How to declare a list
List<string> names = new List<string>();
string name = string.Empty;

names.Add("RJ");

Console.WriteLine("Enter Names");

while (name != "-1")
{
    Console.Write("Enter Names: ");
    name = Console.ReadLine();
    if (!string.IsNullOrEmpty(name) && name != "-1")
    {
        names.Add(name);
        Console.WriteLine($"{name} was added successfully");
    }
}

//Print values
Console.WriteLine("Printing names via for loop");
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine("Printing names via a foreach loop");
foreach (string item in names)
{
    Console.WriteLine(item);
}