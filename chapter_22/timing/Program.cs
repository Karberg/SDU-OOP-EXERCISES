class Timing
{
    public static double Fun(double x, double y)
    {
        if (y <= 1)
        {
            return x;
        }
        else
        {
            return Fun(x, y - 1) * Fun(x, y - 1);
        }
    }

    static void Main(string[] args)
    {
        long timeAtStart = DateTimeOffset.Now.ToUnixTimeMilliseconds();


        double result = Fun(1.0000001, 32);

        long execTime = DateTimeOffset.Now.ToUnixTimeMilliseconds() - timeAtStart;

        Console.WriteLine("Result: " + result + "\nTime: " + execTime);
    }
}