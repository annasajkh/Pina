using Demo.Scripts.Scenes;
using Pina.Scripts.Core;
using Pina.Scripts.Core.Types;
using Pina.Scripts.Managers;
using System.Security.Principal;

namespace Demo.Scripts;

internal static class Program
{
    static void Main()
    {
        WindowConfig windowConfig = new WindowConfig(title: "Cat Shooter", size: new(960, 540));

        var sceneManager = new SceneManager();

        sceneManager.AddScene("MainMenu", new MainMenu());
        sceneManager.AddScene("World", new World());

        sceneManager.SetActiveScene("MainMenu");

        Application.Run(sceneManager, windowConfig);
    }
}