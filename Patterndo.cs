class Patterndo
    {
        static void PrintPattern()
        {
            int ctr = 1;
            do
            {
                int ptr = 1;
                do
                {
                    Console.Write("A");
                    ptr = ptr + 1;
                }
                while (ptr <= ctr);
                Console.WriteLine();
                ctr = ctr + 1;
            }
            while (ctr <= 3);  
        }
        static void Main()
        {
            PrintPattern();
        }
    }