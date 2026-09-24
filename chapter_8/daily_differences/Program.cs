string[] days = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];
double[] temp = [21.5, 23.7, 19.6, 22.5, 25.3, 21.7, 18.9];

for (int i = 0; i < temp.Length-1; i++)
{
     double diff = temp[i+1] - temp[i];

     Console.WriteLine(days[i] + " - " + days[i+1] + ": " + diff);
}