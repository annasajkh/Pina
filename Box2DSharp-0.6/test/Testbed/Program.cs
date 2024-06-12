﻿using OpenTK.Mathematics;
using OpenTK.Windowing.Desktop;
using Testbed.Abstractions;

namespace Testbed
{
    class Program
    {
        static void Main(string[] args)
        {
            Global.Settings = TestSettingHelper.Load();
            Global.Camera.Width = Global.Settings.WindowWidth;
            Global.Camera.Height = Global.Settings.WindowHeight;
            using (var game = new Game(
                new GameWindowSettings {RenderFrequency = 60, UpdateFrequency = 60},
                new NativeWindowSettings {Size = new Vector2i(Global.Settings.WindowWidth, Global.Settings.WindowHeight)}))
            {
                game.Run();
            }
        }
    }
}