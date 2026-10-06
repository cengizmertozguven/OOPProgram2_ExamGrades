Console.Write("Enter first exam grade: ");
double grade1 = double.Parse(Console.ReadLine());

Console.Write("Enter second exam grade: ");
double grade2 = double.Parse(Console.ReadLine());

Console.Write("Enter third exam grade: ");
double grade3 = double.Parse(Console.ReadLine());

double sum = grade1 + grade2 + grade3;
double average = sum / 3;

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Average: {average:F2}");
Console.WriteLine($"Average >= 60: {average >= 60}");