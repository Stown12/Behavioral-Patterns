namespace Behavioral_Patterns.Template_Method;

public class Tea: BeverageTemplate
{
    public override string Brew() => "Steeping the tea...";
    public override string AddCondiments() => "Adding lemon...";
}

public class Coffee : BeverageTemplate
{
    public override string Brew() => "Dripping coffee through filter...";
}