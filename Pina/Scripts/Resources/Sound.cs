using Raylib_cs;
using RaylibSound = Raylib_cs.Sound;

namespace Pina.Scripts.Resources;

public class Sound : Resource
{
    public RaylibSound raylibSound;

    /// <summary>
    /// Determine if the sound is ready
    /// </summary>
    public bool Ready
    {
        get
        {
            return Raylib.IsSoundReady(raylibSound);
        }
    }

    /// <summary>
    /// determine if the sound is currently playing
    /// </summary>
    public bool Playing
    {
        get
        {
            return Raylib.IsSoundPlaying(raylibSound);
        }
    }

    /// <summary>
    /// Load sound from file
    /// </summary>
    public static Sound Load(string fileName)
    {
        Sound sound = new Sound();

        sound.raylibSound = Raylib.LoadSound(fileName);

        return sound;
    }

    /// <summary>
    /// Load sound from wave data
    /// </summary>
    public static Sound LoadFromWave(Wave wave)
    {
        Sound sound = new Sound();

        sound.raylibSound = Raylib.LoadSoundFromWave(wave.raylibWave);

        return sound;
    }

    /// <summary>
    /// Create a new sound that shares the same sample data as the source sound, does not own the sound data
    /// </summary>
    public static Sound LoadAlias(Sound source)
    {
        Sound sound = new Sound();

        sound.raylibSound = Raylib.LoadSoundAlias(source.raylibSound);

        return sound;
    }

    /// <summary>
    /// Update sound buffer with new data
    /// </summary>
    public unsafe void Update(void* data, int sampleCount)
    {
        Raylib.UpdateSound(raylibSound, data, sampleCount);
    }

    /// <summary>
    /// Unload a sound alias (does not deallocate sample data)
    /// </summary>
    public void UnloadAlias(Sound alias)
    {
        Raylib.UnloadSoundAlias(alias.raylibSound);
    }

    /// <summary>
    /// Play the sound
    /// </summary>
    public void Play()
    {
        Raylib.PlaySound(raylibSound);
    }

    /// <summary>
    /// Stop playing a sound
    /// </summary>
    public void Stop()
    {
        Raylib.StopSound(raylibSound);
    }

    /// <summary>
    /// Pause a sound
    /// </summary>
    public void Pause()
    {
        Raylib.PauseSound(raylibSound);
    }

    /// <summary>
    /// Resume a paused sound
    /// </summary>
    public void Resume()
    {
        Raylib.ResumeSound(raylibSound);
    }

    /// <summary>
    /// Set volume for a sound (1.0 is max level)
    /// </summary>
    public void SetVolume(float volume)
    {
        Raylib.SetSoundVolume(raylibSound, volume);
    }

    /// <summary>
    /// Set pitch for a sound (1.0 is base level)
    /// </summary>
    public void SetPitch(float pitch)
    {
        Raylib.SetSoundPitch(raylibSound, pitch);
    }

    /// <summary>
    /// Set pan for a sound (0.5 is center)
    /// </summary>
    public void SetPan(float pan)
    {
        Raylib.SetSoundPan(raylibSound, pan);
    }

    /// <summary>
    /// Unload sound
    /// </summary>
    protected override void Unload()
    {
        if (!Ready)
        {
            throw new Exception("Error: Sound is not loaded yet");
        }

        Raylib.UnloadSound(raylibSound);

        base.Unload();
    }

    protected override void Dispose(bool disposing)
    {
        Unload();
    }
}
