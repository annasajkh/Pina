using Pina.Resources;
using Pina.Types;

namespace Pina.Core;

public class WindowConfig
{
    /// <summary>
    /// Title of the window
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Size of the window
    /// </summary>
    public Vector2i Size { get; set; }

    /// <summary>
    /// Minimum size of the window, only works if the window is resizable
    /// </summary>
    public Vector2i? MinSize { get; set; }

    /// <summary>
    /// Maximum size of the window, only works if the window is resizable
    /// </summary>
    public Vector2i? MaxSize { get; set; }

    /// <summary>
    /// Position of the window
    /// </summary>
    public Vector2i? Position { get; set; }

    /// <summary>
    /// Icon of the window
    /// </summary>
    public Image? Icon { get; set; }

    /// <summary>
    /// Set window state: fullscreen/windowed (only on desktop platforms)
    /// </summary>
    public bool FullScreen { get; set; }

    /// <summary>
    /// Set window state: resizable (only on desktop platforms)
    /// </summary>
    public bool Resizable { get; set; }

    /// <summary>
    /// Set window state: undecorated (only on desktop platforms)
    /// </summary>
    public bool Undecorated { get; set; }

    /// <summary>
    /// Set window state: hidden (only on desktop platforms)
    /// </summary>
    public bool Hidden { get; set; }

    /// <summary>
    /// Set window state: minimized (only on desktop platforms)
    /// </summary>
    public bool Minimized { get; set; }

    /// <summary>
    /// Set window state: maximized (only on desktop platforms)
    /// </summary>
    public bool Maximized { get; set; }

    /// <summary>
    /// Set window state: focused (only on desktop platforms)
    /// </summary>
    public bool Focused { get; set; } = true;

    /// <summary>
    /// Set window state: top most (only on desktop platforms)
    /// </summary>
    public bool TopMost { get; set; }

    /// <summary>
    /// Set window state: AlwaysRun (only on desktop platforms)
    /// </summary>
    public bool AlwaysRun { get; set; }

    /// <summary>
    /// Set window state: VSync (only on desktop platforms)
    /// </summary>
    public bool VSync { get; set; } = true;

    /// <summary>
    /// Set monitor for the current window
    /// </summary>
    public int Monitor { get; set; }

    /// <summary>
    /// Set window opacity [0.0f..1.0f] (only on desktop platforms)
    /// </summary>
    public float Opacity { get; set; } = 1;

    /// <summary>
    /// Set window state: high DPI
    /// </summary>
    public bool HighDPI { get; set; }

    /// <summary>
    /// Set window state: transparent
    /// </summary>
    public bool Transparent { get; set; }

    /// <summary>
    /// Set window state: Msaa 4x Hint
    /// </summary>
    public bool Msaa4xHint { get; set; }

    public WindowConfig(string title, Vector2i size)
    {
        Title = title;
        Size = size;
    }

    ~WindowConfig()
    {
        Icon?.Dispose();
    }
}
