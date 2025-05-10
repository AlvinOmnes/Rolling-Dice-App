Console.WriteLine("Simple Calculator");
Console.WriteLine("-----------------");

Console.Write("Enter first number: ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
double num2 = double.Parse(Console.ReadLine());

Console.Write("Enter an operator (+, -):");
string op = Console.ReadLine();

double result;

switch (op)
{
    case "+":
        result = num1 + num2;
        break;
    case "-":
        result = num1 - num2;
        break;
    default:
        Console.WriteLine("Invalid Operator");
        return;
}

Console.WriteLine("Result: " + result);