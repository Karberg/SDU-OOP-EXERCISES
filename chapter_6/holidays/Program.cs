for (int month = 1; month <= 12; month++)
{
    string s;
    switch (month)
    {
        case 4:
        s = "Spring Holiday";
        break;
        case 7: case 8:
        s = "Summer Holiday";
        break;
        case 10:
        s = "Autumn Holiday";
        break;
        case 12:
        s = "Christmas Holiday";
        break;
        default: 
        s = "Hard Work";
        break;
    }
    Console.WriteLine(month + " " + s);
}