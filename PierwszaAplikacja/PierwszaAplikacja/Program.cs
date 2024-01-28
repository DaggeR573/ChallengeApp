using PierwszaAplikacja;

Employee employee1 = new Employee("Miko�aj", "Szulc", 25);
Employee employee2 = new Employee("Anakin", "Skywalker", 28);
Employee employee3 = new Employee("Adam", "Kamizelich", 32); 
//nie wiem ile Adam ma lat, wi�c tak� liczb� strzeli�em, mam nadziej�, �e sie nie obrazi :D

employee1.SetGrade(1);
employee1.SetGrade(2);
employee1.SetGrade(3);
employee1.SetGrade(4);
employee1.SetGrade(5);

employee2.SetGrade(6);
employee2.SetGrade(7);
employee2.SetGrade(8);
employee2.SetGrade(9);
employee2.SetGrade(10);

employee3.SetGrade(1);
employee3.SetGrade(3);
employee3.SetGrade(5);
employee3.SetGrade(7);
employee3.SetGrade(9);


List<Employee> employees  = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}

Console.WriteLine("Najlepszy wynik to " + employeeWithMaxResult.Result + " punkt�w.");
Console.WriteLine("Dane pracownika: ");
Console.WriteLine("Imi�: " + employeeWithMaxResult.FirstName);
Console.WriteLine("Nazwisko: " + employeeWithMaxResult.SecondName);
Console.WriteLine("Wiek: " + employeeWithMaxResult.Age);




