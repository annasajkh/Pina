using Raylib_cs;
using System.Numerics;
using RaylibShader = Raylib_cs.Shader;
using RaylibTexture = Raylib_cs.Texture2D;
namespace Pina.Scripts.Resources;

public sealed class Shader : Resource
{
    public RaylibShader raylibShader;

    /// <summary>
    /// Determine if the shader is ready
    /// </summary>
    public bool Ready
    {
        get
        {
            return Raylib.IsShaderReady(raylibShader);
        }
    }

    /// <summary>
    /// Load shader from files and bind default locations
    /// </summary>
    /// <param name="vsFileName">The vertex shader file name</param>
    /// <param name="fsFileName">The fragment shader file name</param>
    public static Shader Load(string vsFileName, string fsFileName)
    {
        Shader shader = new Shader();

        shader.raylibShader = Raylib.LoadShader(vsFileName, fsFileName);

        return shader;
    }

    /// <summary>
    /// Load shader from code strings and bind default locations
    /// </summary>
    /// <param name="vertexShaderCode">The vertex shader code</param>
    /// <param name="fragmentShaderCode">The fragment shader code</param>
    public static Shader LoadFromMemory(string vertexShaderCode, string fragmentShaderCode)
    {
        Shader shader = new Shader();

        shader.raylibShader = Raylib.LoadShaderFromMemory(vertexShaderCode, fragmentShaderCode);

        return shader;
    }

    /// <summary>
    /// Get shader uniform location
    /// </summary>
    /// <param name="uniformName">The uniform name</param>
    /// <returns>The index location</returns>
    public int GetUniformLocation(string uniformName)
    {
        if (!Ready)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        return Raylib.GetShaderLocation(raylibShader, uniformName);
    }

    /// <summary>
    /// Get shader attribute location
    /// </summary>
    /// <param name="attributeName">The attribute name</param>
    /// <returns>The index location</returns>
    public int GetAttributeLocation(string attributeName)
    {
        if (!Ready)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        return Raylib.GetShaderLocationAttrib(raylibShader, attributeName);
    }

    // -------------Need to investigate how these work lol----------------

    /// <summary>
    /// Set shader uniform value
    /// </summary>
    public void SetValue(int locIndex, Span<float> values, ShaderUniformDataType uniformType)
    {
        if (!Ready)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValue(raylibShader, locIndex, values, uniformType);
    }

    /// <summary>
    /// Set shader uniform value
    /// </summary>
    public void SetValue(int locIndex, Span<int> values, ShaderUniformDataType uniformType)
    {
        if (!Ready)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValue(raylibShader, locIndex, values, uniformType);
    }

    /// <summary>
    /// Set shader uniform value
    /// </summary>
    public void SetValue(int locIndex, Span<double> values, ShaderUniformDataType uniformType)
    {
        if (!Ready)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValue(raylibShader, locIndex, values, uniformType);
    }

    /// <summary>
    /// Set shader uniform value
    /// </summary>
    public void SetValue(int locIndex, Span<bool> values, ShaderUniformDataType uniformType)
    {
        if (!Ready)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValue(raylibShader, locIndex, values, uniformType);
    }


    /// <summary>
    /// Set shader uniform value
    /// </summary>
    public void SetValue(int locIndex, Span<byte> values, ShaderUniformDataType uniformType)
    {
        if (!Ready)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValue(raylibShader, locIndex, values, uniformType);
    }

    /// <summary>
    ///  Set shader uniform value vector
    /// </summary>
    public void SetValueV(int locIndex, Span<float> values, ShaderUniformDataType uniformType, int count)
    {
        if (!Ready)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValueV(raylibShader, locIndex, values, uniformType, count);
    }

    /// <summary>
    ///  Set shader uniform value vector
    /// </summary>
    public void SetValueV(int locIndex, Span<int> values, ShaderUniformDataType uniformType, int count)
    {
        if (!Ready)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValueV(raylibShader, locIndex, values, uniformType, count);
    }

    /// <summary>
    ///  Set shader uniform value vector
    /// </summary>
    public void SetValueV(int locIndex, Span<double> values, ShaderUniformDataType uniformType, int count)
    {
        if (!Ready)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValueV(raylibShader, locIndex, values, uniformType, count);
    }

    /// <summary>
    ///  Set shader uniform value vector
    /// </summary>
    public void SetValueV(int locIndex, Span<bool> values, ShaderUniformDataType uniformType, int count)
    {
        if (!Ready)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValueV(raylibShader, locIndex, values, uniformType, count);
    }

    /// <summary>
    ///  Set shader uniform value vector
    /// </summary>
    public void SetValueV(int locIndex, Span<byte> values, ShaderUniformDataType uniformType, int count)
    {
        if (!Ready)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValueV(raylibShader, locIndex, values, uniformType, count);
    }

    //--------------------------------------------------------------------

    /// <summary>
    /// Set shader uniform value (matrix 4x4)
    /// </summary>
    public void SetValueMatrix(int locIndex, Matrix4x4 matrix)
    {
        if (!Ready)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValueMatrix(raylibShader, locIndex, matrix);
    }

    /// <summary>
    /// Set shader uniform value for texture (sampler2d)
    /// </summary>
    public void SetValueTexture(int locIndex, RaylibTexture texture)
    {
        if (!Ready)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValueTexture(raylibShader, locIndex, texture);
    }

    /// <summary>
    /// Unload shader from GPU memory (VRAM)
    /// </summary>
    protected override void Unload()
    {
        if (!Ready)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.UnloadShader(raylibShader);

        base.Unload();
    }

    protected override void Dispose(bool disposing)
    {
        Unload();
    }
}