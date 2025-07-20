// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Ahmed! Please enter the maximum number you need to add");

string? maximumNumberFromUser;

maximumNumberFromUser = Console.ReadLine();
//TODO:: add validation for the maximumNumber 

int maximumNumber;

maximumNumber = Convert.ToInt32( maximumNumberFromUser);

//maximumNumber = char.Parse(maximumNumberFromUser);


Console.WriteLine($"Are you sure need to get its addition up to {maximumNumberFromUser}?");


int sum = 0;

//O(n) time complexity
for (int i = 1; i <= maximumNumber; i++)
{
    //Console.WriteLine($"The current number is {i}, old sum is {sum}");

    sum = sum + i;

    //Console.WriteLine($"New sum is {sum}");
}

//O(c) constent time complexity
int seriesSum = maximumNumber * (maximumNumber + 1) / 2;


Console.WriteLine($"The sum of numbers from 1 to {maximumNumber} is {sum}");
Console.WriteLine($"The sum of numbers from 1 to {maximumNumber} is {seriesSum} using series form");

