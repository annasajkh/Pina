using Raylib_cs;
using System.Numerics;

namespace Pina.Scripts.Resources;

public class ShaderResource : Resource
{
    public Shader Shader { get; private set; }

    /// <summary>
    /// if a shader is ready
    /// </summary>
    public bool Ready
    {
        get
        {
            return Raylib.IsShaderReady(Shader);
        }
    }

    /// <summary>
    /// Load shader from files and bind default locations
    /// </summary>
    /// <param name="vertexShaderPath">The vertex shader path</param>
    /// <param name="fragmentShaderPath">The fragment shader path</param>
    public void Load(string vertexShaderPath, string fragmentShaderPath)
    {
        Shader = Raylib.LoadShader(vertexShaderPath, fragmentShaderPath);
    }

    /// <summary>
    /// Load shader from code strings and bind default locations
    /// </summary>
    /// <param name="vertexShaderPath">The vertex shader code</param>
    /// <param name="fragmentShaderPath">The fragment shader code</param>
    public void LoadFromMemory(string vertexShaderCode, string fragmentShaderCode)
    {
        Shader = Raylib.LoadShaderFromMemory(vertexShaderCode, fragmentShaderCode);
    }

    /// <summary>
    /// Get shader uniform location
    /// </summary>
    /// <param name="uniformName">The uniform name</param>
    /// <returns>The index location</returns>
    public int GetUniformLocation(string uniformName)
    {
        return Raylib.GetShaderLocation(Shader, uniformName);
    }

    /// <summary>
    /// Get shader attribute location
    /// </summary>
    /// <param name="attributeName">The attribute name</param>
    /// <returns>The index location</returns>
    public int GetAttributeLocation(string attributeName)
    {
        return Raylib.GetShaderLocationAttrib(Shader, attributeName);
    }

    // -------------Need to investigate how these work lol----------------

    /// <summary>
    /// Set shader uniform value
    /// </summary>
    public void SetValue(int locIndex, Span<float> values, ShaderUniformDataType uniformType)
    {
        Raylib.SetShaderValue(Shader, locIndex, values, uniformType);
    }

    /// <summary>
    /// Set shader uniform value
    /// </summary>
    public void SetValue(int locIndex, Span<int> values, ShaderUniformDataType uniformType)
    {
        Raylib.SetShaderValue(Shader, locIndex, values, uniformType);
    }

    /// <summary>
    /// Set shader uniform value
    /// </summary>
    public void SetValue(int locIndex, Span<double> values, ShaderUniformDataType uniformType)
    {
        Raylib.SetShaderValue(Shader, locIndex, values, uniformType);
    }

    /// <summary>
    /// Set shader uniform value
    /// </summary>
    public void SetValue(int locIndex, Span<bool> values, ShaderUniformDataType uniformType)
    {
        Raylib.SetShaderValue(Shader, locIndex, values, uniformType);
    }


    /// <summary>
    /// Set shader uniform value
    /// </summary>
    public void SetValue(int locIndex, Span<byte> values, ShaderUniformDataType uniformType)
    {
        Raylib.SetShaderValue(Shader, locIndex, values, uniformType);
    }

    /// <summary>
    ///  Set shader uniform value vector
    /// </summary>
    public void SetValueV(int locIndex, Span<float> values, ShaderUniformDataType uniformType, int count)
    {
        Raylib.SetShaderValueV(Shader, locIndex, values, uniformType, count);
    }

    /// <summary>
    ///  Set shader uniform value vector
    /// </summary>
    public void SetValueV(int locIndex, Span<int> values, ShaderUniformDataType uniformType, int count)
    {
        Raylib.SetShaderValueV(Shader, locIndex, values, uniformType, count);
    }

    /// <summary>
    ///  Set shader uniform value vector
    /// </summary>
    public void SetValueV(int locIndex, Span<double> values, ShaderUniformDataType uniformType, int count)
    {
        Raylib.SetShaderValueV(Shader, locIndex, values, uniformType, count);
    }

    /// <summary>
    ///  Set shader uniform value vector
    /// </summary>
    public void SetValueV(int locIndex, Span<bool> values, ShaderUniformDataType uniformType, int count)
    {
        Raylib.SetShaderValueV(Shader, locIndex, values, uniformType, count);
    }

    /// <summary>
    ///  Set shader uniform value vector
    /// </summary>
    public void SetValueV(int locIndex, Span<byte> values, ShaderUniformDataType uniformType, int count)
    {
        Raylib.SetShaderValueV(Shader, locIndex, values, uniformType, count);
    }

    //--------------------------------------------------------------------

    /// <summary>
    /// Set shader uniform value (matrix 4x4)
    /// </summary>
    public void SetValueMatrix(int locIndex, Matrix4x4 matrix)
    {
        Raylib.SetShaderValueMatrix(Shader, locIndex, matrix);
    }

    /// <summary>
    /// Set shader uniform value for texture (sampler2d)
    /// </summary>
    public void SetValueTexture(int locIndex, Texture2D texture)
    {
        Raylib.SetShaderValueTexture(Shader, locIndex, texture);
    }

    public override void Unload()
    {
        base.Unload();

        Raylib.UnloadShader(Shader);
    }
}
