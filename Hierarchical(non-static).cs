using System;
namespace N1
{
    class Parent
    {
        protected void Display()
        {
            Console.WriteLine("I M Parent");
        }
    }
    class Child1 : Parent
    {
        internal void Show()
        {
            this.Display(); // this keyword is not mandatory(optional)
            Console.WriteLine("I M Child1.");
        }
    }
    class Child2 : Parent
    {
        internal void Show()
        {
            this.Display(); // this keyword is not mandatory(optional)
            Console.WriteLine("I M Child2.");
        }
    }

    namespace N2
    {
        class Demo
        {
            static void Main()
            {
                Child1 child1 = new Child1();
                Child2 child2 = new Child2();
                child1.Show();
                child2.Show();
            }
        }
    }
}
