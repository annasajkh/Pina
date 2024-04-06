using Pina.Scripts.Core;
using Pina.Scripts.Managers;

namespace Demo;

internal static class Program
{
    static void Main()
    {
        Window.Title = "Demo";

        var sceneManager = new SceneManager("MainMenu", new MainMenu());
        var resourceManager = new ResourceManager();

        sceneManager.AddScene("World", new World());

        Application.Run(sceneManager, resourceManager);
    }
}