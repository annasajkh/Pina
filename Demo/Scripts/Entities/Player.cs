﻿using Pina.Core;
using Pina.Interfaces;
using Raylib_cs;
using System.Numerics;
using Texture2D = Pina.Resources.Texture2D;
namespace Demo.Scripts.Entities;

public class Player : Entity, IDrawable, IDisposable
{
    private Texture2D catTexture;
    private float speed = 100f;

    public Player(Vector2 position, float rotation) : base(position, rotation)
    {
        catTexture = Texture2D.Load(Path.Combine("Assets", "Sprites", "cat.png"));
        catTexture.raylibTexture2D.Width = 64;
        catTexture.raylibTexture2D.Height = 64;
    }

    public void Draw()
    {
        Graphics.DrawTextureRec(catTexture.raylibTexture2D, catTexture.SourceRectangle, Position, Color.White);
    }

    public override void Update(float delta)
    {
        Vector2 direction = new Vector2();

        if (Input.IsKeyDown(KeyboardKey.D))
        {
            direction.X = 1;
        }
        if (Input.IsKeyDown(KeyboardKey.A))
        {
            direction.X = -1;
        }
        if(Input.IsKeyDown(KeyboardKey.W))
        {
            direction.Y = -1;
        }
        if (Input.IsKeyDown(KeyboardKey.S))
        {
            direction.Y = 1;
        }

        Velocity = direction * speed;

        base.Update(delta);
    }

    public void Dispose()
    {
        catTexture.Dispose();
    }
}
