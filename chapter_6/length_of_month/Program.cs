int month = 1;

if (month == 2)
{
    Console.WriteLine("28 days");
}
else if (month % 2 == 0)
{
    Console.WriteLine("30 days");
}
else if (month % 2 != 0)
{
    Console.WriteLine("31 days");
};