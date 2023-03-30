using System;

class Program
{
    static void Main(string[] args)
    {
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
    }
}