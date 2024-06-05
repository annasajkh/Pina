using Demo.Scripts.GameObjects;
using Pina.Interfaces;
using System.Numerics;

namespace Demo.Scripts.Entities;

public class Entity : GameObject, IUpdatable
{
    public Vector2 Velocity { get; protected set; }

    public Entity(Vector2 position, float rotation) : base(position, rotation)
    {

    }

    public virtual void Update(float delta)
    {
        Position += Velocity * delta;
    }
}
