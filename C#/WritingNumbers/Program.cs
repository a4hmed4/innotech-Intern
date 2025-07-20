using System.Diagnostics;
using System.Text;

Console.WriteLine("Hello! Please enter the maximum number you need to write");

string? maximumNumberFromUser;
maximumNumberFromUser = Console.ReadLine();

int maximumNumber;
maximumNumber = Convert.ToInt32(maximumNumberFromUser);

string numbers = string.Empty;

Stopwatch stopwatch = Stopwatch.StartNew();

//for (int i = 1; i <= maximumNumber; i++)

//    //numbers = numbers + i.ToString() + ",";
//    numbers = $"{numbers}{i},";
//    //Console.WriteLine(numbers); 

//stopwatch.Stop();

//Console.WriteLine(numbers);
//Console.WriteLine($"old approach, elapsed seconds = {stopwatch.Elapsed.TotalSeconds}");


//Console.WriteLine("--------------------------------------------------");

stopwatch.Start();
StringBuilder numbersNewApproach = new StringBuilder();


for (int i = 1; i <= maximumNumber; i++)
    numbersNewApproach.Append($"{i},");



stopwatch.Stop();

Console.WriteLine(numbersNewApproach);
Console.WriteLine($"new approach, elapsed seconds = {stopwatch.Elapsed.TotalSeconds}");