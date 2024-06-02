using Pina.Scripts.Abstracts;

namespace Pina.Scripts.Managers;

public sealed class SceneManager
{
    public Scene? ActiveScene { get; private set; }

    private Dictionary<string, Scene> scenes = new Dictionary<string, Scene>();

    /// <summary>
    /// Add a scene to the scene manager
    /// </summary>
    /// <param name="name">The name of the scene</param>
    /// <param name="scene">The scene</param>
    public void AddScene(string name, Scene scene)
    {
        scenes.Add(name, scene);
    }

    /// <summary>
    /// Set the active scene of the scene manager
    /// </summary>
    /// <param name="name">The name of the scene</param>
    /// <exception cref="Exception">Throw an exception if the scene doesn't exist</exception>
    public void SetActiveScene(string name)
    {
        Scene? scene;

        if (scenes.TryGetValue(name, out scene))
        {
            ActiveScene = scenes[name];
        }
        else
        {
            throw new Exception($"Error: Scene with the name {name} doesn't exist in the scene manager");
        }

        ActiveScene = scenes[name];
    }

    /// <summary>
    /// Remove a scene from the scene manager
    /// </summary>
    /// <param name="name">The scene name</param>
    /// <exception cref="Exception">Exception if the the scene manager doesn't have an active scene or if you trying to remove an active scene</exception>
    public void RemoveScene(string name)
    {
        if (ActiveScene == null)
        {
            throw new Exception("Error: Scene manager doesn't contain active scene");
        }

        if (ActiveScene == scenes[name])
        {
            throw new Exception("Error: Cannot unload active scene");
        }

        ActiveScene.DisposeInternal();
        scenes.Remove(name);
    }

    /// <summary>
    /// Change to different scene
    /// </summary>
    /// <param name="name">The name of the scene</param>
    /// <exception cref="Exception">Exception if the scene manager doesn't have an active scene</exception>
    public void ChangeScene(string name)
    {
        if (ActiveScene == null)
        {
            throw new Exception("Error: Scene Manager doesn't contain active scene");
        }

        ActiveScene.DisposeInternal();
        ActiveScene = scenes[name];

        ActiveScene.Load();
        ActiveScene.Init();
    }
}