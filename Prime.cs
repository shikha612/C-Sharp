 class Prime
    {
        static string number(int num)
        {
            bool flag = true;
            string result;
            int i = 2;
            while (i < num / 2)
            {
                if (num % i == 0)
                {
                    flag = false;
                    break;
                }
                i++;
            }
            if (flag == true)
                result = "Prime";
            else
                result = "Not Prime";
            return result;
        }
        static void Main()
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(number(num));
        }
    }