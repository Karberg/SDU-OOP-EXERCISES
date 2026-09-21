int seconds = 3600 * 24 * 30 * 12 + 3600 * 24 * 24;
int days = seconds / 3600 / 24;
int years = seconds / 365 / 24 / 60 / 60;
int christmasStart = 3600 * 24 * 30 * 12 + 3600 * 24 * 24;
int christmasEnd = 3600 * 24 * 30 * 12 + 3600 * 24 * 25;

if (seconds > christmasStart && seconds < christmasEnd)
{
    Console.WriteLine("It's Christmas!");
}

Console.WriteLine(years + " " + days%365);