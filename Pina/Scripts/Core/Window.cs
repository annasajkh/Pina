using Pina.Scripts.Core.Types;
using Pina.Scripts.Resources;
using Raylib_cs;
using System.Numerics;
using Image = Pina.Scripts.Resources.Image;

namespace Pina.Scripts.Core;

public static class Window
{
    private static string title = "";

    /// <summary>
    /// Title of the window
    /// </summary>
    public static string Title
    {
        get
        {
            return title;
        }

        set
        {
            title = value;
            Raylib.SetWindowTitle(title);
        }
    }

    private static Vector2i size = new Vector2i(960, 540);

    /// <summary>
    /// Size of the window
    /// </summary>
    public static Vector2i Size
    { 
        get
        {
            return size;
        }

        set
        {
            size = value;
            Raylib.SetWindowSize(size.X, size.Y);
        }
    }

    private static Vector2i? minSize;

    /// <summary>
    /// Minimum size of the window, only works if the window is resizable
    /// </summary>
    public static Vector2i? MinSize
    {
        get
        {
            return minSize;
        }

        set
        {
            minSize = value;

            if (Resizable)
            {
                if (minSize is Vector2i minSizeVec2i)
                {
                    Raylib.SetWindowMinSize(minSizeVec2i.X, minSizeVec2i.Y);
                }
            }
            else
            {
                throw new Exception("Error: Window needs to be resizable for it to have MinSize");
            }
        }
    }

    private static Vector2i? maxSize;

    /// <summary>
    /// Maximum size of the window, only works if the window is resizable
    /// </summary>
    public static Vector2i? MaxSize
    {
        get
        {
            return maxSize;
        }

        set
        {
            maxSize = value;

            if (Resizable)
            {
                if (maxSize is Vector2i maxSizeVec2i)
                {
                    Raylib.SetWindowMaxSize(maxSizeVec2i.X, maxSizeVec2i.Y);
                }
            }
            else
            {
                throw new Exception("Error: Window needs to be resizable for it to have MaxSize");
            }
        }
    }

    private static Vector2i position = new Vector2i(Screen.Width / 2, Screen.Height / 2);

    /// <summary>
    /// Position of the window
    /// </summary>
    public static Vector2i Position 
    {
        get
        {
            return position;
        }

        set
        {
            position = value;
            Raylib.SetWindowPosition(position.X, position.Y);
        }
    }

    private static Image? icon;

    /// <summary>
    /// Icon of the window
    /// </summary>
    public static Image? Icon 
    { 
        get
        {
            return icon;
        }

        set
        {
            if (icon != null && value != null)
            {
                icon.Dispose();
                Raylib.SetWindowIcon(value.raylibImage);
            }
            icon = value;
        }
    }

    private static bool fullScreen;

    /// <summary>
    /// Set window state: fullscreen/windowed (only on desktop platforms)
    /// </summary>
    public static bool FullScreen 
    { 
        get
        {
            return fullScreen;
        }

        set
        {
            fullScreen = value;

            if (fullScreen)
            {
                Raylib.SetWindowState(ConfigFlags.FullscreenMode);
            }
            else
            {
                Raylib.ClearWindowState(ConfigFlags.FullscreenMode);
            }
        }
    }

    private static bool resizable = false;

    /// <summary>
    /// Set window state: resizable (only on desktop platforms)
    /// </summary>
    public static bool Resizable 
    { 
        get
        {
            return resizable;
        }

        set
        {
            resizable = value;
            if (resizable)
            {
                Raylib.SetWindowState(ConfigFlags.ResizableWindow);
            }
            else
            {
                Raylib.ClearWindowState(ConfigFlags.ResizableWindow);
            }
        }
    }

    private static bool undecorated;

    /// <summary>
    /// Set window state: undecorated (only on desktop platforms)
    /// </summary>
    public static bool Undecorated 
    { 
        get
        {
            return undecorated;
        }

        set
        {
            undecorated = value;
            if (undecorated)
            {
                Raylib.SetWindowState(ConfigFlags.UndecoratedWindow);
            }
            else
            {
                Raylib.ClearWindowState(ConfigFlags.UndecoratedWindow);
            }
        }
    }

    private static bool hidden;

    /// <summary>
    /// Set window state: hidden (only on desktop platforms)
    /// </summary>
    public static bool Hidden 
    { 
        get
        {
            return hidden;
        }

        set
        {
            hidden = value;
            if (hidden)
            {
                Raylib.SetWindowState(ConfigFlags.HiddenWindow);
            }
            else
            {
                Raylib.ClearWindowState(ConfigFlags.HiddenWindow);
            }
        }
    }

