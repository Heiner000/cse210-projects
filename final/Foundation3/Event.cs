public class Event
{
    protected string _title;
    private string _description;
    protected string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"{_title}\n{_description}\n{_date} {_time}\n{_address.GetAddressLabel()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Event Type: {GetType().Name}\nTitle: {_title}\nDate: {_date}";
    }
}