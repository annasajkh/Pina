using Raylib_cs;

namespace Pina.Scripts.Extensions;


public static class ColorExtensions
{
    /// <summary>
    /// Get color with alpha applied, alpha goes from 0.0f to 1.0f
    /// </summary>
    /// <param name="alpha">The alpha value</param>
    public static void Fade(this ref Color color, float alpha)
    {
        color = Raylib.Fade(new Color(color.R, color.G, color.B, color.A), alpha);
    }

    /// <summary>
    /// Get color multiplied with another color
    /// </summary>
    /// <param name="tint">The tint color (aka color that will be multiplied by)</param>
    public static void Tint(this ref Color color, Color tint)
    {
        color = Raylib.ColorTint(new Color(color.R, color.G, color.B, color.A), tint);
    }

    /// <summary>
    /// Get color with brightness correction, brightness factor goes from -1.0f to 1.0f
    /// </summary>
    /// <param name="factor">The brightness factor</param>
    public static void Brightness(this ref Color color, float factor)
    {
        color = Raylib.ColorBrightness(new Color(color.R, color.G, color.B, color.A), factor);
    }

    /// <summary>
    /// Get color with contrast correction, contrast values between -1.0f and 1.0f
    /// </summary>
    /// <param name="contrast">The contrast</param>
    public static void Contrast(this ref Color color, float contrast)
    {
        color = Raylib.ColorContrast(new Color(color.R, color.G, color.B, color.A), contrast);
    }

    /// <summary>
    /// Get color with alpha applied, alpha goes from 0.0f to 1.0f
    /// </summary>
    /// <param name="alpha">The alpha</param>
    public static void Alpha(this ref Color color, float alpha)
    {
        color = Raylib.ColorAlpha(new Color(color.R, color.G, color.B, color.A), alpha);
    }
}
