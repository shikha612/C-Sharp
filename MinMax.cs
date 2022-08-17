 class MinMax
    {
        static void Main(string[] args)
        {    
            System.Console.WriteLine("Enter the Array Size:");
            int b = System.Convert.ToInt32(System.Console.ReadLine());
            int[] arr = new int[b];
            for (int i = 0; i < arr.Length; i++)
            {
                    System.Console.WriteLine("Enter Data:");
                    arr[i] = int.Parse(System.Console.ReadLine());
            }
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
               System.Console.WriteLine("Min value is:" +min);

               System.Console.WriteLine(".............................");

            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            System.Console.WriteLine("Max value is:" + max);
        }
    }