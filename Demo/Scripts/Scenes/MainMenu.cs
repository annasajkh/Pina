using Pina.Abstracts;
using Pina.Core;
using Raylib_cs;
using System.Numerics;
using Font = Pina.Resources.Font;

namespace Demo.Scripts.Scenes;

internal class MainMenu : Scene
{
    string playText = "Press Enter To Play";
    Font font;

    public override void Load()
    {
        font = Font.Load(Path.Combine("Assets", "Fonts", "Arial.ttf"), fontSize: 25);
    }

    public override void Init()
    {
        Console.WriteLine(font.MeasureEx(playText).X);
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

        Graphics.ClearBackground(new Color(0, 0, 0, 0));

        Graphics.DrawTextEx(font.raylibFont, playText, new Vector2(Window.Size.X / 2 - font.MeasureEx(playText).X / 2, Window.Size.Y / 2 - font.MeasureEx(playText).Y / 2), font.FontSize, font.Spacing, Color.White);

        Graphics.EndDrawing();
    }
}