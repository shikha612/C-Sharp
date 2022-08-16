  class Switch
  {
        static int cal(int num1, int num2, char Operator)
        {
                int result = 0;
                switch (Operator)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        result = num1 / num2;
                        break;
                    default:
                        result = 0;
                        break;
                }
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
   