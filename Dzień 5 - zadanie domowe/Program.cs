int number = 86515;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int[] result = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

foreach (char c in letters)
{
    if (c == '0') { result[0]++; }
    if (c == '1') { result[1]++; }
    if (c == '2') { result[2]++; }
    if (c == '3') { result[3]++; }
    if (c == '4') { result[4]++; }
    if (c == '5') { result[5]++; }
    if (c == '6') { result[6]++; }
    if (c == '7') { result[7]++; }
    if (c == '8') { result[8]++; }
    if (c == '9') { result[9]++; }
}

for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine($"Ilość wystąpień cyfry {i} wynosi {result[i]}");
}