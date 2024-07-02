// Tablice

int[] oceny = new int[5];
string[] Dni_tygodnia = new string[7];
Dni_tygodnia[0] = "Poniedziałek";
Dni_tygodnia[1] = "Wtorek";
Dni_tygodnia[2] = "Środa";
Dni_tygodnia[3] = "Czwartek";
Dni_tygodnia[4] = "Piątek";
Dni_tygodnia[5] = "Sobota";
Dni_tygodnia[6] = "Niedziela";


string[] Dni_tygodnia2 = { "Poniedziałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Niedziela" };
Console.WriteLine(Dni_tygodnia[6]);


// Pętla for

for (var i = 0; i <= 6; i = i + 1)
{
    Console.WriteLine(Dni_tygodnia2[i]);
}

// Listy

List<string> dayOfWeeks = new List<string>();
dayOfWeeks.Add("Poniedziałek");
dayOfWeeks.Add("Wtorek");
dayOfWeeks.Add("Środa");
dayOfWeeks.Add("Czwartek");
dayOfWeeks.Add("Piątek");
dayOfWeeks.Add("Sobota");
dayOfWeeks.Add("Niedziela");

for (var i = 0; i <= 6; i = i + 1)
{
    Console.WriteLine(dayOfWeeks[i]);
}

// Pętla foreach

foreach (var day in dayOfWeeks)
{
    Console.WriteLine(day);
}

// Zadanie Domowe Dzień 5

int number = 4566;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;

foreach (char letter in letters)
{

    if(letter == 0)
    {
        counter0++;
    }
    else if (letter == 1)
    {
        counter1++;
    }
}