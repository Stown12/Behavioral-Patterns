namespace Behavioral_Patterns.Template_Method;

public class Tea: BeverageTemplate
{
    public override void Brew() => Console.WriteLine("Steeping the tea...");
    public override void AddCondiments() => Console.WriteLine("Adding lemon...");
}

public class Coffee : BeverageTemplate
{
    public override void Brew() => Console.WriteLine("Dripping coffee through filter...");
}