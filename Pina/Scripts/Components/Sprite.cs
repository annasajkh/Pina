using Pina.Scripts.Interfaces;
using Pina.Scripts.Resources;
using Raylib_cs;
using System.Numerics;

namespace Pina.Scripts.Components;

public sealed class Sprite : IDrawable
{
    public Vector2 Position { get; set; }
    public float Rotation { get; set; }
    public Vector2 Scale { get; set; }
    public Color Color { get; set; } = Color.White;

    public uint Rows { get; } = 1;
    public uint Columns { get; } = 1;
    public uint FrameIndex { get; set; } = 0;
    public Vector2 Origin { get; set; }

    public TextureResource TextureResource { get; }
    public TextureFilter TextureFilter { get; set; } = TextureFilter.Point;

    public uint FrameCount
    {
        get
        {
            return Rows * Columns;
        }
    }

    public Rectangle BoundingRectangle
    {
        get
        {
            return new Rectangle(Position.X - Origin.X, Position.Y - Origin.Y, Size.X, Size.Y);
        }
    }

    public Vector2 Size
    {
        get
        {
            return new Vector2(sourceRectangle.Width * Scale.X, sourceRectangle.Height * Scale.Y);
        }
    }
    private Rectangle sourceRectangle;

    public Sprite(TextureResource textureResource, Vector2 position = new Vector2(), uint rows = 1, uint columns = 1)
    {
        Position = position;
        Rotation = 0;
        Scale = Vector2.One;

        Rows = rows;
        Columns = columns;
        TextureResource = textureResource;
        sourceRectangle = new Rectangle(0, 0, TextureResource.Texture.Width / columns, TextureResource.Texture.Height / rows);

        Origin = new Vector2(sourceRectangle.Width / 2, sourceRectangle.Height / 2);
    }


    // Sprite sheet index
    // |-----------|
    // | 0 | 1 | 2 |
    // |---|---|---|
    // | 3 | 4 | 5 |
    // |---|---|---|
    // | 6 | 7 | 8 |
    // |-----------|
    public void Draw()
    {
        if (FrameIndex > FrameCount - 1)
        {
            throw new IndexOutOfRangeException();
        }

        sourceRectangle.X = sourceRectangle.Width * (FrameIndex % Columns);
        sourceRectangle.Y = sourceRectangle.Height * (FrameIndex / Columns);

        Raylib.DrawTexturePro(TextureResource.Texture, sourceRectangle, new Rectangle(Position.X, Position.Y, Size.X, Size.Y), Origin, Rotation, Color);
    }

    public void DrawBoundingRectangle()
    {
        Raylib.DrawRectangleLines((int)BoundingRectangle.X, (int)BoundingRectangle.Y, (int)BoundingRectangle.Width, (int)BoundingRectangle.Height, Color.Green);
    }
}