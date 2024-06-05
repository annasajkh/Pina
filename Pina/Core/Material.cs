using Raylib_cs;
using System.Text;
using RaylibMaterial = Raylib_cs.Material;
using Texture2D = Pina.Resources.Texture2D;

namespace Pina.Core;

public static class Material
{
    public static bool Ready(RaylibMaterial raylibMaterial)
    {
        return Raylib.IsMaterialReady(raylibMaterial);
    }

    /// <summary>
    /// Load materials from model file
    /// </summary>
    public static unsafe RaylibMaterial* Loads(string fileName, int materialCount)
    {
        byte[] bytes = Encoding.ASCII.GetBytes(fileName);

        fixed (byte* fileNamePtr = bytes)
        {
            // Huh why it wants pointer for material count???
            return Raylib.LoadMaterials((sbyte*)fileNamePtr, &materialCount);
        }
    }

    /// <summary>
    /// Load default material (Supports: DIFFUSE, SPECULAR, NORMAL maps)
    /// </summary>
    public static RaylibMaterial LoadDefault()
    {
        return Raylib.LoadMaterialDefault();
    }

    /// <summary>
    /// Set texture for a material map type (MATERIAL_MAP_DIFFUSE, MATERIAL_MAP_SPECULAR...)
    /// </summary>
    public static unsafe void SetTexture(RaylibMaterial* raylibMaterial, MaterialMapIndex mapType, Texture2D texture)
    {
        Raylib.SetMaterialTexture(raylibMaterial, mapType, texture.raylibTexture2D);
    }

    /// <summary>
    /// Unload material from GPU memory (VRAM)
    /// </summary>
    public static void Unload(RaylibMaterial raylibMaterial)
    {
        Raylib.UnloadMaterial(raylibMaterial);
    }
}
