using Raylib_cs;

namespace Pina.Scripts.Resources;

public sealed class TextureResource : Resource
{
    public Texture2D Texture { get; private set; }

    private TextureFilter textureFilter;
    public TextureFilter TextureFilter
    {
        get
        {
            return textureFilter;
        }

        set
        {
            textureFilter = value;
            Raylib.SetTextureFilter(Texture, textureFilter);
        }
    }

    private TextureWrap textureWrap;
    public TextureWrap TextureWrap
    {
        get
        {
            return textureWrap;
        }

        set
        {
            textureWrap = value;
            Raylib.SetTextureWrap(Texture, textureWrap);
        }
    }

    public void Load(string path, TextureFilter textureFilter = TextureFilter.Bilinear, TextureWrap textureWrap = TextureWrap.Clamp)
    {
        Texture = Raylib.LoadTexture(path);
        TextureFilter = textureFilter;
        TextureWrap = textureWrap;
    }

    public override void Unload()
    {
        base.Unload();

        Raylib.UnloadTexture(Texture);
    }
}