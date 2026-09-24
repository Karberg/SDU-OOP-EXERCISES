double sqrt(double input)
{
    double candidate = input/2;

    while(candidate * candidate > input)
    {
        candidate = candidate - 0.00001;
    }   
    return candidate;
}

Console.WriteLine(sqrt(64));