int[] monthNormal = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
int[] monthLeap = [31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];

for (int i = 2000; i <= 2020; i++)
{
    Console.Write(i + ": ");
    if (i % 4 == 0)
    {
        for (int j = 0; j < monthLeap.Length; j++)
        {
            Console.Write(monthLeap[j] + " ");
        }
        Console.WriteLine();
    }
    else 
    {
        for (int j = 0; j < monthNormal.Length; j++)
        {
            Console.Write(monthNormal[j] + " ");
        }
        Console.WriteLine();
    }
}