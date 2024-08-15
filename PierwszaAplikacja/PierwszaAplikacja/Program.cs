using PierwszaAplikacja;

var employee = new Employee("Miko³aj", "Szulc");
employee.AddGrade(1);
employee.AddGrade("2");
employee.AddGrade(3);

Console.WriteLine();

var statistics = employee.GetStatisticsWithFor();
var statistics1 = employee.GetStatisticsWithForeach();
var statistics2 = employee.GetStatisticsWithWhile();
var statistics3 = employee.GetStatisticsWithDoWhile();

Console.WriteLine("Results with For loop");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine();

Console.WriteLine("Results with Foreach loop");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine();

Console.WriteLine("Results with While loop");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine();

Console.WriteLine("Results with DoWhile loop");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");

