// Inheritance with Event Planning Program    Week 13
// Author : Nelson Mathurent
// Date:    Mar 29, 2023

public class ReceptionsEvent : Event
{
    private string _emailRSVP;

    public string GetEventType() {
        return "Receptions";
    } 
    public string GetEmailRSVP() {
        return _emailRSVP;
    }
    public void SetEmailRSVP(string emailRSVP) {
        _emailRSVP = emailRSVP;
    }

    public string GetMessage() {
        return $"Email for RSVP: {GetEmailRSVP()}";
    }

// Constructor 
    public ReceptionsEvent(string title, string description, string date, string time, Address address, string emailRSVP)
        : base(title, description, date, time, address)
    {
        SetEmailRSVP(emailRSVP);
    }

    public void DisplayFullDetailsReceptions()
    {
        DisplayStandardDetails();
        Console.WriteLine();
        Console.WriteLine($"Event type: {GetEventType()}");
        Console.WriteLine($"{this.GetMessage()}");
    }

    public void DisplayShortDescReceptions()
    {
        Console.WriteLine($"\nEvent type: {GetEventType() }");
        Console.WriteLine($"{GetTitleDate()}");
    }
}

