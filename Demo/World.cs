using Pina.Scripts.Abstracts;
using Pina.Scripts.Core;
using Pina.Scripts.Extensions;
using Pina.Scripts.Resources;
using Raylib_cs;

namespace Demo;

public class World : Scene
{
    private static Color color = Color.White;

    public override void Load()
    {
        ResourceManager.Init<ImageResource>("catImage").Load("Assets/Sprites/cat.png");
        ResourceManager.Init<TextureResource>("catTexture").LoadFromImage(ResourceManager.Get<ImageResource>("catImage").Image);
    }

    public override void Init()
    {

    }

    public override void GetInput()
    {
        if (Input.IsKeyPressed(KeyboardKey.Escape))
        {
            Application.SceneManager.ChangeScene("MainMenu");
        }
    }

    public override void Update(float delta)
    {
        color.Alpha((float)((Math.Sin(Application.Time * 5) + 1) / 2));
    }

    public override void Draw()
    {
        Graphics.BeginDrawing();
        Graphics.ClearBackground(Color.Black);

        Graphics.DrawTexture(ResourceManager.Get<TextureResource>("cat").Texture, 100, 100, color);

        Graphics.EndDrawing();
    }
}
