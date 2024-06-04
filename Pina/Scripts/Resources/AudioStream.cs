using Raylib_cs;
using System.Runtime.InteropServices;
using RaylibAudioStream = Raylib_cs.AudioStream;

namespace Pina.Scripts.Resources;

public class AudioStream : Resource
{
    RaylibAudioStream raylibAudioStream;

    public unsafe delegate void AudioCallback(void* data, uint size);

    /// <summary>
    /// Determine if the audio stream is ready
    /// </summary>
    public bool Ready
    {
        get
        {
            return Raylib.IsAudioStreamReady(raylibAudioStream);
        }
    }

    /// <summary>
    /// Determine if any audio stream buffers requires refill
    /// </summary>
    public bool Processed
    {
        get
        {
            return Raylib.IsAudioStreamProcessed(raylibAudioStream);
        }
    }

    /// <summary>
    /// Determine if any audio stream buffers is playing
    /// </summary>
    public bool Playing
    {
        get
        {
            return Raylib.IsAudioStreamPlaying(raylibAudioStream);
        }
    }

    /// <summary>
    /// Load audio stream (to stream raw audio pcm data)
    /// </summary>
    public static AudioStream Load(uint sampleRate, uint sampleSize, uint channels)
    {
        AudioStream audioStream = new AudioStream();

        audioStream.raylibAudioStream = Raylib.LoadAudioStream(sampleRate, sampleSize, channels);

        return audioStream;
    }

    /// <summary>
    /// Update audio stream buffers with data
    /// </summary>
    public unsafe void Update(void* data, int frameCount)
    {
        Raylib.UpdateAudioStream(raylibAudioStream, data, frameCount);
    }

    /// <summary>
    /// Play audio stream
    /// </summary>
    public void Play()
    {
        Raylib.PlayAudioStream(raylibAudioStream);
    }

    /// <summary>
    /// Pause audio stream
    /// </summary>
    public void Pause()
    {
        Raylib.PauseAudioStream(raylibAudioStream);
    }

    /// <summary>
    /// Resume audio stream
    /// </summary>
    public void Resume()
    {
        Raylib.ResumeAudioStream(raylibAudioStream);
    }

    /// <summary>
    /// Stop audio stream
    /// </summary>
    public void Stop()
    {
        Raylib.StopAudioStream(raylibAudioStream);
    }

    /// <summary>
    /// Set volume for audio stream (1.0 is max level)
    /// </summary>
    public void SetVolume(float volume)
    {
        Raylib.SetAudioStreamVolume(raylibAudioStream, volume);
    }

    /// <summary>
    /// Set pitch for audio stream (1.0 is base level)
    /// </summary>
    public void SetPitch(float pitch)
    {
        Raylib.SetAudioStreamPitch(raylibAudioStream, pitch);
    }

    /// <summary>
    /// Set pan for audio stream (0.5 is centered)
    /// </summary>
    public void SetPan(float pan)
    {
        Raylib.SetAudioStreamPan(raylibAudioStream, pan);
    }

    /// <summary>
    /// Audio thread callback to request new data
    /// </summary>
    public unsafe void SetCallback(AudioCallback callback)
    {
        IntPtr callbackPtr = Marshal.GetFunctionPointerForDelegate(callback);

        Raylib.SetAudioStreamCallback(raylibAudioStream, (delegate* unmanaged[Cdecl]<void*, uint, void>)callbackPtr);
    }

    /// <summary>
    /// Attach audio stream processor to stream, receives the samples as s
    /// </summary>
    public unsafe void AttachProcessor(AudioCallback callback)
    {
        IntPtr callbackPtr = Marshal.GetFunctionPointerForDelegate(callback);

        Raylib.AttachAudioStreamProcessor(raylibAudioStream, (delegate* unmanaged[Cdecl]<void*, uint, void>)callbackPtr);
    }

    /// <summary>
    /// Detach audio stream processor from stream
    /// </summary>
    public unsafe void DetachProcessor(AudioCallback callback)
    {
        IntPtr callbackPtr = Marshal.GetFunctionPointerForDelegate(callback);

        Raylib.DetachAudioStreamProcessor(raylibAudioStream, (delegate* unmanaged[Cdecl]<void*, uint, void>)callbackPtr);
    }

    /// <summary>
    /// Unload audio stream and free memory
    /// </summary>
    protected override void Unload()
    {
        if (!Ready)
        {
            throw new Exception("Error: Audio stream is not loaded yet");
        }

        Raylib.UnloadAudioStream(raylibAudioStream);

        base.Unload();
    }

    protected override void Dispose(bool disposing)
    {
        Unload();
    }
}
