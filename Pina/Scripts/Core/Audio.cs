using Raylib_cs;

namespace Pina.Scripts.Core;

public static class Audio
{
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
}
