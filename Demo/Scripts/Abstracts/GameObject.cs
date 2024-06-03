using System.Numerics;

namespace Demo.Scripts.GameObjects;

public abstract class GameObject
{
    public Vector2 Position { get; protected set; }
    public float Rotation { get; protected set; }

    public GameObject(Vector2 position, float rotation)
    {
        Position = position;
        Rotation = rotation;
    }
}
