


public class Student
{
    public string name;
    public int id;
    public Student(string nameValue, int idValue)
    {
        name = nameValue;
        id = idValue;
    }
    public string GetName()
    {
        return name;
    }
}
public class Course
{
    public string name { get; private set; }
    Student[] participants;
    public Course(string nameValue)
    {
        name = nameValue;
        participants = new Student[10]; // NOTE: This constant is BAD!
    }
    public void Enroll(Student student)
    {
        for (int i = 0; i < participants.Length; i++)
        {
            if (participants[i] == null)
            {
                participants[i] = student;
                return;
            }
        }
    }
    public void Remove(Student student)
    {
        for (int i = 0; i < participants.Length; i++)
        {
            if (participants[i] == student)
            {
                participants[i] = null;
            }
        }
    }
    public Student[] GetParticipants()
    {
        // count number of entries
        int count = 0;
        foreach (Student student in participants)
        {
            if (student != null)
            {
                count++;
            }
        }
        // make a copy
        Student[] result = new Student[count];
        int index = 0;
        foreach (Student student in participants)
        {
            if (student != null)
            {
                result[index++] = student;
            }
        }
        return result;
    }
}
public class EnrollmentSystem
{
    public Student[] students;
    public Course[] courses;

    public EnrollmentSystem(int maxStudents = 100, int maxCourses = 20)
    {
        students = new Student[maxStudents];
        courses = new Course[maxCourses];
    }

    public void Enroll(Student student, Course course)
    {
        course.Enroll(student);
    }
    public void Remove(Student student, Course course)
    {
        course.Remove(student);
    }
    public void ShowParticipants(Course course)
    {
        foreach (Student student in course.GetParticipants())
        {
            Console.WriteLine(student.GetName());
        }
    }
    public void GetCourses()
    {
        for (int i = 0; i < courses.Length; i++)
        {
            if (courses[i] != null)
            {
                System.Console.WriteLine(courses[i].name);

            }
        }
    }
    public void GetStudents()
    {
        Console.WriteLine("void for a getter?");
    }

    public void CreateStudent(string name)
    {
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i] == null)
            {
                students[i] = new Student(name, i);
                return;
            }
        }
        throw new Exception("The list of students is full");

    }

    public void DeleteStudent(int id)
    {
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i] != null && students[i].id == id)
            {
                students[i] = null;
                return;
            }
        }
        throw new Exception("The id doesn't exist");
    }

    public void CreateCourse(string name)
    {
        // Check if the course already exists
        for (int i = 0; i < courses.Length; i++)
        {
            if (courses[i] != null && courses[i].name == name)
            {
                throw new Exception("A course with this name already exists");
            }
        }

        for (int i = 0; i < courses.Length; i++)
        {
            if (courses[i] == null)
            {
                courses[i] = new Course(name);
                return;
            }
        }
        throw new Exception("The list of courses is full");
    }

    public void DeleteCourse(string name)
    {
        for (int i = 0; i < courses.Length; i++)
        {
            if (courses[i] != null && courses[i].name == name)
            {
                courses[i] = null;
                return;
            }
        }
        throw new Exception("The given course doesn't exist");
    }
}

