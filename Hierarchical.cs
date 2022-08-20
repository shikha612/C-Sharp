using System;
namespace N1
{
    class Parent
    {
        protected int x;
        protected static int y;
    }
    class Child1 : Parent
    {
        internal static void Show()
        {
            Child1 child1 = new Child1();

            Console.WriteLine("First Child1.");
            Console.WriteLine(child1.x + " " + Child1.y);
            Console.WriteLine("............");
        }
    }
    class Child2 : Parent
    {
        internal static void Show()
        {
            Child2 child2 = new Child2();

            Console.WriteLine("Second Child2.");
            Console.WriteLine(child2.x + " " + Child2.y);
            Console.WriteLine("............");
        }
    }

   class Client
   {
      static void Main()
      {
        Child1.Show();
        Child2.Show();
      }
   }
 }
