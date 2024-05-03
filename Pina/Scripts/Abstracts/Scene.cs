using Pina.Scripts.Managers;

namespace Pina.Scripts.Abstracts;

public abstract class Scene
{
    public ResourceManager ResourceManager { get; } = new ResourceManager();

    public abstract void Load();
    public abstract void Init();
    public abstract void GetInput();
    public abstract void Update(float delta);
    public abstract void Draw();

    public virtual void Unload()
    {
        Console.WriteLine($"Scene: {GetType().Name} is unloaded");
    }

    public void UnloadInternal()
    {
        Unload();
        ResourceManager.UnloadAll();
    }
}
