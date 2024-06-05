
public class Lectures : Event
{
    private string _speakerName;
    private int _eventCapacity;

    public Lectures()
    {
        SetEventType("Lectures");
    }

    private void SetSpeakerName()
    {
        Console.Write("Enter your name: ");
        _speakerName = Console.ReadLine();
    }

    public string GetSpeakerName()
    {
        return _speakerName;
    }

    private void SetEventCapacity()
    {
        Console.Write("Enter capacity of attendees: ");
        _eventCapacity = int.Parse(Console.ReadLine());
    }

    public int GetEventCapacity()
    {
        return _eventCapacity;
    }

    public void BookLectureEvent()
    {
        SetSpeakerName();
        SetEventCapacity();
        BookEvent();
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine($"\nSpeaker: {GetSpeakerName()}\nEvent capacity: {GetEventCapacity()}\n");
        DisplayStandardDetails();
    }
}