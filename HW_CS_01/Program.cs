// HW_CS_01

// Task 1
// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2) 
    Console.WriteLine($"Maximum number is {num1} and minimum number is {num2}.");
else if(num1 == num2)
    Console.WriteLine("The numbers are the same.");
else
    Console.WriteLine($"Maximum number is {num2} and minimum number is {num1}.");
*/


// Task 2
// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int Max = num1;

if(Max < num2)  Max = num2;
if(Max < num3)  Max = num3;

Console.Write("Maximum number is " + Max);
*/


// Task 3
// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input a number: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int Num = userNum;

if (Num % 2 == 0)
Console.WriteLine("The number is even!");
else Console.WriteLine("The number is odd!");
*/


// Task 4
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Input a positive number ");
int numN = Convert.ToInt32(Console.ReadLine());

int curNum = 2;

while (curNum <= numN)
{
    Console.Write(curNum + " ");
    curNum = curNum + 2;
}
*/