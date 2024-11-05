// KLASY

//Użytkownicy klasy


using ChallengeApp;


var employee = new Employee("Jan", "Kowalski", "30");
employee.AddScore("2");
employee.AddScore(2);
employee.AddScore(6);

var statistics = employee.GetStatistics();

Console.WriteLine($"Max:{statistics.Max}");
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Average:{statistics.Average:N2}");

