using Demo.Scripts.Scenes;
using Pina.Core;
using Pina.Managers;
using Pina.Resources;
using Pina.Types;

namespace Demo.Scripts;

internal static class Program
{
    static void Main()
    {
        var windowConfig = new WindowConfig(title: "Cat Shooter", size: new Vector2i(960, 540));

        windowConfig.Icon = Image.Load(Path.Combine("Assets", "Icons", "pineapple.png"));
        windowConfig.Resizable = true;

        var sceneManager = new SceneManager();

        sceneManager.AddScene("MainMenu", new MainMenu());
        sceneManager.AddScene("World", new World());

        sceneManager.SetActiveScene("MainMenu");

        Application.Run(windowConfig, sceneManager);
    }
}