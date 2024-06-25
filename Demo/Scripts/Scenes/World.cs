using Demo.Scripts.Entities;
using Pina.Abstracts;
using Pina.Core;
using Raylib_cs;
using System.Numerics;
using Sound = Pina.Resources.Sound;
using Timer = Pina.Components.Timer;
namespace Demo.Scripts.Scenes;

public class World : Scene
{
    Color color = Color.White;
    Player player;
    Timer shotTimer;
    Sound sound;

    public override void Load()
    {
        shotTimer = new Timer(0.5f, false);
        shotTimer.Start();
        sound = Sound.Load(Path.Combine("Assets", "Musics", "Different Heaven & Sian Area - Feel Like Horrible [NCS Release].mp3"));
    }

    public override void Init()
    {
        player = new Player(position: new Vector2(Application.RenderWidth / 2, Application.RenderHeight / 2), rotation: 0);
        sound.Play();
        sound.SetVolume(0.5f);
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
        sound.Dispose();
    }
}
