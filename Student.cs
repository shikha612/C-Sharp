  class Student
    {
        int rollNo;
        public Student(int rollNo)
        {
            this.rollNo = rollNo;
        }
        public void show()
        {
            Console.WriteLine(this.rollNo);
        }
    }
    class Demo
    {
        static void Main()
        {
            Student st1 = new Student(1001);
            Student st2 = new Student(2002);
            Student st3 = new Student(3003);
            st1.show();
            st2.show();
            st3.show();
        }
    }