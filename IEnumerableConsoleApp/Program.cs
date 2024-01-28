namespace trainIEnum
{
    class Program
    {
        static void Main()
        {
            //IEnumerable 
            IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            
            //IEnumerator

            IEnumerator<int> enumerator = numbers.GetEnumerator();

            while (enumerator.MoveNext())
            {
                var num = enumerator.Current;
                Console.WriteLine(num);
            }
        }
    }
}

