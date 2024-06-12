﻿using Demo.Scripts.Entities;
using Pina.Abstracts;
using Pina.Core;
using Raylib_cs;
using System.Numerics;
using Timer = Pina.Components.Timer;

namespace Demo.Scripts.Scenes;

public class World : Scene
{
    private Color color = Color.White;
    private Player player;
    private Timer shotTimer;

    public override void Load()
    {
        shotTimer = new Timer(0.5f, false);
        shotTimer.Start();
    }

    public override void Init()
    {
        player = new Player(position: new Vector2(Application.RenderWidth / 2, Application.RenderHeight / 2), rotation: 0);
    }

    public override void GetInput()
    {
        if (Input.IsKeyPressed(KeyboardKey.Q))
        {
            Application.SceneManager.ChangeScene("MainMenu");
        }
    }

    public override void Update(float delta)
    {
        shotTimer.Step(delta);
        player.Update(delta);
    }

    public override void Draw()
    {
        Graphics.BeginDrawing();
        Graphics.ClearBackground(Color.Black);

        player.Draw();
        
        Graphics.EndDrawing();
    }

    public override void Dispose()
    {
        base.Dispose();

        player.Dispose();
    }
}