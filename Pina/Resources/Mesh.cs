using Raylib_cs;
using System.Numerics;
using RaylibMesh = Raylib_cs.Mesh;

namespace Pina.Resources;

public sealed class Mesh : Resource
{
    public RaylibMesh raylibMesh;

    public BoundingBox BoundingBox
    {
        get
        {
            return Raylib.GetMeshBoundingBox(raylibMesh);
        }
    }

    /// <summary>
    /// Generate polygonal mesh
    /// </summary>
    public static Mesh GenPoly(int sides, float radius)
    {
        Mesh mesh = new Mesh();

        mesh.raylibMesh = Raylib.GenMeshPoly(sides, radius);

        return mesh;
    }

    /// <summary>
    /// Generate plane mesh (with subdivisions)
    /// </summary>
    public static Mesh GenPlane(float width, float length, int resX, int resZ)
    {
        Mesh mesh = new Mesh();

        mesh.raylibMesh = Raylib.GenMeshPlane(width, length, resX, resZ);

        return mesh;
    }

    /// <summary>
    /// Generate sphere mesh (standard sphere)
    /// </summary>
    public static Mesh GenSphere(float radius, int rings, int slices)
    {
        Mesh mesh = new Mesh();

        mesh.raylibMesh = Raylib.GenMeshSphere(radius, rings, slices);

        return mesh;
    }

    /// <summary>
    /// Generate half-sphere mesh (no bottom cap)
    /// </summary>
    public static Mesh GenHemiSphere(float radius, int rings, int slices)
    {
        Mesh mesh = new Mesh();

        mesh.raylibMesh = Raylib.GenMeshHemiSphere(radius, rings, slices);

        return mesh;
    }

    /// <summary>
    /// Generate cylinder mesh
    /// </summary>
    public static Mesh GenCylinder(float radius, float height, int slices)
    {
        Mesh mesh = new Mesh();

        mesh.raylibMesh = Raylib.GenMeshCylinder(radius, height, slices);

        return mesh;
    }

    /// <summary>
    /// Generate cone/pyramid mesh
    /// </summary>
    public static Mesh GenCone(float radius, float height, int slices)
    {
        Mesh mesh = new Mesh();

        mesh.raylibMesh = Raylib.GenMeshCone(radius, height, slices);

        return mesh;
    }

    /// <summary>
    /// Generate torus mesh
    /// </summary>
    public static Mesh GenTorus(float radius, float size, int radSeg, int sides)
    {
        Mesh mesh = new Mesh();

        mesh.raylibMesh = Raylib.GenMeshTorus(radius, size, radSeg, sides);

        return mesh;
    }

    /// <summary>
    /// Generate trefoil knot mesh
    /// </summary>
    public static Mesh GenKnot(float radius, float size, int radSeg, int sides)
    {
        Mesh mesh = new Mesh();

        mesh.raylibMesh = Raylib.GenMeshKnot(radius, size, radSeg, sides);

        return mesh;
    }

    /// <summary>
    /// Generate heightmap mesh from image data
    /// </summary>
    public static Mesh GenHeightmap(Image heightmap, Vector3 size)
    {
        Mesh mesh = new Mesh();

        mesh.raylibMesh = Raylib.GenMeshHeightmap(heightmap.raylibImage, size);

        return mesh;
    }

    /// <summary>
    /// Generate cubes-based map mesh from image data
    /// </summary>
    public static Mesh GenCubicmap(Image cubicmap, Vector3 cubeSize)
    {
        Mesh mesh = new Mesh();

        mesh.raylibMesh = Raylib.GenMeshCubicmap(cubicmap.raylibImage, cubeSize);

        return mesh;
    }

    /// <summary>
    /// Upload mesh vertex data in GPU and provide VAO/VBO ids
    /// </summary>
    public void Upload(bool dynamic)
    {
        Raylib.UploadMesh(ref raylibMesh, dynamic);
    }

    /// <summary>
    /// Update mesh vertex data in GPU for a specific buffer index
    /// </summary>
    public unsafe void UpdateBuffer(int index, void* data, int dataSize, int offset)
    {
        Raylib.UpdateMeshBuffer(raylibMesh, index, data, dataSize, offset);
    }

    /// <summary>
    /// Export mesh data to file, returns true on success
    /// </summary>
    public bool Export(string fileName)
    {
        return Raylib.ExportMesh(raylibMesh, fileName);
    }

    /// <summary>
    /// Compute mesh tangents
    /// </summary>
    public void GenTangents()
    {
        Raylib.GenMeshTangents(ref raylibMesh);
    }

    /// <summary>
    /// Unload mesh data from CPU and GPU
    /// </summary>
    protected override void Unload()
    {
        Raylib.UnloadMesh(ref raylibMesh);

        base.Unload();
    }

    protected override void Dispose(bool disposing)
    {
        Unload();
    }
}