    private static bool minimized;

    /// <summary>
    /// Set window state: minimized (only on desktop platforms)
    /// </summary>
    public static bool Minimized 
    { 
        get
        {
            return minimized;
        }

        set
        {
            minimized = value;
            if (minimized)
            {
                Raylib.SetWindowState(ConfigFlags.MinimizedWindow);
            }
            else
            {
                Raylib.ClearWindowState(ConfigFlags.MinimizedWindow);
            }
        }
    }

    private static bool maximized;

    /// <summary>
    /// Set window state: maximized (only on desktop platforms)
    /// </summary>
    public static bool Maximized
    {
        get
        {
            return maximized;
        }

        set
        {
            if (value && !Resizable)
            {
                throw new Exception("Error: To set window maximized the window need to be resizable!");
            }

            maximized = value;
            if (maximized)
            {
                Raylib.SetWindowState(ConfigFlags.MaximizedWindow);
            }
            else
            {
                Raylib.ClearWindowState(ConfigFlags.MaximizedWindow);
            }
        }
    }

    private static bool focused = true;

    /// <summary>
    /// Set window state: focused (only on desktop platforms)
    /// </summary>
    public static bool Focused 
    { 
        get
        {
            return focused;
        }

        set
        {
            focused = value;

            if (!focused)
            {
                Raylib.SetWindowState(ConfigFlags.UnfocusedWindow);
            }
            else
            {
                Raylib.ClearWindowState(ConfigFlags.UnfocusedWindow);
            }
        }
    }

    private static bool topMost = false;

    /// <summary>
    /// Set window state: top most (only on desktop platforms)
    /// </summary>
    public static bool TopMost 
    { 
        get
        {
            return topMost;
        }

        set
        {
            topMost = value;
            if (topMost)
            {
                Raylib.SetWindowState(ConfigFlags.TopmostWindow);
            }
            else
            {
                Raylib.ClearWindowState(ConfigFlags.TopmostWindow);
            }
        }
    }

    private static bool alwaysRun;

    /// <summary>
    /// Set window state: AlwaysRun (only on desktop platforms)
    /// </summary>
    public static bool AlwaysRun 
    { 
        get
        {
            return alwaysRun;
        }

        set
        {
            alwaysRun = value;
            if (alwaysRun)
            {
                Raylib.SetWindowState(ConfigFlags.AlwaysRunWindow);
            }
            else
            {
                Raylib.ClearWindowState(ConfigFlags.AlwaysRunWindow);
            }
        }
    }

    private static bool vSync = true;

    /// <summary>
    /// Set window state: VSync (only on desktop platforms)
    /// </summary>
    public static bool VSync 
    { 
        get
        {
            return vSync;
        }

        set
        {
            vSync = value;
            if (vSync)
            {
                Raylib.SetWindowState(ConfigFlags.VSyncHint);
            }
            else
            {
                Raylib.ClearWindowState(ConfigFlags.VSyncHint);
            }
        }
    }

    private static int monitor;

    /// <summary>
    /// Set monitor for the current window
    /// </summary>
    public static int Monitor
    {
        get
        {
            return monitor;
        }

        set
        {
            monitor = value;
            Raylib.SetWindowMonitor(monitor);
        }
    }

    private static float opacity = 1;

    /// <summary>
    /// Set window opacity [0.0f..1.0f] (only on desktop platforms)
    /// </summary>
    public static float Opacity
    {
        get
        {
            return opacity;
        }

        set
        {
            opacity = value;
            Raylib.SetWindowOpacity(value);
        }
    }

    /// <summary>
    /// Set window state: high DPI
    /// </summary>
    public static bool HighDPI { get; set; }

    /// <summary>
    /// Set window state: transparent
    /// </summary>
    public static bool Transparent { get; set; }

    /// <summary>
    /// Set window state: Msaa 4x Hint
    /// </summary>
    public static bool Msaa4xHint { get; set; }

    /// <summary>
    /// Get window scale dpi
    /// </summary>
    public static Vector2 ScaleDPI
    {
        get
        {
            return Raylib.GetWindowScaleDPI();
        }
    }

    /// <summary>
    /// Check if window has been initialized successfully
    /// </summary>
    public static bool Ready
    {
        get
        {
            return Raylib.IsWindowReady();
        }
    }

    /// <summary>
    /// Get native window handle
    /// </summary>
    public static unsafe void* Handle
    {
        get
        {
            return Raylib.GetWindowHandle();
        }
    }
}