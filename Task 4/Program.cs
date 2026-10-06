int[] faveNumbers = { 9, 3, 14, 7, 21 };

Array.Sort(faveNumbers);
Array.Reverse(faveNumbers);

for (int i = 0; i < faveNumbers.Length; i++)
{
    Console.WriteLine($"Index {i}: {faveNumbers[i]}");
}

int searchFor = 7;
int foundAt = Array.IndexOf(faveNumbers, searchFor);
Console.WriteLine($"{searchFor} is at index {foundAt}");