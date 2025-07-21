// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, Ahmed! Please enter the maximum number you need to add");

string? maximumNumberFromUser;

maximumNumberFromUser = Console.ReadLine();
//TODO:: add validation for the maximumNumber 

//int maximumNumber;


if (!int.TryParse(maximumNumberFromUser, out int maximumNumber) || maximumNumber <= 0)
{
    Console.WriteLine("Invalid number"); return;
}

//maximumNumber = Convert.ToInt32(maximumNumberFromUser);


Console.WriteLine($"Are you sure need to get its addition up to {maximumNumberFromUser}?");

Stopwatch stopwatch = Stopwatch.StartNew();

int sum = 0;

//O(n) time complexity
for (int i = 1; i <= maximumNumber; i++)
{
    //Console.WriteLine($"The current number is {i}, old sum is {sum}");

    sum = sum + i;

    //Console.WriteLine($"New sum is {sum}");
}
stopwatch.Stop();

Console.WriteLine($"The sum of numbers from 1 to {maximumNumber} is {sum} using loop approach");
Console.WriteLine($"Elapsed seconds = {stopwatch.Elapsed.TotalSeconds}");


stopwatch.Restart();
//O(c) constent time complexity
int seriesSum = maximumNumber * (maximumNumber + 1) / 2;

stopwatch.Stop();

Console.WriteLine($"The sum of numbers from 1 to {maximumNumber} is {seriesSum} using series form");
Console.WriteLine($"Elapsed seconds = {stopwatch.Elapsed.TotalSeconds}");


