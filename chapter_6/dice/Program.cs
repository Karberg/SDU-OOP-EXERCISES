int dice = 3;

bool win = false;

if (dice % 2 == 0 && dice > 3)
{
    win = true;
}

Console.WriteLine(win);