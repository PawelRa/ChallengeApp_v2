using ChallengeApp_v2;

var employee = new Employee("Adam", "Kamizelich");

employee.AddGrade("22222");
employee.AddGrade("Adam");
employee.AddGrade(8);
employee.AddGrade(2);
employee.AddGrade(-2);

var statistics = employee.GetStatistics();

Console.WriteLine($"Average = {statistics.Average:N2}");
Console.WriteLine($"Max = {statistics.Max}");
Console.WriteLine($"Min = {statistics.Min}");