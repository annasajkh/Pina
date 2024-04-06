using Pina.Scripts.Core.Types;
using Pina.Scripts.Managers;
using Raylib_cs;

namespace Pina.Scripts.Core;


public static class Application
{
    public static SceneManager SceneManager { get; private set; }
    public static ResourceManager ResourceManager { get; private set; }

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

    /// <summary>
    /// Takes a screenshot of current screen (filename extension defines format)
    /// </summary>
    /// <param name="filename">The file name it will be saved to</param>
    public static void TakeScreenshot(string filename)
    {
        Raylib.TakeScreenshot(filename);
    }

    /// <summary>
    /// Setup init configuration flags (view FLAGS)
    /// </summary>
    /// <param name="flags">The flags</param>
    public static void SetConfigFlags(ConfigFlags flags)
    {
        Raylib.SetConfigFlags(flags);
    }

    /// <summary>
    /// Open URL with default system browser (if available)
    /// </summary>
    /// <param name="url"></param>
    public static void OpenURL(string url)
    {
        Raylib.OpenURL(url);
    }

    // TODO: implement the rest of it

    public static void Run(SceneManager sceneManager, ResourceManager resourceManager)
    {
        SceneManager = sceneManager;
        ResourceManager = resourceManager;

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

        if (eventWaiting)
        {
            Raylib.EnableEventWaiting();
        }
        else
        {
            Raylib.DisableEventWaiting();
        }

        if (showCursor)
        {
            Raylib.ShowCursor();
        }
        else
        {
            Raylib.HideCursor();
        }

        if (lockCursor)
        {
            Raylib.DisableCursor();
        }
        else
        {
            Raylib.EnableCursor();
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
        ResourceManager.UnloadAll();
        Raylib.CloseWindow();
    }

}
