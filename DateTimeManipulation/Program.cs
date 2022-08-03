// See https://aka.ms/new-console-template for more information

//Empty DataTime
using System.Globalization;

DateTime date = new DateTime();

//Create a DateTime from date and time
DateTime dateOfBirth = new DateTime(1988, 05, 16);
Console.WriteLine($"My date of birth is {dateOfBirth}.");
Console.WriteLine($"My DOB is: {dateOfBirth.Date}.");
Console.WriteLine($"My DOB is: {dateOfBirth.DayOfWeek}.");
Console.WriteLine($"My DOB is: {dateOfBirth.DayOfYear}.");
Console.WriteLine($"My DOB is: {dateOfBirth.TimeOfDay}.");
Console.WriteLine($"My DOB is: {dateOfBirth.Ticks}.");
Console.WriteLine($"My DOB is: {dateOfBirth.Kind}.");

//Create a DateTime from current timestamp
DateTime now = DateTime.Now; 
Console.WriteLine($"The time now is {now}");

//Create a DateTime from a String
DateTime dateFromString = DateTime.Parse("1/31/2021", CultureInfo.InvariantCulture);
Console.WriteLine($"The date from string is {dateFromString}");

//Add Additional Time
Console.WriteLine($"One hour from now is {now.AddHours(1)}.");
Console.WriteLine($"One hour from now is {now.AddDays(1)}.");

//Ticks from DateTime
Console.WriteLine($"Time as a numeral: {now.Ticks}.");

//Date Only
DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine($"The date of my DOB is {dateOnlyOfBirth}.");

//Time Only
TimeOnly timeOnly = TimeOnly.FromDateTime(now);
Console.WriteLine($"The time is {timeOnly}.");

