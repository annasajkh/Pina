using Pina.Scripts.Abstracts;
using Pina.Scripts.Core;
using Pina.Scripts.Extensions;
using Pina.Scripts.Resources;
using Raylib_cs;

namespace Demo;

public class World : Scene
{
    private Color color = Color.White;

    private ImageResource catImageResource;
    private TextureResource catTextureResource;

    public override void Load()
    {
        catImageResource = ResourceManager.Init<ImageResource>("catImage").Load("Assets/Sprites/cat.png");
        catTextureResource = ResourceManager.Init<TextureResource>("catTexture").LoadFromImage(catImageResource.image);
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
        catImageResource.Rotate((int)Application.Time % 360);
    }

    public override void Draw()
    {
        Graphics.BeginDrawing();
        Graphics.ClearBackground(Color.Black);

        Graphics.DrawTexture(catTextureResource.texture, 100, 100, color);

        Graphics.EndDrawing();
    }
}
