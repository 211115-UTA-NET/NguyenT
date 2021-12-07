namespace SampleNamespace
{
    public class Sponsor : Person
    {
        private string Company { get; set; }
        private string Media { get; set; }
        private bool Paid { get; set; }

        //Constructor

        public Sponsor()
        {
            Company = "Revature";
            Media = "social media";
            Paid = false;
        }
        public Sponsor(string Company, string Media, bool Paid, string firstName, string lastName) : base(firstName, lastName)
        {
            this.Company = Company;
            this.Media = Media;
            this.Paid = Paid;
        }

        // Setters and Getters
        // public void setCompany(string Company) { this.Company = Company; }
        // public void setMedia(string Media) { this.Media = Media; }
        // public void setPaid(bool Paid) { this.Paid = Paid; }

        // public string getCompany() { return this.Company; }
        // public string getMedia() { return this.Media; }
        // public bool getPaid() { return this.Paid; }

        public void Sponsorship()
        {
            Console.WriteLine($"Company sponsor: {Company}");
            Console.WriteLine($"Advertisement form: {Media}");
            Console.WriteLine($"Sponsor paid: {Paid}");
        }
    }
}