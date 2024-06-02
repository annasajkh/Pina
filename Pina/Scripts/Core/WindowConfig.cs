// Ignore Spelling: Resizable

using Pina.Scripts.Core.Types;
using Raylib_cs;
using System.Numerics;

namespace Pina.Scripts.Core;

public class WindowConfig
{
    /// <summary>
    /// Title of the window
    /// </summary>
    public string Title { get; }

    /// <summary>
    /// Size of the window
    /// </summary>
    public Vector2i Size { get; }

    /// <summary>
    /// Minimum size of the window, only works if the window is resizable
    /// </summary>
    public Vector2i? MinSize { get; }

    /// <summary>
    /// Maximum size of the window, only works if the window is resizable
    /// </summary>
    public Vector2i? MaxSize { get; }

    /// <summary>
    /// Position of the window
    /// </summary>
    public Vector2i? Position { get; }

    /// <summary>
    /// Icon of the window
    /// </summary>
    public Image? Icon { get; }

    /// <summary>
    /// Set window state: fullscreen/windowed (only on desktop platforms)
    /// </summary>
    public bool FullScreen { get; }

    /// <summary>
    /// Set window state: resizable (only on desktop platforms)
    /// </summary>
    public bool Resizable { get; }

    /// <summary>
    /// Set window state: undecorated (only on desktop platforms)
    /// </summary>
    public bool Undecorated { get; }

    /// <summary>
    /// Set window state: hidden (only on desktop platforms)
    /// </summary>
    public bool Hidden { get; }

    /// <summary>
    /// Set window state: minimized (only on desktop platforms)
    /// </summary>
    public bool Minimized { get; }

    /// <summary>
    /// Set window state: maximized (only on desktop platforms)
    /// </summary>
    public bool Maximized { get; }

    /// <summary>
    /// Set window state: focused (only on desktop platforms)
    /// </summary>
    public bool Focused { get; } = true;

    /// <summary>
    /// Set window state: top most (only on desktop platforms)
    /// </summary>
    public bool TopMost { get; }

    /// <summary>
    /// Set window state: AlwaysRun (only on desktop platforms)
    /// </summary>
    public bool AlwaysRun { get; }

    /// <summary>
    /// Set window state: VSync (only on desktop platforms)
    /// </summary>
    public bool VSync { get; } = true;

    /// <summary>
    /// Set monitor for the current window
    /// </summary>
    public int Monitor { get; }

    /// <summary>
    /// Set window opacity [0.0f..1.0f] (only on desktop platforms)
    /// </summary>
    public float Opacity { get; } = 1;

    /// <summary>
    /// Set window state: high DPI
    /// </summary>
    public bool HighDPI { get; }

    /// <summary>
    /// Set window state: transparent
    /// </summary>
    public bool Transparent { get; }

    /// <summary>
    /// Set window state: Msaa 4x Hint
    /// </summary>
    public bool Msaa4xHint { get; }

    public WindowConfig(
        string title,
        Vector2i size,
        Vector2i? minSize = null,
        Vector2i? maxSize = null,
        Vector2i? position = null,
        Image? icon = null,
        bool fullScreen = false,
        bool resizable = false,
        bool undecorated = false,
        bool hidden = false,
        bool minimized = false,
        bool maximized = false,
        bool focused = true,
        bool topMost = false,
        bool alwaysRun = false,
        bool vSync = true,
        int monitor = 0,
        float opacity = 1,
        bool highDPI = false,
        bool transparent = false,
        bool msaa4xHint = false)
    {
        Title = title;
        Size = size;
        MinSize = minSize;
        MaxSize = maxSize;
        Position = position;
        Icon = icon;
        FullScreen = fullScreen;
        Resizable = resizable;
        Undecorated = undecorated;
        Hidden = hidden;
        Minimized = minimized;
        Maximized = maximized;
        Focused = focused;
        TopMost = topMost;
        AlwaysRun = alwaysRun;
        VSync = vSync;
        Monitor = monitor;
        Opacity = opacity;
        HighDPI = highDPI;
        Transparent = transparent;
        Msaa4xHint = msaa4xHint;
    }
}
