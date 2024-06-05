namespace Pina.Abstracts;

public abstract class Scene : IDisposable
{
    public abstract void Load();
    public abstract void Init();
    public abstract void GetInput();
    public abstract void Update(float delta);
    public abstract void Draw();

    public virtual void Dispose()
    {
        Console.WriteLine($"Scene: {GetType().Name} is unloaded");
    }

    public void DisposeInternal()
    {
        Dispose();
    }
}
