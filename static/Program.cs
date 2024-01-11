using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Person bob = new Person(3);
        bob.CheckAge();

        Person bob2 = new Person(67);
        bob2.CheckAge();

        Console.WriteLine(Person.retirementAge);

        Person.retirementAge = 50;

        Console.WriteLine(Person.retirementAge);


        Person bob3 = new Person(3);
        bob3.CheckAge();

        Person bob4 = new Person(49);
        bob4.CheckAge();
    }
}

class Person
{
    public int age { get; set; }
    public static int retirementAge = 65;

    public Person(int age)
    {
        this.age = age;
    }

    public void CheckAge()
    {
        if(age >= retirementAge)
        {
            Console.WriteLine("pensiya");
        }
        else
        {
            Console.WriteLine($"age do pensiyi {retirementAge - age}");
        }
    }
}