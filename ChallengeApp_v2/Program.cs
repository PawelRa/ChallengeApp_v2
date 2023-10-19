using ChallengeApp_v2;

Console.WriteLine("Witamy w programie XYZ do oceny pracownika");
Console.WriteLine("========================================");
Console.WriteLine();

var employee = new Employee("Adam", "Kamizelich");

while (true)
{
    Console.WriteLine("Podaj ocenę pracownika: ");
    var input = Console.ReadLine();
    Console.WriteLine($"Podano wartość {input}");

    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception \"{ex.Message}\" catched");
    }

    Console.WriteLine("Aby wyjść z programu wciśnij 'q'");
}

var statistics = employee.GetStatistics();

Console.WriteLine($"Average = {statistics.Average:N2}");
Console.WriteLine($"Max = {statistics.Max}");
Console.WriteLine($"Min = {statistics.Min}");
Console.WriteLine($"Ocena Literowa = {statistics.AverageLetter}");