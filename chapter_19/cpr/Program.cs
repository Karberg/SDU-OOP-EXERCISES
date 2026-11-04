List<Person> people = new List<Person>();

people.Add(new Person("Michi", 28, "220185-6223"));
people.Add(new Person("Walter White", 55, "2810504-4623"));
people.Add(new Person("Jessie Pinkman", 24, "28010504-6223"));
people.Add(new Person("Mickey Mouse", 18, "161050-2953"));
people.Add(new Person("Jeppe", 28, "010101-0101"));

// Subtask 3:
// Find the person with the CPR number: 010101-0101
foreach (Person person in people)
{
    if (person.Cpr == "010101-0101")
    {
        Console.WriteLine(person);
    }
}

// Subtask 4: 

Dictionary<string, Person> peopleDict = new Dictionary<string, Person>();
foreach (Person person in people)
{
    peopleDict.Add(person.Cpr, person);
}

// Subtask 5:
Console.WriteLine(peopleDict.GetValueOrDefault("010101-0101"));

