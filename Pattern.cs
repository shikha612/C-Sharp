class Pattern
        {
            static void PrintPattern()
            {
                int ctr = 1;
                while (ctr <= 3)
                {
                    int ptr = 1;
                    while (ptr <= ctr)
                    {
                        System.Console.Write("A");
                        ptr = ptr + 1;
                    }
                    System.Console.WriteLine();
                    ctr = ctr + 1;
                }

            }
            static void Main()
            {
                PrintPattern();
            }
}
    