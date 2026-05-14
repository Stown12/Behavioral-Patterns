namespace Behavioral_Patterns.State;

public interface ITrafficLightState
{
    void Handle(TrafficLight context);
    void Display();
}