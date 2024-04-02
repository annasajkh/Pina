namespace Pina.Scripts.Resources;

public abstract class Resource
{
    public abstract void Load(string path);

    public virtual void Unload()
    {
        Console.WriteLine($"Resource: [{GetType()}] is Unloaded");
    }
}