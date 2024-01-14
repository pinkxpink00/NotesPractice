class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        Car car = new Car();
        DoAction(car);
        DoAction(person);
    }

    static void DoAction(IMovable movable) => movable.Move();
}

interface IMovable
{
    void Move();
}

class Person : IMovable
{
    public void Move()
    {
        Console.WriteLine("Person going to walk");
    }
}

class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car rides");
    }
}