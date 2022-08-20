using System;
namespace InheriMultilevel{
    class Test
    {
        protected void Display()
        {
            Console.WriteLine("Hii");
        }
    }
    class Mix : Test
    {
        protected void Show()
        {
            Console.WriteLine("Hello");
        }
    }
    class Demo : Mix
    {
        static void Main()
        {
            Demo d = new Demo();
            d.Show();
            d.Display();
        }
    }
}
