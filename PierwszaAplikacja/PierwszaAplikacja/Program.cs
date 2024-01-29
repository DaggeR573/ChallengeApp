using PierwszaAplikacja;

Employee employee1 = new Employee("Miko³aj", "Szulc", 25);
Employee employee2 = new Employee("Anakin", "Skywalker", 28);
Employee employee3 = new Employee("Darth", "Vader", 32);


employee1.AddPoints(7);
employee1.RemovePoints(2);

employee2.AddPoints(6);
employee2.RemovePoints(2);

employee3.AddPoints(5);
employee3.RemovePoints(2);



Console.WriteLine(employee1.Result);
Console.WriteLine(employee2.Result);
Console.WriteLine(employee3.Result);




