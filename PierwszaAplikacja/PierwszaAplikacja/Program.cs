using PierwszaAplikacja;

var employee = new Employee("Miko³aj", "Szulc");
employee.AddGrade(12.53);
employee.AddGrade(6636463463636);
employee.AddGrade(6);



var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

SetSmth(out statistics);

void SetSmth (out Statistics statistics)
{
    statistics = new Statistics();
}