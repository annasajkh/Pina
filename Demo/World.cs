using Pina.Scripts.Abstracts;
using Pina.Scripts.Core;
using Pina.Scripts.Extensions;
using Pina.Scripts.Resources;
using Raylib_cs;
using System.Numerics;

namespace Demo;

public class World : Scene
{
    public static Camera2D Camera;

    public override void Load()
    {
        ResourceManager.Init<TextureResource>("cat").Load("Assets/Sprites/cat.png");
    }

    public override void Init()
    {
        Camera = new Camera2D(Vector2.Zero, Vector2.Zero, 0, 1);
    }

    public override void GetInput()
    {
        
    }

    public override void Update(float delta)
    {
        Camera.Target.X += delta * 100;

        Console.WriteLine(Camera.GetMatrix2D());
    }

    public override void Draw()
    {
        Graphics.BeginDrawing();

        Graphics.BeginMode2D(Camera);

        Graphics.ClearBackground(Color.Black);

        Graphics.DrawTexture(ResourceManager.Get<TextureResource>("cat").Texture, 100, 100, Color.White);

        Graphics.EndMode2D();

        Graphics.EndDrawing();
    }
}
