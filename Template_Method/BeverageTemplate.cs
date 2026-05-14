namespace Behavioral_Patterns.Template_Method;

public abstract class BeverageTemplate
{
    public void Prepare()
    {
        
        BoilWater();
        Brew();
        PourInCup();
        AddCondiments();
    }

    public void BoilWater() => Console.WriteLine("Boiling water...");

    public abstract void Brew();

    public void PourInCup() => Console.WriteLine("Pouring into cup...");

    public virtual void AddCondiments() {}
}