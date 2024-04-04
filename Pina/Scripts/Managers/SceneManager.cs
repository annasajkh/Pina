using Pina.Scripts.Abstracts;

namespace Pina.Scripts.Managers;

public sealed class SceneManager
{
    public Scene ActiveScene { get; private set; }

    private Dictionary<string, Scene> scenes = new Dictionary<string, Scene>();

    public SceneManager(string initialSceneName, Scene initialScene)
    {
        ActiveScene = initialScene;
        scenes.Add(initialSceneName, initialScene);
    }

    public void AddScene(string name, Scene scene)
    {
        scenes.Add(name, scene);
    }

    public void RemoveScene(string name)
    {
        if (ActiveScene == scenes[name])
        {
            throw new Exception("Error: Cannot unload active scene");
        }

        ActiveScene.Unload();
        scenes.Remove(name);
    }

    public void ChangeScene(string sceneName)
    {
        ActiveScene.Unload();
        ActiveScene = scenes[sceneName];

        ActiveScene.Load();
        ActiveScene.Init();
    }
}