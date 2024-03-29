// Inheritance with Event Planning Program    Week 13
// Author : Nelson Mathurent
// Date:    Mar 29, 2023

public class LectureEvent : Event
{
    private string _speakerName;
    private int _capacity;
    
    public string GetEventType() {
        return "Lecture";
    }
    public string GetSpeakerName() {
        return _speakerName;
    }
    public void SetSpeakerName(string speakerName) {
        _speakerName = speakerName;
    }
    public int GetCapacityn() {
        return _capacity;
    }
    public void SetCapacity(int capacity) {
        _capacity = capacity;
    }

    public string GetMessage() {
        return $"Speaker: {GetSpeakerName()} - Capacity: {GetCapacityn()}";
    }

// Constructor 
    public LectureEvent(string title, string description, string date, string time, Address address, string speakerName, int capacity)
        : base(title, description, date, time, address)
    {
        SetSpeakerName(speakerName);
        SetCapacity(capacity);
    }

    public void DisplayFullDetailsLecture()
    {
        Console.WriteLine();
        DisplayStandardDetails();
        Console.WriteLine($"Event type: {GetEventType()}");
        Console.WriteLine($"{this.GetMessage()}");
    }

    public void DisplayShortDescLecture()
    {
        Console.WriteLine($"\nEvent type: {GetEventType() }");
        Console.WriteLine($"{GetTitleDate()}");
    }
}

