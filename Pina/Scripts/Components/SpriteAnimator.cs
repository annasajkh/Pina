using Pina.Scripts.Interfaces;

namespace Pina.Scripts.Components;


public sealed class SpriteAnimator : IUpdatable
{
    public uint[] FrameIndices { get; }
    public float FramePerSecond { get; }
    public bool Reversed { get; set; }
    public int FrameIndex { get; private set; }
    public Sprite Sprite { get; }

    private float singleFrameElapsed;

    public SpriteAnimator(Sprite sprite, float framePerSecond, uint[] frameIndices, bool reversed = false)
    {
        FrameIndices = frameIndices;
        FramePerSecond = framePerSecond;
        Reversed = reversed;

        Sprite = sprite;
    }

    public void Update(float delta)
    {
        // Update to the next frame
        if (singleFrameElapsed >= 1f / FramePerSecond)
        {
            FrameIndex += Reversed ? -1 : 1;

            singleFrameElapsed = 0;
        }

        singleFrameElapsed += delta;

        // Out of bounds handling
        if (FrameIndex < 0)
        {
            FrameIndex = FrameIndices.Length - 1;
        }
        else if (FrameIndex > FrameIndices.Length - 1)
        {
            FrameIndex = 0;
        }

        Sprite.FrameIndex = FrameIndices[FrameIndex];
    }
}