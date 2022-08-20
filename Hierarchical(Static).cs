using System;
namespace N1
{
    class Parent
    {
        protected static void Display()
        {
            Console.WriteLine("I M Parent");
        }
    }
    class Child1 : Parent
    {
        internal static void Show()
        {
            Display(); 
            Console.WriteLine("I M Child1.");
        }
    }
    class Child2 : Parent
    {
        internal static void Show()
        {
            Display(); 
            Console.WriteLine("I M Child2.");
        }
    }

    namespace N2
    {
        class Demo
        {
            static void Main()
            {
                
                Child1.Show();
                Child2.Show();
            }
        }
    }
}
