class Program
{
    static void Main(string[] args)
    {

    }
}

interface IMovable
{
    void Move();

    string Name { get; set; }

    const int minSpeed = 0;
    static int maxSpeed = 100;

    delegate void MoveHandler(string message);

    event MoveHandler MoveEvent;
}