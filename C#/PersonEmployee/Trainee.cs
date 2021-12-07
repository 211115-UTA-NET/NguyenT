namespace SampleNamespace
{
    public class Trainee : Employee
    {
        private bool IsWorking;
        private string WorkLocation;
        private string TraineeID;

        //Constructor

        public Trainee()
        {
            IsWorking = true;
            WorkLocation = "Virginia";
            TraineeID = "28710579";
        }
        public Trainee(bool IsWorking, string WorkLocation, string TraineeID, int HoursWorked, double PayRate, string firstName, string lastName) : base(HoursWorked, PayRate, firstName, lastName)
        {
            this.IsWorking = IsWorking;
            this.WorkLocation = WorkLocation;
            this.TraineeID = TraineeID;
        }

        // Setters and Getters
        public void setIsWorking(bool IsWorking) { this.IsWorking = IsWorking; }
        public void setWorkLocation(string WorkLocation) { this.WorkLocation = WorkLocation; }
        public void setTraineeID(string TraineeID) { this.TraineeID = TraineeID; }

        public bool getIsWorking() { return this.IsWorking; }
        public string getWorkLocation() { return this.WorkLocation; }
        public string getTraineeID() { return this.TraineeID; }

        public void TraineeInfo()
        {
            Console.WriteLine($"Active trainee: {IsWorking}");
            Console.WriteLine($"Trainee work location: {WorkLocation}");
            Console.WriteLine($"Trainee ID: {TraineeID}");
        }
    }
}