using Demo.Scripts.Scenes;
using Pina.Scripts.Core;
using Pina.Scripts.Managers;
using System.Security.Principal;

namespace Demo.Scripts;

internal static class Program
{
    static void Main()
    {
        Window.Title = "Cat Shooter";

        var sceneManager = new SceneManager();

        sceneManager.AddScene("MainMenu", new MainMenu());
        sceneManager.AddScene("World", new World());
        sceneManager.SetActiveScene("MainMenu");

        Application.Run(sceneManager);
    }
}