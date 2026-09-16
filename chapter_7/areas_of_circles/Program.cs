// Calculate the area of three circles that have the radiuses 1, 3 and 5.

const double pi = 3.14;
double[] r = [1, 3, 5];

foreach (double radius in r)
{
    Console.WriteLine(radius * radius * pi);
}