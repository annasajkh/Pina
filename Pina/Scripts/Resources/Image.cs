using Raylib_cs;
using System.Numerics;
using RaylibImage = Raylib_cs.Image;

namespace Pina.Scripts.Resources;

public sealed class Image : Resource
{
    public RaylibImage raylibImage;

    /// <summary>
    /// Determine if the image is ready
    /// </summary>
    public bool Ready
    {
        get
        {
            return Raylib.IsImageReady(raylibImage);
        }
    }

    /// <summary>
    /// Get the source rectangle
    /// </summary>
    public Rectangle SourceRectangle
    {
        get
        {
            return new Rectangle(0, 0, raylibImage.Width, raylibImage.Height);
        }
    }

    /// <summary>
    /// Load image from file into CPU memory (RAM)
    /// </summary>
    /// <param name="fileName">The file name of the image</param>
    public static Image Load(string fileName)
    {
        Image image = new Image();

        image.raylibImage = Raylib.LoadImage(fileName);

        return image;
    }

    /// <summary>
    /// Load image from RAW file data
    /// </summary>
    /// <param name="fileName">The file name of the image</param>
    /// <param name="width">The width of the image</param>
    /// <param name="height">The height of the image</param>
    /// <param name="format">The format of the image</param>
    /// <param name="headerSize">The header size of the image</param>
    public static Image LoadRaw(string fileName, int width, int height, PixelFormat format, int headerSize)
    {
        Image image = new Image();

        image.raylibImage = Raylib.LoadImageRaw(fileName, width, height, format, headerSize);

        return image;
    }

    /// <summary>
    /// Load image from SVG file data or string with specified size
    /// </summary>
    /// <param name="fileName">The file name of the image</param>
    /// <param name="width">The width of the image</param>
    /// <param name="height">The height of the image</param>
    public static Image LoadSvg(string fileName, int width, int height)
    {
        Image image = new Image();

        image.raylibImage = Raylib.LoadImageSvg(fileName, width, height);

        return image;
    }

    /// <summary>
    /// Load image sequence from file (frames appended to image.data)
    /// </summary>
    /// <param name="fileName">The file name of the image</param>
    /// <param name="frames">The out frames</param>
    public static Image LoadImageAnim(string fileName, out int frames)
    {
        Image image = new Image();

        image.raylibImage = Raylib.LoadImageAnim(fileName, out frames);

        return image;
    }

    /// <summary>
    /// Load image from memory buffer, fileType refers to extension: i.e. '.png'
    /// </summary>
    /// <param name="fileType">The image file type</param>
    /// <param name="fileData">The image file data</param>
    public static Image LoadFromMemory(string fileType, byte[] fileData)
    {
        Image image = new Image();

        image.raylibImage = Raylib.LoadImageFromMemory(fileType, fileData);

        return image;
    }

    /// <summary>
    /// Load image from GPU texture data
    /// </summary>
    /// <param name="texture">The texture</param>
    public static Image LoadFromTexture(Texture2D texture)
    {
        Image image = new Image();

        image.raylibImage = Raylib.LoadImageFromTexture(texture.raylibTexture2D);

        return image;
    }

    /// <summary>
    /// Load image from screen buffer (screenshot)
    /// </summary>
    public static Image LoadFromScreen()
    {
        Image image = new Image();

        image.raylibImage = Raylib.LoadImageFromScreen();

        return image;
    }

    /// <summary>
    /// Generate image font atlas using chars info
    /// </summary>
    public static unsafe Image GenFontAtlas(GlyphInfo* chars, Rectangle** recs, int glyphCount, int fontSize, int padding, int packMethod)
    {
        Image image = new Image();

        image.raylibImage = Raylib.GenImageFontAtlas(chars, recs, glyphCount, fontSize, padding, packMethod);

        return image;
    }

