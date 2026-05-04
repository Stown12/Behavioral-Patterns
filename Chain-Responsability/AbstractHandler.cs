namespace Behavioral_Patterns.Chain_Responsability;

public abstract class AbstractHandler
{
    private AbstractHandler _next;
    public AbstractHandler(AbstractHandler next)
    {
        _next = next;
    }

    public virtual void HandleRequest(AbstractRequest requestCode)
    {
        if (_next != null)
        {
            _next.HandleRequest(requestCode);
        }
    }
}

public abstract class AbstractRequest
{
    private int _requestCode;

    public AbstractRequest(int requestCode)
    {
        _requestCode = requestCode;
    }
    
    public int GetRequestCode => _requestCode;
}