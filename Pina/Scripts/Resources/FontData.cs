using Raylib_cs;

namespace Pina.Scripts.Resources;

public class FontData : Resource
{
    public unsafe GlyphInfo* chars;

    /// <summary>
    /// Load font data for further use
    /// </summary>
    public static unsafe FontData Load(byte* fileData, int dataSize, int fontSize, int* fontChars, int glyphCount, FontType type)
    {
        FontData fontData = new FontData();

        fontData.chars = Raylib.LoadFontData(fileData, dataSize, fontSize, fontChars, glyphCount, type);

        return fontData;
    }

    /// <summary>
    /// Unload font chars info data (RAM)
    /// </summary>
    protected void Unload(int glyphCount)
    {
        Unload();

        unsafe
        {
            Raylib.UnloadFontData(chars, glyphCount);
        }

        base.Unload();
    }

    protected override void Dispose(bool disposing)
    {
        throw new NotImplementedException();
    }
}
