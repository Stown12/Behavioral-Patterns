namespace Behavioral_Patterns.State;

public class RedState: ITrafficLightState
{
    private TrafficLight _context;
    
    public RedState(TrafficLight context)
    {
        _context = context;
    }
    
    public void Handle(TrafficLight context)
    {
        _context.SetState(context.GetGreenState());
    }

    public void Display()
    {
        Console.WriteLine("[RED] STOP!!");
        Handle(_context);
    }
}

public class YellowState: ITrafficLightState
{
    private TrafficLight _context;
    
    public YellowState(TrafficLight context)
    {
        _context = context;
    }
    
    public void Handle(TrafficLight context)
    {
        _context.SetState(context.GetRedState());
    }

    public void Display()
    {
        Console.WriteLine("[YELLOW] SLOW DOWN!!");
        this.Handle(_context);
    }
}

public class GreenState: ITrafficLightState
{
    private TrafficLight _context;
    
    public GreenState(TrafficLight context)
    {
        _context = context;
    }
    
    public void Handle(TrafficLight context)
    {
        _context.SetState(context.GetYellowState());
    }

    public void Display()
    {
        Console.WriteLine("[GREEN] GO!!");
        _context.SetState(_context.GetYellowState());
    }
}

