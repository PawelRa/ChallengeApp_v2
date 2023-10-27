using ChallengeApp_v2;

Console.WriteLine("Witamy w programie XYZ do oceny pracownika");
Console.WriteLine("========================================");
Console.WriteLine();

Console.WriteLine("Wciśnij 'C' by kontynuować wpisywanie danych do pliku lub wybierz nowego pracownika");

string name = "";
string surName = "";

var employInFile = new EmployeeInFile("no name", "no surName");

if (Console.ReadLine().ToLower() != "c")
{

    Console.WriteLine("Podaj imię pracownika");
    name = Console.ReadLine();
    Console.WriteLine("Podaj nazwisko pracownika");
    surName = Console.ReadLine();

    Console.WriteLine("Wybierz metodę przechowywania danych");
    Console.WriteLine("Pamięć wciśnij 'P', dysk wciśnij 'F', lub zakończ program wciskając dowolny klawisz");
    string firstStep = Console.ReadLine();


    if (firstStep.ToLower() == "p")
    {
        var employee = new EmployeeInMemory(name, surName);

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

        Console.WriteLine();
        Console.WriteLine("=================");
        Console.WriteLine($"Wyniki pracownika {employee.Name} {employee.Surname}");
        Console.WriteLine($"Average = {statistics.Average:N2}");
        Console.WriteLine($"Max = {statistics.Max}");
        Console.WriteLine($"Min = {statistics.Min}");
        Console.WriteLine($"Ocena Literowa = {statistics.AverageLetter}");



    }
    else if (firstStep.ToLower() == "f")
    {
        var employee = new EmployeeInFile(name, surName);
        employInFile = employee;

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

        Console.WriteLine();
        Console.WriteLine("=================");
        Console.WriteLine($"Wyniki pracownika {employee.Name} {employee.Surname}");
        Console.WriteLine($"Average = {statistics.Average:N2}");
        Console.WriteLine($"Max = {statistics.Max}");
        Console.WriteLine($"Min = {statistics.Min}");
        Console.WriteLine($"Ocena Literowa = {statistics.AverageLetter}");

        Console.WriteLine("Aby skasować plik ocen wciśnij D");
        if (Console.ReadLine().ToLower() == "d")
        {
            employee.FileDelete();
        }
    }
    else
    {
        Console.WriteLine("Koniec programu");
    }
}
else
{
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
            employInFile.AddGrade(input);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception \"{ex.Message}\" catched");
        }

        Console.WriteLine("Aby wyjść z programu wciśnij 'q'");
    }

    var statistics = employInFile.GetStatistics();

    Console.WriteLine();
    Console.WriteLine("=================");
    Console.WriteLine($"Wyniki pracownika {employInFile.Name} {employInFile.Surname}");
    Console.WriteLine($"Average = {statistics.Average:N2}");
    Console.WriteLine($"Max = {statistics.Max}");
    Console.WriteLine($"Min = {statistics.Min}");
    Console.WriteLine($"Ocena Literowa = {statistics.AverageLetter}");

    Console.WriteLine("Aby skasować plik ocen wciśnij D");
    if (Console.ReadLine().ToLower() == "d")
    {
        employInFile.FileDelete();
    }

}
