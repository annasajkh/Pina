using Raylib_cs;
using RaylibModelAnimation = Raylib_cs.ModelAnimation;

namespace Pina.Core;

public static unsafe class ModelAnimation
{
    /// <summary>
    ///  Load model animations from file
    /// </summary>
    public static RaylibModelAnimation* Loads(string fileName, uint animCount)
    {
        return Raylib.LoadModelAnimations(fileName, ref animCount);
    }

    /// <summary>
    /// Unload animation data
    /// </summary>
    public static void Unload(RaylibModelAnimation raylibModelAnimation)
    {
        Raylib.UnloadModelAnimation(raylibModelAnimation);
    }

    /// <summary>
    /// Unload animation array data
    /// </summary>
    public static void UnloadModelAnimations(RaylibModelAnimation* animations, uint animCount)
    {
        Raylib.UnloadModelAnimations(animations, animCount);
    }
}
