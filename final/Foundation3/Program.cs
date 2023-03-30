using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Creating a Lecture event
        Address lectureAddress = new Address("2002 N Main St", "Santa Ana", "CA", "92706");
        LectureEvent lectureE = new LectureEvent("Lynda Thomas Distinguished Lecture Series",
                                                "Legendary Authors and the Clothes They Wore with Terry N",
                                                "04/02/2023",
                                                "11:00 AM",
                                                lectureAddress,
                                                "Lynda Thomas",
                                                50);
        
        // Generating Standard marketing message
        lectureE.DisplayStandardDetails();
        // Generating Full details marketing message
        lectureE.DisplayFullDetailsLecture();
        // Generating Short description marketing message
        lectureE.DisplayShortDescLecture();

        // Creating an Outdoor event
        Address outdoorAddress = new Address("11520 W Pico Blvd", "Los Angeles", "CA", "");
        OutdoorEvent outdoorE = new OutdoorEvent("It's All Fun & Games - Outdoor Social",
                                                "Join us for an exclusive friends, cocktails & games social at LA",
                                                "04/02/2023",
                                                "1:00 PM",
                                                outdoorAddress,
                                                "Cristal Clear");
        
        // Generating Standard marketing message
        outdoorE.DisplayStandardDetails();
        // Generating Full details marketing message
        outdoorE.DisplayFullDetailsOutdoor();
        // Generating Short description marketing message
        outdoorE.DisplayShortDescOutdoor();

        // Creating a Reception event
        Address receptionAddress = new Address("7344 Washington Ave.", "Whittier", "CA", "90602");
        ReceptionsEvent receptionE = new ReceptionsEvent("Whittier Reads 2023 Event",
                                                "Reception and Dinner for Javier Zamora",
                                                "04/27/2023",
                                                "7:00 PM - 9:00 PM",
                                                receptionAddress,
                                                "javierZamorag@gmail.com");
        
        // Generating Standard marketing message
        receptionE.DisplayStandardDetails();
        // Generating Full details marketing message
        receptionE.DisplayFullDetailsReceptions();
        // Generating Short description marketing message
        receptionE.DisplayShortDescReceptions();
    }
}