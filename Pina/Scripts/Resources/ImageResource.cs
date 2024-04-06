using Raylib_cs;

namespace Pina.Scripts.Resources;

public sealed class ImageResource : Resource
{
    public Image Image { get; private set; }


    /// <summary>
    /// Unload image from CPU memory (RAM)
    /// </summary>
    public override void Unload()
    {
        base.Unload();

        Raylib.UnloadImage(Image);
    }
}
