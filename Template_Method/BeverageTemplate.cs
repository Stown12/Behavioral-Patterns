namespace Behavioral_Patterns.Template_Method;

public abstract class BeverageTemplate
{
    public IReadOnlyList<string> Prepare()
    {
        List<string> result = new()
        {
            BoilWater(),
            Brew(),
            PourInCup(),
            AddCondiments(),
        };

        return result;
    }

    public string BoilWater() => "Boiling water...";

    public abstract string Brew();

    public string PourInCup() => "Pouring into cup...";

    public virtual string AddCondiments() => "Adding suggar...";
}