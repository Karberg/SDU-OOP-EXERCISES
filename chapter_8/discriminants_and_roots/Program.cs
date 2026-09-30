double Discriminant(double a, double b, double c)
{
    return b * b - 4 * a * c;
}

double[] Roots(double a, double b, double c)
{
    double d = Discriminant(a, b, c);
    double[] roots = new double[2];

    if (d > 0)
    {
        roots[0] = (-b + Math.Sqrt(d)) / (2 * a);
        roots[1] = (-b - Math.Sqrt(d)) / (2 * a);
    }
    else if (d == 0)
    {
        roots[0] = (-b + Math.Sqrt(d)) / 2 * a;
    }

    return roots;
}




bool running = true;

while (running)
{
    System.Console.Write("Input a: ");
    double a = Convert.ToDouble(Console.ReadLine());

    System.Console.Write("Input b: ");
    double b = Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Input c: ");
    double c = Convert.ToDouble(Console.ReadLine());

    System.Console.WriteLine();

    double[] roots = Roots(a, b, c);

    for (int i = 0; i < roots.Length; i++)
    {
        Console.WriteLine(roots[i]);
    }

    running = false;
}