using System;
namespace MOverVir
{
    class Parent
    {
        protected void Property()
        {
            Console.WriteLine("10000 Cash | 1000kg Gold | Land in sec-18 Noida | BMW Car");
        }
        protected virtual void Marry()
        {
            Console.WriteLine("Father Choice");
        }
    }
     class Child : Parent
    {
        protected override void Marry()
        {
            Console.WriteLine("Child Choice");
        }
        static void Main()
        {   
            Child child = new Child();
            child.Property();
            child.Marry();
        }
     }
}