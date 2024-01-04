class Program
{
    static void Main(string[] args)
    {
        //Размещение в стеке, потому что int == struct (value types)
        int num1 = 0;

        {
            //Размещение в куче, потому что array == class (reference types)
            int[] arrayNum2 = new int[2];
        }

        int a = 4;

        valueTypesCheck(a);

        Console.WriteLine(a);
    }

    public static void valueTypesCheck(int value)
    {
         value = 10;
    }
}