using System.Collections.ObjectModel;
using System.Collections.Specialized;

class Program
{
    //static void Main()
    //{
    //    //var e = new ObservableCollection<int>();

    //    //e.Add(1);
    //    //e.Add(2);
    //    //e.Add(3);

    //    //foreach (var item in e)
    //    //{
    //    //    Console.WriteLine(item);
    //    //}

    //    //var people = new List<string>() {"Loice","Capy"};

    //    //people.Add("Joahna");
    //    //people.Add("Tom");

    //    //var firstPeople = people[2];

    //    //Console.WriteLine(firstPeople);

    //    //foreach (var person in people)
    //    //{
    //    //    Console.WriteLine(person);
    //    //}

    //    //var ages = new Dictionary<string, int>();

    //    //ages["Alice"]= 30;
    //    //ages["ASD"] = 305;
    //    //ages["asdasd"] = 4;
    //    //ages["Alicfasfasfe"] = 3;



    //    //var alice = ages["Alice"];

    //    //foreach (var age in ages)
    //    //{
    //    //    Console.WriteLine($"{age.Key} has {age.Value} yo");
    //    //}

    //}



    static void Main(string[] args)
    {
        var people = new ObservableCollection<Person>()
        {
            new Person("Bob"),
            new Person("Tom")
        };

        // подписываемся на событие изменения коллекции
        people.CollectionChanged += People_CollectionChanged;

        people.Add(new Person("Sam")); // добавляем новый элемент

        people.RemoveAt(1);//delete object

        people[0] = new Person("German");//change object

        Console.WriteLine("\n List Users");
        foreach (var person in people)
        {
            Console.WriteLine(person.Name);
        }
    }

    private static void People_CollectionChanged(object? sender,NotifyCollectionChangedEventArgs e)
    {
        switch(e.Action) 
        {
            case NotifyCollectionChangedAction.Add: //if add
                if (e.NewItems?[0] is Person newPerson)
                    Console.WriteLine($"added new object {newPerson.Name}");
                break;

                case NotifyCollectionChangedAction.Remove: //if remove
                if (e.OldItems?[0] is Person oldPerson)
                    Console.WriteLine($"deleted old object {oldPerson.Name}");
                break;

            case NotifyCollectionChangedAction.Replace: //if replace
                if ((e.NewItems?[0] is Person replacing) && (e.OldItems[0] is Person replaced))
                    Console.WriteLine($"object {replacing.Name} replaced on {replaced.Name}");
                break;

        }
    }
}

class Person
{
    public string Name { get; }
    public Person(string name)
    {
        Name = name;
    }
}