using Pina.Scripts.Core;
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
        Graphics.BeginDrawing();

        Graphics.ClearBackground(Color.Black);

        Graphics.DrawTexture(ResourceManager.Get<TextureResource>("cat").Texture, 100, 100, Color.White);

        Graphics.EndDrawing();
    }
}
