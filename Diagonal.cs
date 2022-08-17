class MaxMin
    {
        static void Main(string[] args)
        {
            int[,] arr;

            System.Console.WriteLine("Enter Base Array Size:");
            int b = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter Sub Array Size:");
            int c = int.Parse(System.Console.ReadLine());
            arr = new int[b, c];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    System.Console.WriteLine("Enter Data:");
                    arr[i, j] = int.Parse(System.Console.ReadLine());
                }
                System.Console.WriteLine();
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    System.Console.Write(arr[i,j] + " ");
                }
                System.Console.WriteLine();
            }
         
            System.Console.WriteLine("The max value is:");
            for (int i = 0; i < 3; i++)
             {
                int max = a[0];
                for (int i = 0; i < 3; i++)
               if(a[i] > max)
              max = a[i];
                
                        System.Console.WriteLine("Max no.is:" max);
                }
            System.Console.WriteLine("The min value is:");
            for (int i = 0; i < 3; i++)
             {
                int min = a[0];
                for (int i = 0; i < 3; i++)
               if(a[i] < min)
              min = a[i];
                
                        System.Console.WriteLine("Min no.is:" min);
                }
              
        }
    }