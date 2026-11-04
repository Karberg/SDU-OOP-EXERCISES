using System.Security.Cryptography;

class Person
{
    public string Name { get; }
    public int Age { get; }
    public string Cpr { get; }

    public Person(string name, int age, string cpr)
    {
        Name = name;
        Age = age;
        Cpr = cpr;
    }

    public override string ToString()
    {
        return string.Concat("Name: ", Name, ", Age: ", Age, ", CPR: ", Cpr);
    }

}