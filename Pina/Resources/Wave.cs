using Raylib_cs;
using RaylibWave = Raylib_cs.Wave;

namespace Pina.Resources;

public class Wave : Resource
{
    public RaylibWave raylibWave;

    /// <summary>
    /// Determine if the wave is ready
    /// </summary>
    public bool Ready
    {
        get
        {
            return Raylib.IsWaveReady(raylibWave);
        }
    }

    /// <summary>
    /// Load wave data from file
    /// </summary>
    public static Wave Load(string fileName)
    {
        Wave wave = new Wave();

        wave.raylibWave = Raylib.LoadWave(fileName);

        return wave;
    }

    /// <summary>
    /// Load wave from memory buffer, fileType refers to extension: i.e. '.wav'
    /// </summary>
    public static Wave LoadFromMemory(string fileType, byte[] fileData)
    {
        Wave wave = new Wave();

        wave.raylibWave = Raylib.LoadWaveFromMemory(fileType, fileData);

        return wave;
    }


    /// <summary>
    /// Export wave data to file, returns true on success
    /// </summary>
    public bool Export(string fileName)
    {
        return Raylib.ExportWave(raylibWave, fileName);
    }

    /// <summary>
    /// Export wave sample data to code (.h), returns true on success
    /// </summary>
    public bool ExportAsCode(string fileName)
    {
        return Raylib.ExportWaveAsCode(raylibWave, fileName);
    }

    /// <summary>
    /// Copy a wave to a new wave
    /// </summary>
    public Wave Copy()
    {
        Wave wave = new Wave();

        wave.raylibWave = Raylib.WaveCopy(raylibWave);

        return wave;
    }

    /// <summary>
    /// Crop a wave to defined samples range
    /// </summary>
    public void Crop(int initSample, int finalSample)
    {
        Raylib.WaveCrop(ref raylibWave, initSample, finalSample);
    }

    /// <summary>
    /// Convert wave data to desired format
    /// </summary>
    public void Format(int sampleRate, int sampleSize, int channels)
    {
        Raylib.WaveFormat(ref raylibWave, sampleRate, sampleSize, channels);
    }

    /// <summary>
    /// Load samples data from wave as a 32bit float data array
    /// </summary>
    public unsafe float* LoadSamples()
    {
        return Raylib.LoadWaveSamples(raylibWave);
    }

    /// <summary>
    /// Unload samples data loaded with LoadSamples()
    /// </summary>
    public unsafe void UnloadSamples(float* samples)
    {
        Raylib.UnloadWaveSamples(samples);
    }

    /// <summary>
    /// Unload wave data
    /// </summary>
    protected override void Unload()
    {
        if (!Ready)
        {
            throw new Exception("Error: Wave is not loaded yet");
        }

        Raylib.UnloadWave(raylibWave);

        base.Unload();
    }

    protected override void Dispose(bool disposing)
    {
        Unload();
    }
}
