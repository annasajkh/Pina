namespace Pina.Scripts.Resources;

public abstract class Resource : IDisposable
{
    protected virtual void Unload()
    {
        Console.WriteLine($"Resource: {GetType()} is unloaded");
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected abstract void Dispose(bool disposing);

    ~Resource()
    {
        Dispose();
    }
}