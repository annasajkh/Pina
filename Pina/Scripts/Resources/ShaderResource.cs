using Raylib_cs;
using System.Numerics;

namespace Pina.Scripts.Resources;

public sealed class ShaderResource : Resource
{
    public Shader? Shader { get; private set; }

    /// <summary>
    /// if a shader is ready
    /// </summary>
    public bool Ready
    {
        get
        {
            if (Shader == null)
            {
                throw new Exception("Error: Shader is not loaded yet");
            }

            return Raylib.IsShaderReady((Shader)Shader);
        }
    }

    /// <summary>
    /// Load shader from files and bind default locations
    /// </summary>
    /// <param name="vsFileName">The vertex shader file name</param>
    /// <param name="fsFileName">The fragment shader file name</param>
    public void Load(string vsFileName, string fsFileName)
    {
        if (Shader != null)
        {
            Raylib.UnloadShader((Shader)Shader);
        }

        Shader = Raylib.LoadShader(vsFileName, fsFileName);
    }

    /// <summary>
    /// Load shader from code strings and bind default locations
    /// </summary>
    /// <param name="vertexShaderCode">The vertex shader code</param>
    /// <param name="fragmentShaderCode">The fragment shader code</param>
    public void LoadFromMemory(string vertexShaderCode, string fragmentShaderCode)
    {
        if (Shader != null)
        {
            Raylib.UnloadShader((Shader)Shader);
        }

        Shader = Raylib.LoadShaderFromMemory(vertexShaderCode, fragmentShaderCode);
    }

    /// <summary>
    /// Get shader uniform location
    /// </summary>
    /// <param name="uniformName">The uniform name</param>
    /// <returns>The index location</returns>
    public int GetUniformLocation(string uniformName)
    {
        if (Shader == null)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        return Raylib.GetShaderLocation((Shader)Shader, uniformName);
    }

    /// <summary>
    /// Get shader attribute location
    /// </summary>
    /// <param name="attributeName">The attribute name</param>
    /// <returns>The index location</returns>
    public int GetAttributeLocation(string attributeName)
    {
        if (Shader == null)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        return Raylib.GetShaderLocationAttrib((Shader)Shader, attributeName);
    }

    // -------------Need to investigate how these work lol----------------

    /// <summary>
    /// Set shader uniform value
    /// </summary>
    public void SetValue(int locIndex, Span<float> values, ShaderUniformDataType uniformType)
    {
        if (Shader == null)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValue((Shader)Shader, locIndex, values, uniformType);
    }

    /// <summary>
    /// Set shader uniform value
    /// </summary>
    public void SetValue(int locIndex, Span<int> values, ShaderUniformDataType uniformType)
    {
        if (Shader == null)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValue((Shader)Shader, locIndex, values, uniformType);
    }

    /// <summary>
    /// Set shader uniform value
    /// </summary>
    public void SetValue(int locIndex, Span<double> values, ShaderUniformDataType uniformType)
    {
        if (Shader == null)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValue((Shader)Shader, locIndex, values, uniformType);
    }

    /// <summary>
    /// Set shader uniform value
    /// </summary>
    public void SetValue(int locIndex, Span<bool> values, ShaderUniformDataType uniformType)
    {
        if (Shader == null)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValue((Shader)Shader, locIndex, values, uniformType);
    }


    /// <summary>
    /// Set shader uniform value
    /// </summary>
    public void SetValue(int locIndex, Span<byte> values, ShaderUniformDataType uniformType)
    {
        if (Shader == null)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValue((Shader)Shader, locIndex, values, uniformType);
    }

    /// <summary>
    ///  Set shader uniform value vector
    /// </summary>
    public void SetValueV(int locIndex, Span<float> values, ShaderUniformDataType uniformType, int count)
    {
        if (Shader == null)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValueV((Shader)Shader, locIndex, values, uniformType, count);
    }

    /// <summary>
    ///  Set shader uniform value vector
    /// </summary>
    public void SetValueV(int locIndex, Span<int> values, ShaderUniformDataType uniformType, int count)
    {
        if (Shader == null)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValueV((Shader)Shader, locIndex, values, uniformType, count);
    }

    /// <summary>
    ///  Set shader uniform value vector
    /// </summary>
    public void SetValueV(int locIndex, Span<double> values, ShaderUniformDataType uniformType, int count)
    {
        if (Shader == null)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValueV((Shader)Shader, locIndex, values, uniformType, count);
    }

    /// <summary>
    ///  Set shader uniform value vector
    /// </summary>
    public void SetValueV(int locIndex, Span<bool> values, ShaderUniformDataType uniformType, int count)
    {
        if (Shader == null)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValueV((Shader)Shader, locIndex, values, uniformType, count);
    }

    /// <summary>
    ///  Set shader uniform value vector
    /// </summary>
    public void SetValueV(int locIndex, Span<byte> values, ShaderUniformDataType uniformType, int count)
    {
        if (Shader == null)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValueV((Shader)Shader, locIndex, values, uniformType, count);
    }

    //--------------------------------------------------------------------

    /// <summary>
    /// Set shader uniform value (matrix 4x4)
    /// </summary>
    public void SetValueMatrix(int locIndex, Matrix4x4 matrix)
    {
        if (Shader == null)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValueMatrix((Shader)Shader, locIndex, matrix);
    }

    /// <summary>
    /// Set shader uniform value for texture (sampler2d)
    /// </summary>
    public void SetValueTexture(int locIndex, Texture2D texture)
    {
        if (Shader == null)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.SetShaderValueTexture((Shader)Shader, locIndex, texture);
    }

    /// <summary>
    /// Unload shader from GPU memory (VRAM)
    /// </summary>
    public override void Unload()
    {
        base.Unload();

        if (Shader == null)
        {
            throw new Exception("Error: Shader is not loaded yet");
        }

        Raylib.UnloadShader((Shader)Shader);
    }
}