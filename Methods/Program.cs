// See https://aka.ms/new-console-template for more information

string firstName = "RJ";
string lastName = "Abaya";
DateTime date = DateTime.Now;

//Concatenation
Console.WriteLine(firstName + " " + lastName);

//String Length 
int length = firstName.Length;
Console.WriteLine(length);
Console.WriteLine($"Your first name has a {firstName.Length} letters.");

//Replace string parts
string newName = firstName.Replace('R', 'J');
Console.WriteLine($"Your new name is {newName}.");

//Append to string variable
string fullName = firstName +" " + lastName;
Console.WriteLine(fullName);

//Split String
string[] splitName = fullName.Split('a');
for (int i = 0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);
}

string nullString = null;
string emptyString = "";
string whiteSpaceString = " ";

//Compare Strings
if(string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("String is null");
}

if (firstName == lastName)
{
    Console.WriteLine("Names are equal");
}

if (firstName != lastName)
{
    Console.WriteLine("Names are not equal");
}

int comparisonResult = string.Compare(firstName, lastName);
if (comparisonResult == 0)
{
    Console.WriteLine("Names are equal");
}
else
{
    Console.WriteLine("Names are not equal");
}

//Convert String
string convertedString = string.Empty;
int number = 123456789;

convertedString = number.ToString();
Console.WriteLine(convertedString);