class Program
{
    static void Main(string[] args)
    {
        Ship ship = new Ship();
        ship.Move();
    }
}

class Ship : Transport
{

}

abstract class Transport
{
    public void Move()
    {
        Console.WriteLine("Transport moves");
    }
}