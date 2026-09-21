double input = 1.234;
Unit targetUnit = Unit.mm;

double conversionFactor = targetUnit switch
{
    Unit.m => 1,
    Unit.cm => 100,
    Unit.mm => 1000,
    Unit.inches => 1000.0 / 25.4,
    _ => throw new ArgumentOutOfRangeException()
};

double result = input * conversionFactor;

Console.WriteLine(input + " meters = " + result + " milimeters");

enum Unit {
    m,
    cm,
    mm,
    inches,
}