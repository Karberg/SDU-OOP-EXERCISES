for (double i = -5.0; i<=40; i += 0.5) {
    double f = 32 + (9/5.0)*i;
    if (i >= 0) Console.Write(" ");
    Console.WriteLine("{0:0.0}°C {1,10:0.0}", i, f);
}
