int[] radii = [1, 3, 5];

for (int i = 0; i < radii.Length; i++)
{
    double area = areaOfCircle(radii[i]);
    double circum = circumOfCircle(radii[i]);
    Console.WriteLine($"Area of circle {i + 1} is: {area}");
    Console.WriteLine($"Circumference of circle {i + 1} is: {circum}");
}

// Functions
double areaOfCircle(double radius)
{
    return 3.1415 * radius * radius;
}

double circumOfCircle(double radius)
{
    return 2 * 3.1415 * radius;
}