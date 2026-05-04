namespace Behavioral_Patterns.Chain_Responsability;

public class Level1Suport: AbstractHandler
{
    private static int code = 1;
    public Level1Suport(AbstractHandler next) : base(next)
    {
    }

    public override void  HandleRequest(AbstractRequest request)
    {
        if (code == request.GetRequestCode)
        {
            Console.WriteLine($"{request.GetRequestCode} is handled by Level 1 Support");
            
        }
        else
        {
            base.HandleRequest(request);
        }
    }
}

public class Level2Support: AbstractHandler
{
    private static int code = 2;
    public Level2Support(AbstractHandler next) : base(next)
    {
    }

    public override void  HandleRequest(AbstractRequest request)
    {
        if (code == request.GetRequestCode)
        {
            Console.WriteLine($"{request.GetRequestCode} is handled by Level 2 Support");
        }
        else
        {
            base.HandleRequest(request);
        }
    }
}
public class Level3Support: AbstractHandler
{
    private static int code = 3;
    public Level3Support(AbstractHandler next) : base(next)
    {
    }

    public override void  HandleRequest(AbstractRequest request)
    {
        if (code == request.GetRequestCode)
        {
            Console.WriteLine($"{request.GetRequestCode} is handled by Level 3 Support");
        }
        else
        {
            base.HandleRequest(request);
        }
    }
}

public class DefaultSupport: AbstractHandler
{
    private static int code = 00000;
    public DefaultSupport(AbstractHandler next) : base(next)
    {
    }

    public override void HandleRequest(AbstractRequest request)
    {
        if (code != request.GetRequestCode)
        {
            Console.WriteLine($"{request.GetRequestCode} is handled by Default Support");
        }
        else
        {
            base.HandleRequest(request);
        }
    }
}