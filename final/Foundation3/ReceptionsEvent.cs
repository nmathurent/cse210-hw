// Encapsulation with Online Ordering Program    Week 12
// Author : Nelson Mathurent
// Date:    Mar 22, 2023

public class ReceptionsEvent : Event
{
    private string _emailRSVP;
    
    public string GetEmailRSVP() {
        return _emailRSVP;
    }
    public void SetEmailRSVP(string emailRSVP) {
        _emailRSVP = emailRSVP;
    }

// Constructor 
    public ReceptionsEvent(string title, string description, string date, string time, Address address, string emailRSVP)
        : base(title, description, date, time, address)
    {
        SetEmailRSVP(emailRSVP);
    }

}

