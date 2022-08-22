using System;
namespace MOverBase
{
    class Parent
    {
        protected virtual void Marry() //we can use non-static method
        {
            Console.WriteLine("Father Choice");
        }
    }
     class Child : Parent
    {
        protected override void Marry() //we can use non-static method
        {
            base.Marry();
            Console.WriteLine("After three year");
        }
        static void Main()
        {
            Child child = new Child();
           child.Marry();
        }
     }
}
