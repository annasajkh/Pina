using Raylib_cs;

namespace Pina.Core;

public class Text
{
    /// <summary>
    /// Set vertical line spacing when drawing with line-breaks
    /// </summary>
    public static void SetLineSpacing(int spacing)
    {
        Raylib.SetTextLineSpacing(spacing);
    }

    /// <summary>
    /// Measure string width for default font
    /// </summary>
    public static int Measure(string text, int fontSize)
    {
        return Raylib.MeasureText(text, fontSize);
    }
}
