// Encapsulation with Online Ordering Program    Week 12
// Author : Nelson Mathurent
// Date:    Mar 22, 2023

public class LectureEvent : Event
{
    private string _speakerName;
    private int _capacity;
    
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

// Constructor 
    public LectureEvent(string title, string description, string date, string time, Address address, string speakerName, int capacity)
        : base(title, description, date, time, address)
    {
        SetSpeakerName(speakerName);
        SetCapacity(capacity);
    }

}

