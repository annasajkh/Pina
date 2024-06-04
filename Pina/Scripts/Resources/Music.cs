using Raylib_cs;
using RaylibMusic = Raylib_cs.Music;

namespace Pina.Scripts.Resources;

public class Music : Resource
{
    RaylibMusic raylibMusic;

    /// <summary>
    /// Determine if the music is ready
    /// </summary>
    public bool Ready
    {
        get
        {
            return Raylib.IsMusicReady(raylibMusic);
        }
    }

    /// <summary>
    /// determine if the music is currently playing
    /// </summary>
    public bool Playing
    {
        get
        {
            return Raylib.IsMusicStreamPlaying(raylibMusic);
        }
    }

    /// <summary>
    /// Load music stream from file
    /// </summary>
    public static Music LoadStream(string fileName)
    {
        Music music = new Music();

        music.raylibMusic = Raylib.LoadMusicStream(fileName);

        return music;
    }

    /// <summary>
    /// Load music stream from data
    /// </summary>
    public static Music LoadStreamFromMemory(string fileType, byte[] fileData)
    {
        Music music = new Music();

        music.raylibMusic = Raylib.LoadMusicStreamFromMemory(fileType, fileData);

        return music;
    }

    /// <summary>
    /// Start music playing
    /// </summary>
    public void PlayStream()
    {
        Raylib.PlayMusicStream(raylibMusic);
    }

    /// <summary>
    /// Updates buffers for music streaming
    /// </summary>
    public void UpdateStream()
    {
        Raylib.UpdateMusicStream(raylibMusic);
    }

    /// <summary>
    /// Stop music playing
    /// </summary>
    public void StopStream()
    {
        Raylib.StopMusicStream(raylibMusic);
    }

    /// <summary>
    /// Pause music playing
    /// </summary>
    public void PauseStream()
    {
        Raylib.PauseMusicStream(raylibMusic);
    }

    /// <summary>
    /// Resume playing paused music
    /// </summary>
    public void ResumeStream()
    {
        Raylib.ResumeMusicStream(raylibMusic);
    }

    /// <summary>
    /// Seek music to a position (in seconds)
    /// </summary>
    public void SeekStream(float position)
    {
        Raylib.SeekMusicStream(raylibMusic, position);
    }

    /// <summary>
    /// Set volume for music (1.0 is max level)
    /// </summary>
    public void SetVolume(float volume)
    {
        Raylib.SetMusicVolume(raylibMusic, volume);
    }

    /// <summary>
    /// Set pitch for a music (1.0 is base level)
    /// </summary>
    public void SetPitch(float pitch)
    {
        Raylib.SetMusicPitch(raylibMusic, pitch);
    }

    /// <summary>
    /// Set pan for a music (0.5 is center)
    /// </summary>
    public void SetPan(float pan)
    {
        Raylib.SetMusicPan(raylibMusic, pan);
    }

    public float GetTimeLength()
    {
        return Raylib.GetMusicTimeLength(raylibMusic);
    }

    public float GetTimePlayed()
    {
        return Raylib.GetMusicTimePlayed(raylibMusic); 
    }

    /// <summary>
    /// Unload music stream
    /// </summary>
    protected override void Unload()
    {
        if (!Ready)
        {
            throw new Exception("Error: Music is not loaded yet");
        }

        Raylib.UnloadMusicStream(raylibMusic);

        base.Unload();
    }

    protected override void Dispose(bool disposing)
    {
        Unload();
    }
}
