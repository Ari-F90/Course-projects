
// See https://aka.ms/new-console-template for more information


// 1
/*Console.WriteLine("Introduce an amount in euros");
float euros = float.Parse(Console.ReadLine());
Console.WriteLine("Introduce the forex exchange for the day (usd dollars for 1 euro)");
float exchange = float.Parse(Console.ReadLine());
float dollars = euros * exchange;

Console.WriteLine($"You have {dollars} dollars");*/


// 2
/*Console.WriteLine("Calculator");
Console.WriteLine("1 - Sum");
Console.WriteLine("2 - Subtraction");
Console.WriteLine("3 - Multiplication");
Console.WriteLine("4 - Division");
Console.WriteLine("Choose an option: ");
string option = Console.ReadLine();

Console.WriteLine("Introduce the first number");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce the second number");
int num2 = int.Parse(Console.ReadLine());

switch (option)
{
  case "1":
    Console.WriteLine($"The result of the sum of {num1} and {num2} is {Sum(num1,num2)}");
    break;
  case "2":
    Console.WriteLine($"The result of the subtraction of {num1} and {num2} is {Subtraction(num1, num2)}");
    break;
  case "3":
    Console.WriteLine($"The result of the multiplication of {num1} and {num2} is {Multiplication(num1, num2)}");
    break;
  case "4":
    Console.WriteLine($"The result of the division of {num1} and {num2} is {Division(num1, num2)}");
    break;
  default:
    Console.WriteLine("The selected option is not valid");
    break;
}

static int Sum(int num1, int num2)
{
  return num1 + num2;
}

static int Subtraction(int num1, int num2)
{
  return num1 - num2;
}

static int Multiplication(int num1, int num2)
{
  return num1 * num2;
}

static float Division(int num1, int num2)
{
  return num1 / num2;
}*/

3
