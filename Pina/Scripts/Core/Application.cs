using Pina.Scripts.Core.Types;
using Pina.Scripts.Managers;
using Raylib_cs;

namespace Pina.Scripts.Core;


public static class Application
{
    public static SceneManager SceneManager { get; private set; }

    private static int? targetFPS = 60;

    /// <summary>
    /// Set target FPS (maximum)
    /// </summary>
    public static int? TargetFPS
    {
        get
        {
            return targetFPS;
        }

        set
        {
            targetFPS = value;

            if (targetFPS != null)
            {
                Raylib.SetTargetFPS((int)targetFPS);
            }
        }
    }

    /// <summary>
    /// Get time in seconds for last frame drawn (delta time)
    /// </summary>
    public static float FrameTime
    {
        get
        {
            return Raylib.GetFrameTime();
        }
    }

    /// <summary>
    /// Get elapsed time in seconds since window initialization
    /// </summary>
    public static double Time
    {
        get
        {
            return Raylib.GetTime();
        }
    }

    /// <summary>
    /// Get current FPS
    /// </summary>
    public static int FPS
    {
        get
        {
            return Raylib.GetFPS();
        }
    }

    private static bool eventWaiting;

    /// <summary>
    /// Enable/Disable events on EndDrawing(), no automatic event polling/automatic event polling
    /// </summary>
    public static bool EventWaiting
    {
        get
        {
            return eventWaiting;
        }

        set
        {
            eventWaiting = value;

            if (eventWaiting)
            {
                Raylib.EnableEventWaiting();
            }
            else
            {
                Raylib.DisableEventWaiting();
            }
        }
    }

    private static bool showCursor = true;

    /// <summary>
    /// Shows/Hides cursor
    /// </summary>
    public static bool ShowCursor
    {
        get
        {
            return showCursor;
        }

        set
        {
            showCursor = value;

            if (showCursor)
            {
                Raylib.ShowCursor();
            }
            else
            {
                Raylib.HideCursor();
            }
        }
    }

    private static bool lockCursor;

    /// <summary>
    /// Lock/Unlock cursor
    /// </summary>
    public static bool LockCursor
    {
        get
        {
            return lockCursor;
        }

        set
        {
            lockCursor = value;

            if (lockCursor)
            {
                Raylib.DisableCursor();
            }
            else
            {
                Raylib.EnableCursor();
            }
        }
    }

    /// <summary>
    /// Get current render width (it considers HiDPI)
    /// </summary>
    public static int RenderWidth
    {
        get
        {
            return Raylib.GetRenderWidth();
        }
    }

    /// <summary>
    /// Get current render height (it considers HiDPI)
    /// </summary>
    public static int RenderHeight
    {
        get
        {
            return Raylib.GetRenderHeight();
        }
    }

    /// <summary>
    /// Set clipboard text content
    /// </summary>
    /// <param name="text">The text</param>
    public static void SetClipboardText(string text)
    {
        Raylib.SetClipboardText(text);
    }

    /// <summary>
    /// Get clipboard text content
    /// </summary>
    public static string GetClipboardText()
    {
        return Raylib.GetClipboardText_();
    }

    // TODO: implement the rest of it

    public static void Run(SceneManager sceneManager)
    {
        SceneManager = sceneManager;

        if (Window.FullScreen)
        {
            Raylib.SetConfigFlags(ConfigFlags.FullscreenMode);
        }

        if (Window.Resizable)
        {
            Raylib.SetConfigFlags(ConfigFlags.ResizableWindow);
        }

        if (Window.Undecorated)
        {
            Raylib.SetConfigFlags(ConfigFlags.UndecoratedWindow);
        }

        if (Window.Hidden)
        {
            Raylib.SetConfigFlags(ConfigFlags.HiddenWindow);
        }

        if (Window.Minimized)
        {
            Raylib.SetConfigFlags(ConfigFlags.MinimizedWindow);
        }

        if (Window.Maximized)
        {
            Raylib.SetConfigFlags(ConfigFlags.MaximizedWindow);
        }

        if (!Window.Focused)
        {
            Raylib.SetConfigFlags(ConfigFlags.UnfocusedWindow);
        }

        if (Window.TopMost)
        {
            Raylib.SetConfigFlags(ConfigFlags.TopmostWindow);
        }

        if (Window.AlwaysRun)
        {
            Raylib.SetConfigFlags(ConfigFlags.AlwaysRunWindow);
        }

        if (Window.VSync)
        {
            Raylib.SetConfigFlags(ConfigFlags.VSyncHint);
        }

        if (Window.HighDPI)
        {
            Raylib.SetConfigFlags(ConfigFlags.HighDpiWindow);
        }

        if (Window.Transparent)
        {
            Raylib.SetConfigFlags(ConfigFlags.TransparentWindow);
        }

        if (Window.Msaa4xHint)
        {
            Raylib.SetConfigFlags(ConfigFlags.Msaa4xHint);
        }

        if (TargetFPS != null)
        {
            Raylib.SetTargetFPS((int)TargetFPS);
        }

        Raylib.InitWindow(Window.Size.X, Window.Size.Y, Window.Title);
        Raylib.SetWindowPosition(Window.Position.X, Window.Position.Y);
        Raylib.SetWindowMonitor(Window.Monitor);
        Raylib.SetWindowOpacity(Window.Opacity);

        if (Window.Resizable)
        {
            if (Window.MinSize is Vector2i minSizeVec2i)
            {
                Raylib.SetWindowMinSize(minSizeVec2i.X, minSizeVec2i.Y);
            }
        }

        if (Window.Icon != null)
        {
            Raylib.SetWindowIcon((Image)Window.Icon);
        }

        SceneManager.ActiveScene.Load();
        SceneManager.ActiveScene.Init();

        while (!Raylib.WindowShouldClose())
        {
            SceneManager.ActiveScene.GetInput();
            SceneManager.ActiveScene.Update(Raylib.GetFrameTime());
            SceneManager.ActiveScene.Draw();
        }

        SceneManager.ActiveScene.Unload();
        Raylib.CloseWindow();
    }

}
