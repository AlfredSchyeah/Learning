abstract class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public string Name { get; protected set; }

    public int Age { get; protected set; }

    public override string ToString()
    {
        return $"Имя: {Name} возраст: {Age}";
    }
}

