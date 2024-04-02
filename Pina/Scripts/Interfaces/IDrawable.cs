using Raylib_cs;

namespace Pina.Scripts.Interfaces;

public interface IDrawable
{
    public Rectangle BoundingRectangle { get; }

    public abstract void Draw();
}
