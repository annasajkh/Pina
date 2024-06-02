using Demo.Scripts.GameObjects;
using Pina.Scripts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

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
