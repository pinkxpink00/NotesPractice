class Program
{
    static void Main()
    {
        EventCounter counter = new EventCounter();
        FirstHandler handler1 = new FirstHandler();
        SecondHandler handler2 = new SecondHandler();

        counter.onEventCount += handler1.Message;
        counter.onEventCount += handler2.Message;

        counter.eventCount();
    }
}

class EventCounter
{
    public delegate void MethodContainer();

    public event MethodContainer onEventCount;
    public void eventCount()
    {
      
        for (int i = 0; i < 100; i++)
        {
            bool isCheck71 = (i == 71);

            if (isCheck71)
            {
                onEventCount();
            }
        }
    }
}

class FirstHandler
{
    public void Message()
    {
        string stringMessage = "Пора действовать, ведь уже 71";
        Console.WriteLine(stringMessage);
    }
}

class SecondHandler
{
    public void Message()
    {
        string stringMessage = "Точно, уже 71";
        Console.WriteLine(stringMessage);
    }
}