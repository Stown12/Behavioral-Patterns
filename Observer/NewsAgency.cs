namespace Behavioral_Patterns.Observer;

public class NewsAgency: ISubject
{
    private List<IObserver> _observers = [];
    private string _latestNew = string.Empty;
    
    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_latestNew);
        }
    }

    public void PublishNews(string latestNew)
    {
        _latestNew = latestNew;
        NotifyObservers();
    }
}

public class EmailSubscriber: IObserver
{
    private string _email;

    public EmailSubscriber(string email)
    {
        _email = email;    
    }
    
    public void Update(string latestNew)
    {
        Console.WriteLine($"[Email]: {_email}, received: {latestNew}");
    }
}

public class SmsSubscriber: IObserver
{
    private string _sms;
    public SmsSubscriber(string sms)
    {
        _sms = sms;
    }
    
    public void Update(string latestNew)
    {
        Console.WriteLine($"[SMS]: {_sms}, receive: {latestNew}");
    }
}