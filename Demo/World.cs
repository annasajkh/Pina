using Pina.Scripts.Abstracts;
using Pina.Scripts.Core;
using Pina.Scripts.Extensions;
using Pina.Scripts.Resources;
using Raylib_cs;
using Timer = Pina.Scripts.Components.Timer;

namespace Demo;

public class World : Scene
{
    private Color color = Color.White;

    private ImageResource catImageResource;
    private TextureResource catTextureResource;

    private Timer changeTimer = new(0.01f, false);
    private Random random = new();

    public override void Load()
    {
        Console.WriteLine("---------------------------------------------------------");
        catImageResource = ResourceManager.Init<ImageResource>("catImage").Load("Assets/Sprites/cat.png");
        catTextureResource = ResourceManager.Init<TextureResource>("catTexture").LoadFromImage(catImageResource.Image);

        changeTimer.OnTimeout += () =>
        {
            catImageResource.ColorInvert();
            catImageResource.FlipHorizontal();
            catImageResource.DrawCircle(random.Next(100), random.Next(100), 10, Color.Red);
            catTextureResource.LoadFromImage(catImageResource.Image);
        };

        changeTimer.Start();
    }

    public override void Init()
    {

    }

    public override void GetInput()
    {
        if (Input.IsKeyPressed(KeyboardKey.Q))
        {
            Application.SceneManager.ChangeScene("MainMenu");
        }
    }

    public override void Update(float delta)
    {
        color.Alpha((float)((Math.Sin(Application.Time * 5) + 1) / 2));

        changeTimer.Step(delta);
    }

    public override void Draw()
    {
        Graphics.BeginDrawing();
        Graphics.ClearBackground(Color.Black);

        Graphics.DrawTexture(catTextureResource.Texture2D, 100, 100, color);

        Graphics.EndDrawing();
    }

    public override void Unload()
    {
        base.Unload();

        Console.WriteLine("---------------------------------------------------------");
    }
}
