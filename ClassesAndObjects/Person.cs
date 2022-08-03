// See https://aka.ms/new-console-template for more information

//primitive data types
//int, string, char, double


//Object oriented programming - creating your own data types
// class - blueprint

//Single responsibility Principle

public class Person
{
    //Properties when Public
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    //Fields
    private double _salary { get; set; }

    public void setSalary(double salary)
    {
        _salary = salary;
    }

    public double getSalary()
    { 
        return _salary; 
    }

    public string getFullName()
    {
        return $"{FirstName} {LastName}";
    }

    public string getFullName(string middleName)
    {
        return $"{FirstName} {middleName} {LastName}";
    }
}