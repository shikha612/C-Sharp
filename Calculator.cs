class Calculator
{
        static int cal(int num1, int num2, char Operator)
        {
            int result = 0;
            if (Operator == '+')
            {
                result = num1 + num2;
            }
            else if (Operator == '-')
            {
                result = num1 - num2;
            }
            else if (Operator == '*')
            {
                result = num1 * num2;
            }
            else if (Operator == '/')
            {
                result = num1 / num2;
            }
            else result = 0;
            return result;
        }
        static void Main()
        {
            Console.WriteLine(cal(100, 50, '+'));
            Console.WriteLine(cal(100, 50, '-'));
            Console.WriteLine(cal(100, 50, '*'));
            Console.WriteLine(cal(100, 50, '/'));
        }

}