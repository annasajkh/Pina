using Raylib_cs;
using System.Runtime.InteropServices;

namespace Pina.Scripts.Core;

public static class Audio
{
    public unsafe delegate void AudioCallback(void* data, uint size);

    /// <summary>
    /// Check if audio device has been initialized successfully
    /// </summary>
    public static bool IsAudioDeviceReady()
    {
        return Raylib.IsAudioDeviceReady();
    }

    /// <summary>
    /// Set master volume (listener)
    /// </summary>
    /// <param name="volume">The master volume</param>
    public static void SetMasterVolume(float volume)
    {
        Raylib.SetMasterVolume(volume);
    }

    /// <summary>
    /// Get master volume (listener)
    /// </summary>
    /// <returns>The master volume</returns>
    public static float GetMasterVolume()
    {
        return Raylib.GetMasterVolume();
    }

    /// <summary>
    /// Default size for new audio streams
    /// </summary>
    public static void SetAudioStreamBufferSizeDefault(int size)
    {
        Raylib.SetAudioStreamBufferSizeDefault(size);
    }

    /// <summary>
    /// Attach audio stream processor to the entire audio pipeline, receives the samples as s
    /// </summary>
    public unsafe static void AttachMixedProcessor(AudioCallback callback)
    {
        IntPtr callbackPtr = Marshal.GetFunctionPointerForDelegate(callback);

        Raylib.AttachAudioMixedProcessor((delegate* unmanaged[Cdecl]<void*, uint, void>)callbackPtr);
    }

    /// <summary>
    /// Detach audio stream processor from the entire audio pipeline
    /// </summary>
    public unsafe static void DetachMixedProcessor(AudioCallback callback)
    {
        IntPtr callbackPtr = Marshal.GetFunctionPointerForDelegate(callback);
     
        Raylib.DetachAudioMixedProcessor((delegate* unmanaged[Cdecl]<void*, uint, void>)callbackPtr);
    }
}
