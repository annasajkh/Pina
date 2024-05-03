using Raylib_cs;
using System.Numerics;

namespace Pina.Scripts.Resources;

public sealed class ShaderResource : Resource
{
    private Shader shader;
    public Shader Shader
    {
        get => shader;
        private set => shader = value;
    }

    /// <summary>
    /// if a shader is ready
    /// </summary>
    public override bool Ready
    {
        get
        {
            return Raylib.IsShaderReady(shader);
        }
    }

    /// <summary>
    /// Load shader from files and bind default locations
    /// </summary>
    /// <param name="vsFileName">The vertex shader file name</param>
    /// <param name="fsFileName">The fragment shader file name</param>
    public ShaderResource Load(string vsFileName, string fsFileName)
    {
        if (Ready)
        {
            Raylib.UnloadShader(shader);
        }

        shader = Raylib.LoadShader(vsFileName, fsFileName);

        return this;
    }

    /// <summary>
    /// Load shader from code strings and bind default locations
    /// </summary>
    /// <param name="vertexShaderCode">The vertex shader code</param>
    /// <param name="fragmentShaderCode">The fragment shader code</param>
    public ShaderResource LoadFromMemory(string vertexShaderCode, string fragmentShaderCode)
    {
        if (Ready)
        {
            Raylib.UnloadShader(shader);
        }

        shader = Raylib.LoadShaderFromMemory(vertexShaderCode, fragmentShaderCode);

        return this;
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

        return Raylib.GetShaderLocation(shader, uniformName);
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

        return Raylib.GetShaderLocationAttrib(shader, attributeName);
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

        Raylib.SetShaderValue(shader, locIndex, values, uniformType);
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

        Raylib.SetShaderValue(shader, locIndex, values, uniformType);
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

        Raylib.SetShaderValue(shader, locIndex, values, uniformType);
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

        Raylib.SetShaderValue(shader, locIndex, values, uniformType);
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

        Raylib.SetShaderValue(shader, locIndex, values, uniformType);
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

        Raylib.SetShaderValueV(shader, locIndex, values, uniformType, count);
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

        Raylib.SetShaderValueV(shader, locIndex, values, uniformType, count);
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

        Raylib.SetShaderValueV(shader, locIndex, values, uniformType, count);
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

        Raylib.SetShaderValueV(shader, locIndex, values, uniformType, count);
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

        Raylib.SetShaderValueV(shader, locIndex, values, uniformType, count);
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

        Raylib.SetShaderValueMatrix(shader, locIndex, matrix);
    }

    /// <summary>
    /// Set shader uniform value for texture (sampler2d)
    /// </summary>
    public void SetValueTexture(int locIndex, Texture2D texture)
    {
        if (!Ready)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValueTexture(shader, locIndex, texture);
    }

    /// <summary>
    /// Unload shader from GPU memory (VRAM)
    /// </summary>
    public override void Unload()
    {
        if (!Ready)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.UnloadShader(shader);

        base.Unload();
    }
}