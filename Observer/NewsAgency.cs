namespace Behavioral_Patterns.Observer;

public class NewsAgency: ISubject
{
    private List<IObserver> _observers = [];
    private List<string> _news = [];
    
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
            observer.Update(_news);
        }
    }

    public void PublishNews(string news)
    {
        _news.Add(news);
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
    
    public void Update(List<string> news)
    {
        Console.WriteLine($"[Email]: {_email}, received: {string.Join(", ", news)}");
    }
}

public class SmsSubscriber: IObserver
{
    private string _sms;
    public SmsSubscriber(string sms)
    {
        _sms = sms;
    }
    
    public void Update(List<string> news)
    {
        Console.WriteLine($"[SMS]: {_sms}, receive: {string.Join(", ", news)}");
    }
}