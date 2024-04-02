using Pina.Scripts.Interfaces;

namespace Pina.Scripts.Utilities.Components;

public sealed class SpriteAnimatorController : IUpdatable
{
    public Dictionary<string, SpriteAnimator> Animations { get; } = new();
    public string CurrentlyPlaying { get; set; }

    public SpriteAnimatorController(Dictionary<string, SpriteAnimator> animations, string currentlyPlaying)
    {
        Animations = animations;
        CurrentlyPlaying = currentlyPlaying;
    }

    public void Update(float delta)
    {
        Animations[CurrentlyPlaying].Update(delta);
    }
}