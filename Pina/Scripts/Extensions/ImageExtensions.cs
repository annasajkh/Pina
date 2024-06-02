using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pina.Scripts.Extensions;

public static class ImageExtensions
{
    /// <summary>
    /// Create a duplicate image
    /// </summary>
    /// <param name="image">Source image</param>
    /// <returns>The duplicated image</returns>
    public static Image Copy(this ref Image image)
    {
        return Raylib.ImageCopy(image);
    }

    /// <summary>
    /// Get the pixel color of an image at a specified position
    /// </summary>
    /// <param name="image">Source image</param>
    /// <param name="x">X coordinate of the pixel</param>
    /// <param name="y">Y coordinate of the pixel</param>
    /// <returns>The color of the pixel at the specified position</returns>
    public static Color GetColor(this ref Image image, int x, int y)
    {
        return Raylib.GetImageColor(image, x, y);
    }
}