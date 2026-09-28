int[] grades = [4, 7, 02, 00, 10, 4, 12];

int count = 0;
int sum = 0;

for (int i = 0; i < grades.Length; i++)
{
    count++;
    sum += GetGrade(i);
}

Console.WriteLine(count);
Console.WriteLine(sum);
Console.WriteLine((double)sum/(double)count);

int GetGrade(int courseid) 
{
    int grade = grades[courseid];

    try 
    {
        if (grade > 0)
        {
            return grade;
        }
        else 
        {
            throw new Exception("The grade is not good enough");
        }
    }
    catch (Exception) {return 0;};
}