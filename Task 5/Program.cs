DateTime birthDate = new DateTime(2004, 5, 15);
DateTime todayNow = DateTime.Now;

TimeSpan lifeSpan = todayNow - birthDate;
int ageInYears = (int)(lifeSpan.TotalDays / 365.25);

Console.WriteLine($"Birthdate: {birthDate:yyyy-MM-dd}");
Console.WriteLine($"Current date: {todayNow:yyyy-MM-dd HH:mm}");
Console.WriteLine($"Age in years: {ageInYears}");

DateTime tenDaysLater = birthDate.AddDays(10);
Console.WriteLine($"Birthdate + 10 days: {tenDaysLater:yyyy-MM-dd}");