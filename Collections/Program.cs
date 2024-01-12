class Program
{
    static void Main()
    {
        var people = new List<string>() {"Loice","Capy"};

        people.Add("Joahna");
        people.Add("Tom");

        var firstPeople = people[2];

        Console.WriteLine(firstPeople);

        foreach (var person in people)
        {
            Console.WriteLine(person);
        }
    }
}