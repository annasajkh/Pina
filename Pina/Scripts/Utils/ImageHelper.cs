using Raylib_cs;

namespace Pina.Scripts.Utils;


public static class ImageHelper
{
    /// <summary>
    /// Generate image: plain color
    /// </summary>
    /// <param name="width">Image width</param>
    /// <param name="height">Image height</param>
    /// <param name="color">Color of the image</param>
    /// <returns>The generated image</returns>
    public static Image GenImageColor(int width, int height, Color color)
    {
        return Raylib.GenImageColor(width, height, color);
    }

    /// <summary>
    /// Generate image: linear gradient
    /// </summary>
    /// <param name="width">Image width</param>
    /// <param name="height">Image height</param>
    /// <param name="direction">Direction in degrees [0..360]</param>
    /// <param name="start">Start color</param>
    /// <param name="end">End color</param>
    /// <returns>The generated image</returns>
    public static Image GenImageGradientLinear(int width, int height, int direction, Color start, Color end)
    {
        return Raylib.GenImageGradientLinear(width, height, direction, start, end);
    }

    /// <summary>
    /// Generate image: radial gradient
    /// </summary>
    /// <param name="width">Image width</param>
    /// <param name="height">Image height</param>
    /// <param name="density">Density of the gradient</param>
    /// <param name="inner">Inner color</param>
    /// <param name="outer">Outer color</param>
    /// <returns>The generated image</returns>
    public static Image GenImageGradientRadial(int width, int height, float density, Color inner, Color outer)
    {
        return Raylib.GenImageGradientRadial(width, height, density, inner, outer);
    }

    /// <summary>
    /// Generate image: square gradient
    /// </summary>
    /// <param name="width">Image width</param>
    /// <param name="height">Image height</param>
    /// <param name="density">Density of the gradient</param>
    /// <param name="inner">Inner color</param>
    /// <param name="outer">Outer color</param>
    /// <returns>The generated image</returns>
    public static Image GenImageGradientSquare(int width, int height, float density, Color inner, Color outer)
    {
        return Raylib.GenImageGradientSquare(width, height, density, inner, outer);
    }

    /// <summary>
    /// Generate image: checked
    /// </summary>
    /// <param name="width">Image width</param>
    /// <param name="height">Image height</param>
    /// <param name="checksX">Number of checks along the X-axis</param>
    /// <param name="checksY">Number of checks along the Y-axis</param>
    /// <param name="col1">Color 1</param>
    /// <param name="col2">Color 2</param>
    /// <returns>The generated image</returns>
    public static Image GenImageChecked(int width, int height, int checksX, int checksY, Color col1, Color col2)
    {
        return Raylib.GenImageChecked(width, height, checksX, checksY, col1, col2);
    }

    /// <summary>
    /// Generate image: white noise
    /// </summary>
    /// <param name="width">Image width</param>
    /// <param name="height">Image height</param>
    /// <param name="factor">Factor of the noise</param>
    /// <returns>The generated image</returns>
    public static Image GenImageWhiteNoise(int width, int height, float factor)
    {
        return Raylib.GenImageWhiteNoise(width, height, factor);
    }

    /// <summary>
    /// Generate image: perlin noise
    /// </summary>
    /// <param name="width">Image width</param>
    /// <param name="height">Image height</param>
    /// <param name="offsetX">Offset along the X-axis</param>
    /// <param name="offsetY">Offset along the Y-axis</param>
    /// <param name="scale">Scale of the noise</param>
    /// <returns>The generated image</returns>
    public static Image GenImagePerlinNoise(int width, int height, int offsetX, int offsetY, float scale)
    {
        return Raylib.GenImagePerlinNoise(width, height, offsetX, offsetY, scale);
    }

    /// <summary>
    /// Generate image: cellular algorithm
    /// </summary>
    /// <param name="width">Image width</param>
    /// <param name="height">Image height</param>
    /// <param name="tileSize">Size of the tiles</param>
    /// <returns>The generated image</returns>
    public static Image GenImageCellular(int width, int height, int tileSize)
    {
        return Raylib.GenImageCellular(width, height, tileSize);
    }

    /// <summary>
    /// Generate image: grayscale image from text data
    /// </summary>
    /// <param name="width">Image width</param>
    /// <param name="height">Image height</param>
    /// <param name="text">Text data</param>
    /// <returns>The generated image</returns>
    public static Image GenImageText(int width, int height, string text)
    {
        return Raylib.GenImageText(width, height, text);
    }

    /// <summary>
    /// Create an image from a portion of another image
    /// </summary>
    /// <param name="image">Source image</param>
    /// <param name="rec">Rectangle defining the portion of the source image to use</param>
    /// <returns>The new image containing the specified portion of the source image</returns>
    public static Image ImageFromImage(Image image, Rectangle rec)
    {
        return Raylib.ImageFromImage(image, rec);
    }

    /// <summary>
    /// Create an image from text using the default font
    /// </summary>
    /// <param name="text">Text to render</param>
    /// <param name="fontSize">Font size</param>
    /// <param name="color">Text color</param>
    /// <returns>The image generated from the text</returns>
    public static Image ImageText(string text, int fontSize, Color color)
    {
        return Raylib.ImageText(text, fontSize, color);
    }

    /// <summary>
    /// Create an image from text using a custom font
    /// </summary>
    /// <param name="font">Custom font to use</param>
    /// <param name="text">Text to render</param>
    /// <param name="fontSize">Font size</param>
    /// <param name="spacing">Spacing between characters</param>
    /// <param name="tint">Text color</param>
    /// <returns>The image generated from the text</returns>
    public static Image ImageTextEx(Font font, string text, float fontSize, float spacing, Color tint)
    {
        return Raylib.ImageTextEx(font, text, fontSize, spacing, tint);
    }


    /// <summary>
    /// Load color data from an image as a Color array (RGBA - 32bit)
    /// </summary>
    /// <param name="image">Source image</param>
    /// <returns>The color data loaded from the image as a Color array</returns>
    public unsafe static Color* LoadImageColors(Image image)
    {
        return Raylib.LoadImageColors(image);
    }

    /// <summary>
    /// Load color palette from an image as a Color array (RGBA - 32bit)
    /// </summary>
    /// <param name="image">Source image</param>
    /// <param name="maxPaletteSize">Maximum number of colors allowed in the palette</param>
    /// <param name="colorCount">Number of colors in the palette</param>
    /// <returns>The color palette loaded from the image as a Color array</returns>
    public unsafe static Color* LoadImagePalette(Image image, int maxPaletteSize, int* colorCount)
    {
        return Raylib.LoadImagePalette(image, maxPaletteSize, colorCount);
    }

    /// <summary>
    /// Unload color data loaded with LoadImageColors()
    /// </summary>
    /// <param name="colors">Color data to unload</param>
    public unsafe static void UnloadImageColors(Color* colors)
    {
        Raylib.UnloadImageColors(colors);
    }

    /// <summary>
    /// Unload colors palette loaded with LoadImagePalette()
    /// </summary>
    /// <param name="colors">Colors palette to unload</param>
    public unsafe static void UnloadImagePalette(Color* colors)
    {
        Raylib.UnloadImagePalette(colors);
    }

    /// <summary>
    /// Get the alpha border rectangle of an image
    /// </summary>
    /// <param name="image">Source image</param>
    /// <param name="threshold">Alpha threshold</param>
    /// <returns>The alpha border rectangle</returns>
    public static Rectangle GetImageAlphaBorder(Image image, float threshold)
    {
        return Raylib.GetImageAlphaBorder(image, threshold);
    }
}
