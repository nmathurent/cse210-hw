// Inheritance with Event Planning Program    Week 13
// Author : Nelson Mathurent
// Date:    Mar 29, 2023

public class OutdoorEvent : Event
{
    private string _weatherStatement;
    
    public string GetEventType() {
        return "Outdoor";
    }
    public string GetWeatherStatement() {
        return _weatherStatement;
    }
    public void SetWeatherStatement(string weatherStatement) {
        _weatherStatement = weatherStatement;
    }

    public string GetMessage() {
        return $"Statement of the weather: {GetWeatherStatement()}";
    }

// Constructor 
    public OutdoorEvent(string title, string description, string date, string time, Address address, string weatherStatement)
        : base(title, description, date, time, address)
    {
        SetWeatherStatement(weatherStatement);
    }

    public void DisplayFullDetailsOutdoor()
    {
        DisplayStandardDetails();
        Console.WriteLine();
        Console.WriteLine($"Event type: {GetEventType()}");
        Console.WriteLine($"{this.GetMessage()}");
    }

    public void DisplayShortDescOutdoor()
    {
        Console.WriteLine($"\nEvent type: {GetEventType() }");
        Console.WriteLine($"{GetTitleDate()}");
    }

}

