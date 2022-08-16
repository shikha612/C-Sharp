class Table
    {
        static void PrintTable(int number)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(number + "*" + i + "=" + number * i);
                i = i + 1;
            }
        }

        static void Main()
        {
            Console.Write("Enter the number:");
            int number = int.Parse(Console.ReadLine());
            PrintTable(number);
        }
    }