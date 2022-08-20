using System;
namespace InheriMultilevel2 {
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
        void Process()
        {
            Console.WriteLine("I M Child...");
            this.Show();
            this.Display(); // this keyword is not mandatory(optional)
        }
        static void Main()
        {
            Demo d = new Demo();
            d.Process();
        }
    }
}
