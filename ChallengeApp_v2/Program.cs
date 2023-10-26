using ChallengeApp_v2;

Console.WriteLine("Witamy w programie XYZ do oceny pracownika");
Console.WriteLine("========================================");
Console.WriteLine();

// Obsługa za pomocą zapisu do pliku
var employee = new EmployeeInFile("Adam", "Kamizelich");
employee.GradeAdded += EmployeeGradeAdded;

employee.AddGrade(50f);
employee.AddGrade(100);
employee.AddGrade(36);

var statistics = employee.GetStatistics();

Console.WriteLine($"Average = {statistics.Average:N2}");
Console.WriteLine($"Max = {statistics.Max}");
Console.WriteLine($"Min = {statistics.Min}");
Console.WriteLine($"Ocena Literowa = {statistics.AverageLetter}");

employee.FileDelete();

var tester = new EmployeeInMemory("imie", "nazwsko");
tester.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine($"Dodano nową ocenę");
}


tester.AddGrade(60f);


//=======================

//Obsługa za pomocą pamięci

//var employee = new EmployeeInMemory("Adam", "Kamizelich");

//while (true)
//{
//    Console.WriteLine("Podaj ocenę pracownika: ");
//    var input = Console.ReadLine();
//    Console.WriteLine($"Podano wartość {input}");

//    if (input == "q")
//    {
//        break;
//    }
//    try
//    {
//        employee.AddGrade(input);
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Exception \"{ex.Message}\" catched");
//    }

//    Console.WriteLine("Aby wyjść z programu wciśnij 'q'");
//}

//var statistics = employee.GetStatistics();

//Console.WriteLine($"Average = {statistics.Average:N2}");
//Console.WriteLine($"Max = {statistics.Max}");
//Console.WriteLine($"Min = {statistics.Min}");
//Console.WriteLine($"Ocena Literowa = {statistics.AverageLetter}");