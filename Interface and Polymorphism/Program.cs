using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        Transport ship = new Ship("Ship");

        ship.Move();
    }
}

class Ship : Transport
{
    public Ship(string name) : base(name) { }
}

abstract class Transport
{
    public string Name { get; set; }

    public Transport(string name)
    {
        Name = name;
    }

    public void Move() => Console.WriteLine($"{Name} moves");
}