using Pina.Scripts.Resources;
using Pina.Scripts.Utilities.Abstracts;
using Raylib_cs;

namespace Demo;

public class World : Scene
{
    public override void Load()
    {
        ResourceManager.Load<TextureResource>("cat", "Assets/Sprites/cat.png");
    }

    public override void Init()
    {
        
    }

    public override void GetInput()
    {
        
    }

    public override void Update(float delta)
    {

    }

    public override void Draw()
    {
        Raylib.BeginDrawing();

        Raylib.ClearBackground(Color.Black);

        Raylib.DrawTexture(ResourceManager.Get<TextureResource>("cat").Texture, 100, 100, Color.White);

        Raylib.EndDrawing();
    }
}
