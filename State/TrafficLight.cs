namespace Behavioral_Patterns.State;

public class TrafficLight
{
    private RedState _redState;
    private GreenState _greenState;
    private YellowState _yellowState;
    private ITrafficLightState _currentState;

    public TrafficLight()
    {
        _redState = new RedState(this);
        _greenState = new GreenState(this);
        _yellowState = new YellowState(this);
        _currentState = _redState;
    }

      
    public void SetState(ITrafficLightState state)
    {
        _currentState = state;
    }

    public void Request()
    {
        _currentState.Display();
    }

    public RedState GetRedState() => _redState;
    public GreenState GetGreenState() => _greenState;
    public YellowState GetYellowState() => _yellowState;
}