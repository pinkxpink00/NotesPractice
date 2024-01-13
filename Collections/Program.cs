using System.Collections.ObjectModel;

class Program
{
    static void Main()
    {
        var e = new ObservableCollection<int>();

        e.Add(1);
        e.Add(2);
        e.Add(3);

        foreach (var item in e)
        {
            Console.WriteLine(item);
        }

        //var people = new List<string>() {"Loice","Capy"};

        //people.Add("Joahna");
        //people.Add("Tom");

        //var firstPeople = people[2];

        //Console.WriteLine(firstPeople);

        //foreach (var person in people)
        //{
        //    Console.WriteLine(person);
        //}

        //var ages = new Dictionary<string, int>();

        //ages["Alice"]= 30;
        //ages["ASD"] = 305;
        //ages["asdasd"] = 4;
        //ages["Alicfasfasfe"] = 3;



        //var alice = ages["Alice"];

        //foreach (var age in ages)
        //{
        //    Console.WriteLine($"{age.Key} has {age.Value} yo");
        //}

    }
}