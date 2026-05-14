using Behavioral_Patterns.State;
using Behavioral_Patterns.Template_Method;

public class Program
{
    public static void Main(string[] args)
    {
        BeverageTemplate tea = new Tea();
        BeverageTemplate coffee = new Coffee();

        foreach (var step in tea.Prepare())
        {
            Console.WriteLine(step);
        }

        Console.WriteLine("---");

        foreach (var step in coffee.Prepare())
        {
            Console.WriteLine(step);
        }
    }
}