    // A code template for the category of things known as Resume. The
    // responsibility of a Resume is to keeps track of the person's name 
    // and a list of their jobs.

    public class Resume 
    {
        // Creating the member variable for the person's name
        public string _name = "";
        // Creating the member variable for the list of Jobs.
        public List<Job> _jobs = new List<Job>();

        // A method that displays the resume details 
        public void DisplayResumeDetails()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");
            foreach (Job job in _jobs) {
                job.DisplayJobDetails();
            }
        }

    }