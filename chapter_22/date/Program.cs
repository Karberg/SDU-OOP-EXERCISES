long[] timestamps = { 1000, 100000, 1000000, 10000000 };

for (int i = 0; i < timestamps.Length; i++)
{
    DateTime date = DateTimeOffset.FromUnixTimeMilliseconds(timestamps[i]).DateTime;

    Console.WriteLine(date.ToString());
}

