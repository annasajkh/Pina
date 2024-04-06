using Pina.Scripts.Abstracts;
using Pina.Scripts.Core;
using Raylib_cs;

namespace Demo;

internal class MainMenu : Scene
{
    public override void Load()
    {

    }

    public override void Init()
    {
        
    }

    public override void GetInput()
    {
        if (Input.IsKeyPressed(KeyboardKey.Enter))
        {
            Application.SceneManager.ChangeScene("World");
        }
    }

    public override void Update(float delta)
    {

    }

    public override void Draw()
    {
        Graphics.BeginDrawing();

        Graphics.ClearBackground(Color.Black);

        Graphics.DrawText("Press Enter to Play", Window.Size.X / 2 - 100, Window.Size.Y / 2, 20, Color.White);

        Graphics.EndDrawing();
    }
}
