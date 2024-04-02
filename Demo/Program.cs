using Pina.Scripts.Core;
using Pina.Scripts.Managers;

namespace Demo;

internal static class Program
{
    public static SceneManager SceneManager { get; } = new("MainMenu", new MainMenu());

    static void Main()
    {
        Window.Title = "Demo";

        SceneManager.AddScene("World", new World());

        Application.Run(SceneManager);
    }
}