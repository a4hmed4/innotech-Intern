using System.Diagnostics;
using System.Globalization;
using System.Text;

Console.WriteLine("Hello! Please enter the maximum number you need to write");

string? maximumNumberFromUser;
maximumNumberFromUser = Console.ReadLine();

int maximumNumber;
maximumNumber = Convert.ToInt32(maximumNumberFromUser);

string numbers = string.Empty;


Stopwatch stopwatch = Stopwatch.StartNew();

//O(n^2) time complexity
//كل مرة بنعمل نسخه جديدة وبنستهلك كتيير من الذاكرة

for (int i = 1; i <= maximumNumber; i++)
{
    //numbers = numbers + i.ToString() + ",";
    //numbers = $"{numbers}{i},";
    numbers += i;

    if (i < maximumNumber)
        numbers += ",";

}




stopwatch.Stop();

Console.WriteLine(numbers);
Console.WriteLine($"old approach, elapsed seconds = {stopwatch.Elapsed.TotalSeconds}");


Console.WriteLine("--------------------------------------------------");

stopwatch.Restart();
StringBuilder numbersNewApproach = new StringBuilder();

//O(n) time complexity using StringBuilder
// ال StringBuilder بيعمل نسخة وحدة من الذاكرة وبيضيف عليها كل مرة وبيكون mutable عن ال string بيكون immutable
// ال stringBuilder بيكون عبارة عن array of characters بعملها مرة واحدة واعدل عليها براحتي بتبقي linkedlist of characters


for (int i = 1; i <= maximumNumber; i++)

    numbersNewApproach.Append($"{i},");

if (maximumNumber > 0)
    numbersNewApproach.Remove(numbersNewApproach.Length - 1, 1); 

stopwatch.Stop();

Console.WriteLine(numbersNewApproach);
Console.WriteLine($"new approach, elapsed seconds = {stopwatch.Elapsed.TotalSeconds}");