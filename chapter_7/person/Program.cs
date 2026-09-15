// Top level statements
Person a = new Person {age=10, isMale=true, name="Ryan"};
Console.WriteLine(a.name + " is " + a.age + " years old");

// Top level statements have to be before type declarations

// Type declaration
class Person {
    public int age;
    public bool isMale;
    public string? name;
}