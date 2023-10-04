var myAge = 33;

// liczby całkowite
int newAge = myAge + 8;
//Console.WriteLine(newAge);

int myVar = int.MinValue;
uint myVar2 = uint.MinValue;
long myVar3 = long.MinValue;
ulong myVar4 = ulong.MaxValue;

// liczby zmiennoprzecinkowe
float myNumber = float.MaxValue;
double myNumber2 = double.MaxValue;
decimal myNumber3 = decimal.MaxValue;

// zmienne tekstowe
string masterName = "Adam";
string masterSurname = "Kamizelich";
string result = masterName + myAge + masterSurname;
//Console.WriteLine(result);

char myVar5 = 'c';
var result2 = masterName.ToArray();

// zmienna bool
bool isActive = true;
isActive = false;
var isValid = 5 > 6;
//Console.WriteLine(isValid);

if (myAge > newAge)
{
    Console.WriteLine("Linia 34");
}
else
{
    Console.WriteLine("Linia 38");
}

if (masterName == "Adam" && newAge < 50)
{
    Console.WriteLine("Mistrz jest przed 50.");
}
else if (newAge > 40)
{
    Console.WriteLine("40. latek");
}
else
{
    Console.WriteLine("Kim jestes?");
}