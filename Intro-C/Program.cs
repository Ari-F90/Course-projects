// See https://aka.ms/new-console-template for more information


// 1
/* int num1 = 2;
int num2 = 89;
int num3 = 23;
int result = num1 + num2 + num3;
Console.WriteLine(result);*/


// 2
/* Console.WriteLine("Hello! Please write two numbers in the next questions");
Console.WriteLine("Write number 1");
var num1 = Console.ReadLine(); 
Console.WriteLine("Write number 2");
var num2 = Console.ReadLine();

if (int.Parse(num1) > int.Parse(num2))
{
  Console.WriteLine("Number 1 is greater than number 2");
}
else if (int.Parse(num1) < int.Parse(num2))
{
  Console.WriteLine("Number 2 is greater than number 1");
}
else
{
  Console.WriteLine("Number 1 is equal to number 2");
}*/


// 3
/* Console.WriteLine("Hello! Please say which day of the week is today");
string today = Console.ReadLine();
today = today.ToUpper();

if (today == "SATURDAY" || today == "SUNDAY")
{
  Console.WriteLine("Today is weekend!");
}
else if (today == "MONDAY" || today == "TUESDAY" || today == "WEDNESDAY" || today == "THURSDAY" || today == "FRIDAY")
{
  Console.WriteLine("Today is not weekend!");
}
else
{
  Console.WriteLine("This day does not exist");
}*/


// 4 
/* Console.WriteLine("How much does the product cost?");
Console.WriteLine("Do you want to pay by cash or by card?");
string paymentMethod = Console.ReadLine();
paymentMethod = paymentMethod.ToUpper();
if (paymentMethod == "CARD")
{
  Console.WriteLine("Please write your card number");
  var account = Console.ReadLine();
  Console.WriteLine($"Your card number is {account}");
}*/


// 5 
/* for (int i = 1; i < 101; i++)
{
  Console.WriteLine(i);
}*/


// 6 
/* int i = 1;
while (i < 101)
{
  Console.WriteLine(i);
  i++;
}*/


// 7 
/* for (int i = 1; i < 101; i++)
{
  if (i % 2 == 0)
  {
    Console.WriteLine(i);
  }
}*/


// 8 
/* for (int i = 1; i < 101; i++)
{
  if (i % 2 == 0 || i % 3 == 0)
  {
    Console.WriteLine(i);
  }
}*/


// 9 
/* int[] numbers = new int[50];
int index = 0;
for (int i = 1; i < 101; i++)
{
  if (i % 2 == 0)
  {
    numbers[index] = i;
    index++;
  }
}

foreach (var number in numbers)
{
  Console.WriteLine(number);
}*/


// 10
/* var sumOdd = 0;
var sumEven = 0;
for (int i = 0; i < 10; i++)
{
Console.WriteLine("Enter a number");
var num = Console.ReadLine();
int numInt = int.Parse(num);
  if (numInt % 2 == 0)
  {
    sumEven += numInt;
  }
  else
  {
    sumOdd += numInt;
  }
}

Console.WriteLine($"The sum of even numbers is {sumEven}");
Console.WriteLine($"The sum of odd numbers is {sumOdd}");*/

// 11
/*Console.WriteLine("Enter a number from 1 to 7");
string numDay = Console.ReadLine();

switch (numDay)
{
  case "1":
    Console.WriteLine("It's Monday");
    break;
  case "2":
    Console.WriteLine("It's Tuesday");
    break;
  case "3":
    Console.WriteLine("It's Wedneday");
    break;
  case "4":
    Console.WriteLine("It's Thursday");
    break;
  case "5":
    Console.WriteLine("It's Friday");
    break;
  case "6":
    Console.WriteLine("It's Saturday");
    break;
  case "7":
    Console.WriteLine("It's Sunday");
    break;
  default:
    Console.WriteLine("Not a valid number");
    break;
};*/


// 12
/*Console.WriteLine("Introduce a number from 1 to 1000");
var numChosen = Console.ReadLine();
int num = int.Parse(numChosen);

if (num < 1 || num > 1000)
{
  Console.WriteLine("Please enter a correct number");
}

int count = 0;
for (int i = 1; i < num+1; i++)
{
  count += i;
}

Console.WriteLine($"The sum of the numbers is {count}");
Console.WriteLine($"The average number of the numbers is {count/num}");*/


// 13
/*Console.WriteLine("Introduce a number");
int num = int.Parse(Console.ReadLine());
int x = 0;

for (int i = 1; i < num + 1; i++)
{
  if (num % i == 0)
  {
    x++;
  }
}

if (x == 2)
{
  Console.WriteLine("It is a prime number");
}
else
{
  Console.WriteLine("It is not a prime number");
}*/


// 14
/*Console.WriteLine("Introduce a number");
int num = int.Parse(Console.ReadLine());
float numFloat = num;
int numData = 0;

while (numFloat > 0.5)
{
  numFloat = numFloat / 10;
  numData++;
}

Console.WriteLine($"The number has {numData} numbers");*/