using Dzien_6___zadanie_domowe;

Employee employee1 = new Employee("Paweł", "Witkowski", 54);
Employee employee2 = new Employee("Łukasz", "Kubiak", 39);
Employee employee3 = new Employee("Adrianna", "Jakubowska", 22);
Employee employee4 = new Employee("Angelika", "Szymczak", 49);

employee1.AddScore(5);
employee1.AddScore(5);
employee1.AddScore(5);
employee1.AddScore(5);
employee1.AddScore(5);

employee2.AddScore(7);
employee2.AddScore(2);
employee2.AddScore(5);
employee2.AddScore(3);
employee2.AddScore(3);

employee3.AddScore(8);
employee3.AddScore(5);
employee3.AddScore(1);
employee3.AddScore(1);
employee3.AddScore(3);

employee4.AddScore(9);
employee4.AddScore(0);
employee4.AddScore(3);
employee4.AddScore(6);
employee4.AddScore(5);


List<Employee> employeeList = new List<Employee>();
employeeList.Add(employee1);
employeeList.Add(employee2);
employeeList.Add(employee3);
employeeList.Add(employee4);

Employee theBestEmployee = winner(employeeList);

Console.WriteLine($"Najwięcej punktów zostało zdobytych przez {theBestEmployee.Name} {theBestEmployee.Surname}");


static Employee winner(List<Employee> employes)
{
    int theBestResult = -1;
    Employee winner = null;

    foreach (Employee employee in employes)
    {
        Console.WriteLine($"{employee.Name} zdobył {employee.Result} punktów");
        if (employee.Result > theBestResult)
        {
            theBestResult = employee.Result;
            winner = employee;
        }
    }

    return winner;
}
