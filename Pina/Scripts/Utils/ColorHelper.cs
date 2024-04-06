using Raylib_cs;
using System.Numerics;

namespace Pina.Scripts.Utils;

public static class ColorHelper
{
    /// <summary>
    /// Get hexadecimal value for a Color
    /// </summary>
    /// <param name="color">The color</param>
    /// <returns>The integer representation of the color</returns>
    public static int ToInt(Color color)
    {
        return Raylib.ColorToInt(color);
    }

    /// <summary>
    /// Get Color normalized as float [0..1]
    /// </summary>
    /// <param name="color">The color</param>
    /// <returns>The normalized vector4 representation of the color</returns>
    public static Vector4 Normalize(Color color)
    {
        return Raylib.ColorNormalize(color);
    }

    /// <summary>
    /// Get Color from normalized values [0..1]
    /// </summary>
    /// <param name="normalized">The normalized color</param>
    /// <returns>The color result</returns>
    public static Color FromNormalized(Vector4 normalized)
    {
        return Raylib.ColorFromNormalized(normalized);
    }


    /// <summary>
    /// Get HSV values for a Color, hue [0..360], saturation/value [0..1]
    /// </summary>
    /// <param name="color">The color</param>
    /// <returns>The HSV result as vector3</returns>
    public static Vector3 ToHSV(Color color)
    {
        return Raylib.ColorToHSV(color);
    }

    /// <summary>
    /// Get a Color from HSV values, hue [0..360], saturation/value [0..1]
    /// </summary>
    /// <param name="hue">The hue</param>
    /// <param name="saturation">The saturation</param>
    /// <param name="value">The value</param>
    /// <returns>The color result</returns>
    public static Color FromHSV(float hue, float saturation, float value)
    {
        return Raylib.ColorFromHSV(hue, saturation, value);
    }

    /// <summary>
    /// Get src alpha-blended into dst color with tint
    /// </summary>
    /// <param name="dst">Color destination</param>
    /// <param name="src">Color source</param>
    /// <param name="tint">Color tint</param>
    /// <returns></returns>
    public static Color AlphaBlend(Color dst, Color src, Color tint)
    {
        return Raylib.ColorAlphaBlend(dst, src, tint);
    }

    /// <summary>
    /// Get Color structure from hexadecimal value
    /// </summary>
    /// <param name="hexValue">The hex value</param>
    /// <returns>The color result</returns>
    public static Color FromHex(uint hexValue)
    {
        return Raylib.GetColor(hexValue);
    }

    /// <summary>
    /// Get Color from a source pixel pointer of certain format
    /// </summary>
    /// <param name="scrPtr">The color pointer</param>
    /// <param name="format">The pixel format</param>
    /// <returns>The color result</returns>
    public unsafe static Color GetPixel(void* scrPtr, PixelFormat format)
    {
        return Raylib.GetPixelColor(scrPtr, format);
    }

    /// <summary>
    /// Set color formatted into destination pixel pointer
    /// </summary>
    /// <param name="dstPtr">The destination pointer</param>
    /// <param name="color">The color</param>
    /// <param name="format">The pixel format</param>
    public unsafe static void SetPixelColor(void* dstPtr, Color color, PixelFormat format)
    {
        Raylib.SetPixelColor(dstPtr, color, format);
    }

    /// <summary>
    /// Get pixel data size in bytes for certain format
    /// </summary>
    /// <param name="width">The pixel data width</param>
    /// <param name="height">The pixel data height</param>
    /// <param name="format">The pixel format</param>
    /// <returns>The pixel data size</returns>
    public static int GetPixelDataSize(int width, int height, PixelFormat format)
    {
        return Raylib.GetPixelDataSize(width, height, format);
    }
}
