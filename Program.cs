using Behavioral_Patterns.State;
using Behavioral_Patterns.Template_Method;

public class Program
{
    public static void Main(string[] args)
    {
        BeverageTemplate tea = new Tea();
        BeverageTemplate coffee = new Coffee();

        tea.Prepare();
        Console.WriteLine("---");
        coffee.Prepare();
    }
}