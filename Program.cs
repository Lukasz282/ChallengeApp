// KLASY

//Użytkownicy klasy


using ChallengeApp;

Employee employee1 = new Employee("Adam", "Kowalski", "30");
Employee employee2 = new Employee("Krzysztof", "Kwiatkowski", "35");
Employee employee3 = new Employee("Joanna", "Nowak", "27");

employee1.AddScore(4);
employee1.AddScore(3);
employee1.AddScore(7);
employee1.AddScore(3);
employee1.AddScore(7);

employee2.AddScore(7);
employee2.AddScore(10);
employee2.AddScore(3);
employee2.AddScore(10);
employee2.AddScore(3);

employee3.AddScore(10);
employee3.AddScore(5);
employee3.AddScore(10);
employee3.AddScore(5);
employee3.AddScore(10);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees )
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine(employeeWithMaxResult.Name);
Console.WriteLine(employeeWithMaxResult.Last_Name);
Console.WriteLine(employeeWithMaxResult.Age);


