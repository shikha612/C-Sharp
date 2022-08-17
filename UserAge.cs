     class Student
    {
        static void Main(string[] args)
        {

            System.Console.Write("Enter roll no:");
            int roll = System.Convert.ToInt32(System.Console.ReadLine());
 
            System.Console.Write("Enter the name:");
             string name = System.Console.ReadLine();

            System.Console.Write("Enter Hindi:");
            int hindi = System.Convert.ToInt32(System.Console.ReadLine());

            System.Console.Write("Enter English:");
            int english = System.Convert.ToInt32(System.Console.ReadLine());

            System.Console.Write("Enter Math:");
           int math = System.Convert.ToInt32(System.Console.ReadLine());

            int total = hindi + english + math;
            double per = total / 3.0;
            string div;

            if (per >= 60)
                div = "First Devision";
            else if (per < 60 && per >= 50)
                div = "Second Devision";
            else if (per < 50 && per >= 30)
                div = "Pass";
            else
                div = "Fail";

            System.Console.WriteLine("Total Marks is:" + total);
            System.Console.WriteLine("The Persentage is:" + per);
            System.Console.WriteLine("The Devision is:" + div);

        }
        
    }