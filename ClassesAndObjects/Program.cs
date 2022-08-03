
Person person = new(); //Person person = new Person();

string middleName = string.Empty;

Console.Write("Enter First Name: ");
person.FirstName = Console.ReadLine();

Console.Write("Enter Last Name: ");
person.LastName = Console.ReadLine();

Console.Write("Enter Age: ");
person.Age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter salary: ");
int salary = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Middle Name: ");
middleName = Console.ReadLine();

if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine($"Full name: {person.getFullName()}");
}
else
{
    Console.WriteLine($"Full name: {person.getFullName(middleName)}");
}

person.setSalary(salary);

//Console.WriteLine($"First name is: {person.FirstName}");
//Console.WriteLine($"Last name is: {person.LastName}");

Console.WriteLine($"Age is: {person.Age}");
Console.WriteLine($"Year of birth is: {DateUtil.YearOfBirth(person.Age)}");
Console.WriteLine($"Salary is: {person.getSalary()}");

