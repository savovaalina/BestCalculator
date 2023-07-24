using BestCalculator;

Console.WriteLine("******************* Calculator ****************");


Calculations calculations = new Calculations();

Console.WriteLine("Enter two numbers");
double num1 = Convert.ToDouble(Console.ReadLine());
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("*************************************************");

Console.WriteLine("Enter symbol (+,-,*,/):\n");
string symbol = Console.ReadLine();

Console.WriteLine("*****************************************************");
switch (symbol)
{
    case "+":
        calculations.Addition(num1, num2);

        break;
    case "-":
        calculations.Substraction(num1, num2);
        break;

    case "*":
        calculations.Multiplication(num1, num2);
        break;

    case "/":
        calculations.Division(num1, num2);
        break;

     default:
        break;
}