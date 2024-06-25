using Raylib_cs;
using RaylibModelAnimation = Raylib_cs.ModelAnimation;

namespace Pina.Core;

public static class ModelAnimation
{
    /// <summary>
    ///  Load model animations from file
    /// </summary>
    public static unsafe RaylibModelAnimation* Loads(sbyte* fileName, int* animCount)
    {
        return Raylib.LoadModelAnimations(fileName, animCount);
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
    public static unsafe void UnloadModelAnimations(RaylibModelAnimation* animations, int animCount)
    {
        Raylib.UnloadModelAnimations(animations, animCount);
    }
}
