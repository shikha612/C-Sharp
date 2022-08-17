 class EvenOdd
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the Array Size:");
            int a = System.Convert.ToInt32(System.Console.ReadLine());
            int[] arr = new int[a];
            int odd = 0, even = 0;
            int i = 0;
            while (i<arr.Length)
            {
                System.Console.WriteLine("Enter Data:");
                arr[i] = System.Convert.ToInt32(System.Console.ReadLine());
                i++;
            }
               i=0;
                while (i<arr.Length)
                {
                    if (arr[i] % 2 == 0)
                        even++;
                    else
                        odd++;
                i++;
            }
                System.Console.WriteLine("total even"+even);
            System.Console.WriteLine("total odd"+odd);
          
        }
    }