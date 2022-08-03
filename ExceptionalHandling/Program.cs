// See https://aka.ms/new-console-template for more information

/*
    try - a try block attempts an operation
    catch - catch
    finally
    throw
 */

Console.WriteLine("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
try
{
    int quotient = num1 / num2;
    Console.WriteLine($"Result is: {quotient.ToString()}.");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Illegal Operation: {ex.Message}.");
}
catch (Exception ex)
{
    throw ex;   
}
finally
{
    Console.WriteLine("End of the program.");
}


