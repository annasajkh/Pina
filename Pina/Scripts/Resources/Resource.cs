namespace Pina.Scripts.Resources;

public abstract class Resource
{
    public abstract bool Ready { get; }

    public virtual void Unload()
    {

    }
}