using System;
namespace MOverriding
{
    class Parent
    {
        protected void Property()
        {
            Console.WriteLine("10000 Cash | 1000kg Gold | Land in sec-18 Noida | BMW Car");
        }
        protected void Marry()
        {
            Console.WriteLine("Father Choice");
        }
    }
     class Child : Parent
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Property();
            child.Marry();
        }
     }
}
