using Behavioral_Patterns.Chain_Responsability;

public class Program
{
    public static void Main(string[] args)
    {
        AbstractHandler support = new Level1Suport(new Level2Support(new Level3Support(new DefaultSupport(null))));
        
        support.HandleRequest(new SupportRequest(1));
        support.HandleRequest(new SupportRequest(2));
        support.HandleRequest(new SupportRequest(3));
        support.HandleRequest(new SupportRequest(8493));
    }
}