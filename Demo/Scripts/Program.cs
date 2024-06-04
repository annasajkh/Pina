using Demo.Scripts.Scenes;
using Pina.Scripts.Core;
using Pina.Scripts.Core.Types;
using Pina.Scripts.Managers;

namespace Demo.Scripts;

internal static class Program
{
    static void Main()
    {
        var windowConfig = new WindowConfig(title: "Cat Shooter", size: new Vector2i(960, 540));
        var sceneManager = new SceneManager();

        sceneManager.AddScene("MainMenu", new MainMenu());
        sceneManager.AddScene("World", new World());

        sceneManager.SetActiveScene("MainMenu");

        Application.Run(windowConfig, sceneManager);
    }
}