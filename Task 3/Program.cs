byte smallNum = 200;
short shortNum = 30000;
int intNum = 2000000;
long longNum = 9000000000L;
float floatNum = 3.5f;
double doubleNum = 7.25;
decimal moneyNum = 99.99m;
char letter = 'R';
bool isReady = true;

string numberText = 42.ToString();
double parsedValue = double.Parse("3.14");

Console.WriteLine($"byte: {smallNum}");
Console.WriteLine($"short: {shortNum}");
Console.WriteLine($"int: {intNum}");
Console.WriteLine($"long: {longNum}");
Console.WriteLine($"float: {floatNum}");
Console.WriteLine($"double: {doubleNum}");
Console.WriteLine($"decimal: {moneyNum}");
Console.WriteLine($"char: {letter}");
Console.WriteLine($"bool: {isReady}");
Console.WriteLine($"int 42 as string: {numberText} ({numberText.GetType()})");
Console.WriteLine($"string 3.14 as double: {parsedValue} ({parsedValue.GetType()})");