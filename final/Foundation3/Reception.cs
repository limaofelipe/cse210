
public class Reception : Event
{
    private string _rsvpName;
    private int _numberOfAttendee;

    public Reception()
    {
        SetEventType("Reception");
    }

    private void SetRSVPName()
    {
        Console.Write("Enter your name: ");
        _rsvpName = Console.ReadLine();
    }

    public string GetRSVPName()
    {
        return _rsvpName;
    }

    private void SetNumberOfAttendee()
    {
        Console.Write("Enter capacity of attendees: ");
        _numberOfAttendee = int.Parse(Console.ReadLine());
    }

    public int GetNumberOfAttendee()
    {
        return _numberOfAttendee;
    }

    public void BookReceptionEvent()
    {
        SetRSVPName();
        SetNumberOfAttendee();
        BookEvent();
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine($"RSVP: {GetRSVPName()}\nNumber of attendee: {GetNumberOfAttendee()}");
        DisplayStandardDetails();
    }
}