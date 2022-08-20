using System;
namespace Inheritance
{
    // base class
    class Animal
    {
        public string name;
        public void display()
        {
            Console.WriteLine("I am an animal");
        }
    }
    class Dog : Animal
    {
        public void getName()
        {
            Console.WriteLine("My name is " + name);
        }
    }
    class Demo
    {
        static void Main(string[] args)
        {
            // object of derived class
            Dog labrador = new Dog();

            // access field and method of base class
            labrador.name = "Rohu";
            labrador.display();

            // access method from own class
            labrador.getName();
        }

    }
}