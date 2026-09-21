string[][] calendar = new string[12][];
int[] days = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
string[] weekDays = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];
int currentWeekDay = 0;


for (int m = 0; m < 12; m++)
{
    calendar[m] = new string[days[m]];

    for (int day = 0; day < days[m]; day++)
    {
        calendar[m][day] = weekDays[currentWeekDay];
        currentWeekDay = (currentWeekDay + 1) % 7;
    }
}

Console.WriteLine(calendar[0][0]);
