var name1 = "Łukasz";
var name2 = "Ewa";

var sex1 = "Mężczyzna";
var sex2 = "Kobieta";

var age1 = 17;
var age2 = 33;

if (name2 == "Ewa" && age2 == 33)
{
    Console.WriteLine("Ewa, lat 30");
}

else if (name2 != "Ewa" && sex2 == "Kobieta" && age2 < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}


else if (sex1 == "Mężczyzna" && age1 < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
