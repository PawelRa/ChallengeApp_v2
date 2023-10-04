string name;
string gender;
int age;

name = "Agata";
gender = "Kobieta";
age = 28;

if (gender == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (gender == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa ma 33 lata");
}
else if (gender == "Mężczyzna" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}


name = "Robert";
gender = "Mężczyzna";
age = 15;

if (gender == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (gender == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa ma 33 lata");
}
else if (gender == "Mężczyzna" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}

name = "Ewa";
gender = "Kobieta";
age = 33;

if (gender == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa ma 33 lata");
}
else if (gender == "Mężczyzna" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}