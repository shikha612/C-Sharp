class Employee
    {
        private int employeeNo;
        private string employeeName;
        private double employeeSal;
        public Employee(int employeeNo, string employeeName, double employeeSal)
        {
            this.employeeNo = employeeNo;
            this.employeeName = employeeName;
            this.employeeSal = employeeSal;
        }
        public int EmployeeNo
        {
            get
            {
                return employeeNo;
            }
        }
        public string EmployeeName
        {
            get
            {
                return employeeName;
            }
        }
        public double EmployeeSal
        {
            get
            {
                return employeeSal;
            }
        }
    }
    class Demo
    {
        static void Main()
        {
            Employee employee = new Employee(101, "shikha", 15000.99);
            Console.WriteLine("No is:" + employee.EmployeeNo);
            Console.WriteLine("Name is:" + employee.EmployeeName);
            Console.WriteLine("Sal is:" + employee.EmployeeSal);
        }
    }