int[] grades = new int[365];
string[] daysOfWeeks = new string[7];

daysOfWeeks[0] = "poniedzialek";
daysOfWeeks[1] = "wtorek";
daysOfWeeks[2] = "środa";
daysOfWeeks[3] = "czwartek";
daysOfWeeks[4] = "piątek";
daysOfWeeks[5] = "sobota";
daysOfWeeks[6] = "niedziela";

//Console.WriteLine(daysOfWeeks[2]);

string[] dayOfWeeks2 = { "poniedzialek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };

//Console.WriteLine(dayOfWeeks2[5]);

for (int i = 0; i < dayOfWeeks2.Length; i++)
{
    Console.WriteLine(dayOfWeeks2[i]);
}

// Listy
List<string> days = new List<string>();
days.Add("poniedzialek");
days.Add("wtorek");
days.Add("środa");
days.Add("czwartek");
days.Add("piątek");
days.Add("sobota");
days.Add("niedziela");