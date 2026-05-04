using Behavioral_Patterns.Chain_Responsability;
using Behavioral_Patterns.Observer;

public class Program
{
    public static void Main(string[] args)
    {
        NewsAgency agency = new NewsAgency();

        IObserver email = new EmailSubscriber("jesus@mail.com");
        IObserver sms = new SmsSubscriber("+52 123 456");

        agency.AddObserver(email);
        agency.AddObserver(sms);

        agency.PublishNews("C# 13 released!");

        agency.RemoveObserver(sms);

        agency.PublishNews("Design Patterns are awesome!");
    }
}