    /// <summary>
    /// Export image data to file, returns true on success
    /// </summary>
    /// <param name="fileName">The file name of the image that will be saved</param>
    public void Export(string fileName)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        if (!Raylib.ExportImage(raylibImage, fileName))
        {
            throw new Exception("Error: Cannot export the image!");
        }
    }

    /// <summary>
    /// Export image to memory buffer
    /// </summary>
    /// <param name="memoryBuffer">The memory buffer it will export to</param>
    /// <param name="fileType">The file type</param>
    /// <param name="fileSize">The file size</param>
    public unsafe void ExportToMemory(char* memoryBuffer, sbyte* fileType, int* fileSize)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        memoryBuffer = Raylib.ExportImageToMemory(raylibImage, fileType, fileSize);
    }

    /// <summary>
    /// Export image as code file defining an array of bytes, returns true on success
    /// </summary>
    /// <param name="fileName">The file name of the image that will be exported to</param>
    public void ExportAsCode(string fileName)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        if (!Raylib.ExportImageAsCode(raylibImage, fileName))
        {
            throw new Exception("Error: Cannot export the image!");
        }
    }

    /// <summary>
    /// Convert image data to desired format
    /// </summary>
    /// <param name="newFormat">The new format to convert to</param>
    public void Format(PixelFormat newFormat)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageFormat(ref raylibImage, newFormat);
    }

    /// <summary>
    /// Convert image to POT (power-of-two)
    /// </summary>
    /// <param name="fill">The color to fill empty areas with</param>
    public void ToPOT(Color fill)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageToPOT(ref raylibImage, fill);
    }

    /// <summary>
    /// Crop an image to a defined rectangle
    /// </summary>
    /// <param name="crop">The rectangle defining the area to crop</param>
    public void Crop(Rectangle crop)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageCrop(ref raylibImage, crop);
    }

    /// <summary>
    /// Crop image depending on alpha value
    /// </summary>
    /// <param name="threshold">The alpha threshold</param>
    public void AlphaCrop(float threshold)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageAlphaCrop(ref raylibImage, threshold);
    }

    /// <summary>
    /// Clear alpha channel to desired color
    /// </summary>
    /// <param name="color">The color to clear the alpha channel with</param>
    /// <param name="threshold">The alpha threshold</param>
    public void AlphaClear(Color color, float threshold)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageAlphaClear(ref raylibImage, color, threshold);
    }

    /// <summary>
    /// Apply alpha mask to image
    /// </summary>
    /// <param name="alphaMask">The alpha mask image</param>
    public void AlphaMask(RaylibImage alphaMask)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }
        

        Raylib.ImageAlphaMask(ref raylibImage, alphaMask);
    }

    /// <summary>
    /// Premultiply alpha channel
    /// </summary>
    public void AlphaPremultiply()
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageAlphaPremultiply(ref raylibImage);
    }

    /// <summary>
    /// Apply Gaussian blur using a box blur approximation
    /// </summary>
    /// <param name="blurSize">The size of the blur</param>
    public void BlurGaussian(int blurSize)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageBlurGaussian(ref raylibImage, blurSize);
    }

    /// <summary>
    /// Resize image (Bicubic scaling algorithm)
    /// </summary>
    /// <param name="newWidth">The new width</param>
    /// <param name="newHeight">The new height</param>
    public void Resize(int newWidth, int newHeight)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageResize(ref raylibImage, newWidth, newHeight);
    }

    /// <summary>
    /// Resize image (Nearest-Neighbor scaling algorithm)
    /// </summary>
    /// <param name="newWidth">The new width</param>
    /// <param name="newHeight">The new height</param>
    public void ResizeNN(int newWidth, int newHeight)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageResizeNN(ref raylibImage, newWidth, newHeight);
    }

    /// <summary>
    /// Resize canvas and fill with color
    /// </summary>
    /// <param name="newWidth">The new width of the canvas</param>
    /// <param name="newHeight">The new height of the canvas</param>
    /// <param name="offsetX">The offset along the x-axis</param>
    /// <param name="offsetY">The offset along the y-axis</param>
    /// <param name="fill">The color to fill empty areas with</param>
    public void ResizeCanvas(int newWidth, int newHeight, int offsetX, int offsetY, Color fill)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageResizeCanvas(ref raylibImage, newWidth, newHeight, offsetX, offsetY, fill);
    }

    /// <summary>
    /// Compute all mipmap levels for a provided image
    /// </summary>
    public void Mipmaps()
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageMipmaps(ref raylibImage);
    }

    /// <summary>
    /// Dither image data to 16bpp or lower (Floyd-Steinberg dithering)
    /// </summary>
    /// <param name="rBpp">Red bits per pixel</param>
    /// <param name="gBpp">Green bits per pixel</param>
    /// <param name="bBpp">Blue bits per pixel</param>
    /// <param name="aBpp">Alpha bits per pixel</param>
    public void Dither(int rBpp, int gBpp, int bBpp, int aBpp)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageDither(ref raylibImage, rBpp, gBpp, bBpp, aBpp);
    }

    /// <summary>
    /// Flip image vertically
    /// </summary>
    public void FlipVertical()
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageFlipVertical(ref raylibImage);
    }

    /// <summary>
    /// Flip image horizontally
    /// </summary>
    public void FlipHorizontal()
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageFlipHorizontal(ref raylibImage);
    }


    // --------------------- This Method Leaks Memory Lmao ----------------------------
    ///// <summary>
    ///// Rotate image by input angle in degrees (-359 to 359)
    ///// </summary>
    ///// <param name="degrees">The angle in degrees</param>
    //public void Rotate(int degrees)
    //{
    //    if (!Ready)
    //    {
    //        throw new Exception("Error: Image is not loaded yet");
    //    }

    //    Raylib.ImageRotate(ref image, degrees);
    //}
    // --------------------------------------------------------------------------------

    /// <summary>
    /// Rotate image clockwise 90deg
    /// </summary>
    public void RotateCW()
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageRotateCW(ref raylibImage);
    }

    /// <summary>
    /// Rotate image counter-clockwise 90deg
    ///</summary>
    public void RotateCCW()
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageRotateCCW(ref raylibImage);
    }

    /// <summary>
    /// Modify image color: tint
    /// </summary>
    /// <param name="color">The color to tint the image with</param>
    public void ColorTint(Color color)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageColorTint(ref raylibImage, color);
    }

    /// <summary>
    /// Modify image color: invert
    /// </summary>
    public void ColorInvert()
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageColorInvert(ref raylibImage);
    }

    /// <summary>
    /// Modify image color: grayscale
    /// </summary>
    public void ColorGrayscale()
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageColorGrayscale(ref raylibImage);
    }

    /// <summary>
    /// Modify image color: contrast (-100 to 100)
    /// </summary>
    /// <param name="contrast">The contrast value</param>
    public void ColorContrast(float contrast)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageColorContrast(ref raylibImage, contrast);
    }

    /// <summary>
    /// Modify image color: brightness (-255 to 255)
    /// </summary>
    /// <param name="brightness">The brightness value</param>
    public void ColorBrightness(int brightness)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageColorBrightness(ref raylibImage, brightness);
    }

    /// <summary>
    /// Modify image color: replace color
    /// </summary>
    /// <param name="color">The color to replace</param>
    /// <param name="replace">The color to replace with</param>
    public void ColorReplace(Color color, Color replace)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageColorReplace(ref raylibImage, color, replace);
    }

    /// <summary>
    /// Clear image background with given color
    /// </summary>
    /// <param name="color">The color to clear the background with</param>
    public void ClearBackground(Color color)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageClearBackground(ref raylibImage, color);
    }

    /// <summary>
    /// Draw pixel within an image
    /// </summary>
    /// <param name="posX">The x-coordinate of the pixel</param>
    /// <param name="posY">The y-coordinate of the pixel</param>
    /// <param name="color">The color of the pixel</param>
    public void DrawPixel(int posX, int posY, Color color)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageDrawPixel(ref raylibImage, posX, posY, color);
    }

    /// <summary>
    /// Draw pixel within an image (Vector version)
    /// </summary>
    /// <param name="position">The position of the pixel</param>
    /// <param name="color">The color of the pixel</param>
    public void DrawPixelV(Vector2 position, Color color)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageDrawPixelV(ref raylibImage, position, color);
    }

    /// <summary>
    /// Draw line within an image
    /// </summary>
    /// <param name="startPosX">The x-coordinate of the start point</param>
    /// <param name="startPosY">The y-coordinate of the start point</param>
    /// <param name="endPosX">The x-coordinate of the end point</param>
    /// <param name="endPosY">The y-coordinate of the end point</param>
    /// <param name="color">The color of the line</param>
    public void DrawLine(int startPosX, int startPosY, int endPosX, int endPosY, Color color)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageDrawLine(ref raylibImage, startPosX, startPosY, endPosX, endPosY, color);
    }

    /// <summary>
    /// Draw line within an image (Vector version)
    /// </summary>
    /// <param name="start">The start point of the line</param>
    /// <param name="end">The end point of the line</param>
    /// <param name="color">The color of the line</param>
    public void DrawLineV(Vector2 start, Vector2 end, Color color)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageDrawLineV(ref raylibImage, start, end, color);
    }

    /// <summary>
    /// Draw a filled circle within an image
    /// </summary>
    /// <param name="centerX">The x-coordinate of the center of the circle</param>
    /// <param name="centerY">The y-coordinate of the center of the circle</param>
    /// <param name="radius">The radius of the circle</param>
    /// <param name="color">The color of the circle</param>
    public void DrawCircle(int centerX, int centerY, int radius, Color color)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageDrawCircle(ref raylibImage, centerX, centerY, radius, color);
    }

    /// <summary>
    /// Draw a filled circle within an image (Vector version)
    /// </summary>
    /// <param name="center">The center of the circle</param>
    /// <param name="radius">The radius of the circle</param>
    /// <param name="color">The color of the circle</param>
    public void DrawCircleV(Vector2 center, int radius, Color color)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageDrawCircleV(ref raylibImage, center, radius, color);
    }

    //Raylib cs doesn't have overload for these as non pointer bruh need to implement myself i guess
    ///// <summary>
    ///// Draw circle outline within an image
    ///// </summary>
    ///// <param name="centerX">The x-coordinate of the center of the circle</param>
    ///// <param name="centerY">The y-coordinate of the center of the circle</param>
    ///// <param name="radius">The radius of the circle</param>
    ///// <param name="color">The color of the circle</param>
    //public void DrawCircleLines(int centerX, int centerY, int radius, Color color)
    //{
    //    Raylib.ImageDrawCircleLines(ref image, centerX, centerY, radius, color);
    //}

    ///// <summary>
    ///// Draw circle outline within an image (Vector version)
    ///// </summary>
    ///// <param name="center">The center of the circle</param>
    ///// <param name="radius">The radius of the circle</param>
    ///// <param name="color">The color of the circle</param>
    //public void DrawCircleLinesV(Vector2 center, int radius, Color color)
    //{
    //    Raylib.ImageDrawCircleLinesV(ref image, center, radius, color);
    //}
    //-----------------------------------------------------------------------------------------------

    /// <summary>
    /// Draw rectangle within an image
    /// </summary>
    /// <param name="posX">The x-coordinate of the top-left corner of the rectangle</param>
    /// <param name="posY">The y-coordinate of the top-left corner of the rectangle</param>
    /// <param name="width">The width of the rectangle</param>
    /// <param name="height">The height of the rectangle</param>
    /// <param name="color">The color of the rectangle</param>
    public void DrawRectangle(int posX, int posY, int width, int height, Color color)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageDrawRectangle(ref raylibImage, posX, posY, width, height, color);
    }

    /// <summary>
    /// Draw rectangle within an image (Vector version)
    /// </summary>
    /// <param name="position">The position of the top-left corner of the rectangle</param>
    /// <param name="size">The size of the rectangle</param>
    /// <param name="color">The color of the rectangle</param>
    public void DrawRectangleV(Vector2 position, Vector2 size, Color color)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageDrawRectangleV(ref raylibImage, position, size, color);
    }

    /// <summary>
    /// Draw rectangle within an image
    /// </summary>
    /// <param name="rec">The rectangle to draw</param>
    /// <param name="color">The color of the rectangle</param>
    public void DrawRectangleRec(Rectangle rec, Color color)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageDrawRectangleRec(ref raylibImage, rec, color);
    }

    /// <summary>
    /// Draw rectangle lines within an image
    /// </summary>
    /// <param name="rec">The rectangle to draw</param>
    /// <param name="thick">The thickness of the lines</param>
    /// <param name="color">The color of the lines</param>
    public void DrawRectangleLines(Rectangle rec, int thick, Color color)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageDrawRectangleLines(ref raylibImage, rec, thick, color);
    }

    /// <summary>
    /// Draw a source image within a destination image (tint applied to source)
    /// </summary>
    /// <param name="src">The source image</param>
    /// <param name="srcRec">The source rectangle</param>
    /// <param name="dstRec">The destination rectangle</param>
    /// <param name="tint">The tint color</param>
    public void Draw(RaylibImage src, Rectangle srcRec, Rectangle dstRec, Color tint)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageDraw(ref raylibImage, src, srcRec, dstRec, tint);
    }

    /// <summary>
    /// Draw text (using default font) within an image (destination)
    /// </summary>
    /// <param name="text">The text to draw</param>
    /// <param name="posX">The x-coordinate of the text</param>
    /// <param name="posY">The y-coordinate of the text</param>
    /// <param name="fontSize">The font size</param>
    /// <param name="color">The color of the text</param>
    public void DrawText(string text, int posX, int posY, int fontSize, Color color)
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.ImageDrawText(ref raylibImage, text, posX, posY, fontSize, color);
    }

    //Raylib cs doesn't have overload for these as non pointer bruh need to implement myself i guess
    ///// <summary>
    ///// Draw text (custom sprite font) within an image (destination)
    ///// </summary>
    ///// <param name="font">The custom font</param>
    ///// <param name="text">The text to draw</param>
    ///// <param name="position">The position of the text</param>
    ///// <param name="fontSize">The font size</param>
    ///// <param name="spacing">The spacing between characters</param>
    ///// <param name="tint">The tint color</param>
    //public void DrawTextEx(Font font, string text, Vector2 position, float fontSize, float spacing, Color tint)
    //{
    //    Raylib.ImageDrawTextEx(ref image, font, text, position, fontSize, spacing, tint);
    //}
    //-----------------------------------------------------------------------------------------------

    /// <summary>
    /// Unload image from CPU memory (RAM)
    /// </summary>
    protected override void Unload()
    {
        if (!Ready)
        {
            throw new Exception("Error: Image is not loaded yet");
        }

        Raylib.UnloadImage(raylibImage);

        base.Unload();
    }

    protected override void Dispose(bool disposing)
    {
        Unload();
    }
}
