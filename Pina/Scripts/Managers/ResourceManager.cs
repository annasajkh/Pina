using Pina.Scripts.Resources;

namespace Pina.Scripts.Managers;

public sealed class ResourceManager
{
    private Dictionary<string, Resource> resourcesDictionary = new();

    public T Get<T>(string key) where T : Resource
    {
        return (T)resourcesDictionary[key];
    }

    public T Init<T>(string key) where T : Resource, new()
    {
        T resource = new();

        resourcesDictionary.Add(key, resource);

        return resource;
    }

    public void Unload<T>(string key) where T : Resource
    {
        resourcesDictionary[key].Unload();
        resourcesDictionary.Remove(key);
    }

    public void UnloadAll()
    {
        foreach (var item in resourcesDictionary)
        {
            item.Value.Unload();
        }

        resourcesDictionary.Clear();
    }
}