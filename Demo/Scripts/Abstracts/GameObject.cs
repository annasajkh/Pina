using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

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
