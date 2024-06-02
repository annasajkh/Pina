using Demo.Scripts.Scenes;
using Pina.Scripts.Core;
using Pina.Scripts.Managers;

namespace Demo.Scripts;

internal static class Program
{
    static void Main()
    {
        Window.Title = "Cat Shooter";

        var sceneManager = new SceneManager("MainMenu", new MainMenu());

        sceneManager.AddScene("World", new World());

        Application.Run(sceneManager);
    }
}