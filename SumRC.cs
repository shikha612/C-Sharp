class SumRC
    {
        static void Main(string[] args)
        {
            int[,][] arr;
            Console.WriteLine("Enter Base Array Size:");
            int b = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Enter Sub Array Size:");
            int c = int.Parse(System.Console.ReadLine());
            arr = new int[b, c];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("Enter Data:");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine(arr[i, j] + " ");
                }
                for (i = 0; i < 3; i++)
                {
                    int sum = 0;
                    for (j = 0; j < 3; j++)
                        sum = sum + arr[i][j];
                    Console.WriteLine("i+1", sum);
                }
                for (i = 0; i < 3; i++)
                {
                    int sum = 0;
                    for (j = 0; j < 3; j++)
                        sum = sum + arr[j][i];
                    Console.WriteLine("i+1", sum);
                }
            }
        }
    }