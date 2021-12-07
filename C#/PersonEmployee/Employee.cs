namespace SampleNamespace
{
    public class Employee : Person
    {
        public int HoursWorked;
        public double PayRate;

        //Constructor

        public Employee()
        {
            HoursWorked = 40;
            PayRate = 18.00;
        }
        public Employee(int HoursWorked, double PayRate, string firstName, string lastName) : base(firstName, lastName)
        {
            this.HoursWorked = HoursWorked;
            this.PayRate = PayRate;
        }
        // Setters and Getters
        public void setHoursWorked(int HoursWorked) { this.HoursWorked = HoursWorked; }
        public void setPayRate(double PayRate) { this.PayRate = PayRate; }

        public int getHoursWorked() { return this.HoursWorked; }
        public double getPayRate() { return this.PayRate; }

        public void doWork()
        {
            Console.WriteLine($"Work hours: {HoursWorked} hrs/wk");
            Console.WriteLine($"Pay rate: {PayRate}/hr");
        }
    }
}