namespace Behavioral_Patterns.Observer;

public interface ISubject
{
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers(); 
}
        
public interface IObserver
{
    void Update(List<string> news);
}