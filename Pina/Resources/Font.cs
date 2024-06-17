
using Raylib_cs;
using System.Numerics;
using System.Text;
using RaylibFont = Raylib_cs.Font;

namespace Pina.Resources;

public class Font : Resource
{
    /// <summary>
    /// The size of the font
    /// NOTE: Don't change this during runtime it will cause weird artifacts and blurriness
    /// </summary>
    public int FontSize { get; set; }

    /// <summary>
    /// The spacing of the font
    /// </summary>
    public float Spacing { get; set; } = 1; 

    public RaylibFont raylibFont;

    /// <summary>
    /// Determine if the font is ready
    /// </summary>
    public bool Ready
    {
        get
        {
            return Raylib.IsFontReady(raylibFont);
        }
    }

    /// <summary>
    /// Get the defult font, y'know the font
    /// </summary>
    public static RaylibFont DefaultFont
    {
        get
        {
            return Raylib.GetFontDefault();
        }
    }

    /// <summary>
    /// Load font from file into GPU memory (VRAM)
    /// </summary>
    /// <param name="fileName">The file name of the font to load</param>
    public static Font Load(string fileName, int fontSize)
    {
        Font font = new Font();

        font.raylibFont = Raylib.LoadFontEx(fileName, fontSize, null, 0);
        font.FontSize = font.raylibFont.BaseSize;

        return font;
    }

    /// <summary>
    /// Load font from Image (XNA style)
    /// </summary>
    public static Font LoadFontFromImage(Image image, Color key, int firstChar)
    {
        Font font = new Font();

        font.raylibFont = Raylib.LoadFontFromImage(image.raylibImage, key, firstChar);
        font.FontSize = font.raylibFont.BaseSize;

        return font;
    }

    /// <summary>
    /// Load font from managed memory, fileType refers to extension: i.e. "ttf"
    /// </summary>
    public static Font LoadFromMemory(string fileType, byte[] fileData, int fontSize)
    {
        Font font = new Font();

        font.raylibFont = Raylib.LoadFontFromMemory(fileType, fileData, fontSize, null, 0);
        font.FontSize = font.raylibFont.BaseSize;
        
        return font;
    }

    /// <summary>
    /// Get glyph rectangle in font atlas for a codepoint (unicode character), fallback to '?' if not found
    /// </summary>
    public Rectangle GetGlyphAtlasRec(int codePoint)
    {
        return Raylib.GetGlyphAtlasRec(raylibFont, codePoint);
    }

    /// <summary>
    /// Get glyph font info data for a codepoint (unicode character), fallback to '?' if not found
    /// </summary>
    public GlyphInfo GetGlyphInfo(int codePoint)
    {
        return Raylib.GetGlyphInfo(raylibFont, codePoint);
    }

    /// <summary>
    /// Get glyph index position in font for a codepoint (unicode character), fallback to '?' if not found
    /// </summary>
    public int GetGlyphIndex(int codePoint)
    {
        return Raylib.GetGlyphIndex(raylibFont, codePoint);
    }

    /// <summary>
    /// Measure string size for this font
    /// </summary>
    public Vector2 MeasureEx(string text)
    {
        return Raylib.MeasureTextEx(raylibFont, text, FontSize, Spacing);
    }

    /// <summary>
    /// Export font as code file, returns true on success
    /// </summary>
    public bool ExportAsCode(string fileName)
    {
        byte[] fileNameBytes = Encoding.ASCII.GetBytes(fileName);

        unsafe
        {
            fixed (byte* fileNamePtr = fileNameBytes)
            {
                return Raylib.ExportFontAsCode(raylibFont, (sbyte*)fileNamePtr);
            }
        }
    }

    /// <summary>
    /// Unload font from GPU memory (VRAM)
    /// </summary>
    protected override void Unload()
    {
        if (!Ready)
        {
            throw new Exception("Error: Font is not loaded yet");
        }

        Raylib.UnloadFont(raylibFont);

        base.Unload();
    }

    protected override void Dispose(bool disposing)
    {
        Unload();
    }
}
