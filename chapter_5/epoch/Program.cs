int seconds = 365 * 56 * 24 * 60 * 60 + (251*24*60*60);
int days = seconds / 3600 / 24;
int years = seconds / 365 / 24 / 60 / 60;

Console.WriteLine(years + " " + days%365);
