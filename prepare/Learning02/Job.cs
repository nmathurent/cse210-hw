    // A code template for the category of things known as Job. The
    // responsibility of a Job is to keeps track of the company, job 
    // title, start year, and end year.
    public class Job
    {
        // Creating the member variables of the class
        public string _company = "";
        public string _jobTitle = "";
        public int _startYear = 0;
        public int _endYear = 0;

        // A method that displays the job details 
        public void DisplayJobDetails()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }


    }