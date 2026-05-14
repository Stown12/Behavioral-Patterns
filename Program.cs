using Behavioral_Patterns.State;

public class Program
{
    public static void Main(string[] args)
    {
        TrafficLight light = new TrafficLight();

        for (int i = 0; i < 6; i++)
        {
            light.Request();
        }
    }
}