class Tabledo
    {
        static void PrintTable(int number)
        {
            int i = 1;
            do
            {    
                Console.WriteLine(number + "*" + i + "=" + number * i);
                i = i + 1;
            }
            while (i <= 10);
        }
            static void Main()
            {
                Console.Write("Enter the number:");
                int number = int.Parse(Console.ReadLine());
                PrintTable(number);
            }
    }