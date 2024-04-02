using Raylib_cs;
using System.Numerics;

namespace Pina.Scripts.Core;

public static class Monitor
{
    /// <summary>
    ///  Get number of connected monitors
    /// </summary>
    public static int Count
    {
        get
        {
            return Raylib.GetMonitorCount();
        }
    }

    /// <summary>
    /// Get current connected monitor
    /// </summary>
    public static int Current
    {
        get
        {
            return Raylib.GetCurrentMonitor();
        }
    }

    /// <summary>
    /// Get specified monitor position
    /// </summary>
    /// <param name="monitor">The monitor</param>
    /// <returns></returns>
    public static Vector2 GetPosition(int monitor)
    {
        return Raylib.GetMonitorPosition(monitor);
    }

    /// <summary>
    /// Get specified monitor width (current video mode used by monitor)
    /// </summary>
    /// <param name="monitor">The monitor</param>
    /// <returns></returns>
    public static int GetWidth(int monitor)
    {
        return Raylib.GetMonitorWidth(monitor);
    }

    /// <summary>
    /// Get specified monitor height (current video mode used by monitor)
    /// </summary>
    /// <param name="monitor">The monitor</param>
    /// <returns></returns>
    public static int GetHeight(int monitor)
    {
        return Raylib.GetMonitorHeight(monitor);
    }

    /// <summary>
    /// Get specified monitor physical width in millimetres
    /// </summary>
    /// <param name="monitor">The monitor</param>
    /// <returns></returns>
    public static int GetPhysicalWidth(int monitor)
    {
        return Raylib.GetMonitorPhysicalWidth(monitor);
    }

    /// <summary>
    /// Get specified monitor physical height in millimetres
    /// </summary>
    /// <param name="monitor">The monitor</param>
    /// <returns></returns>
    public static int GetPhysicalHeight(int monitor)
    {
        return Raylib.GetMonitorPhysicalHeight(monitor);
    }

    /// <summary>
    /// Get specified monitor refresh rate
    /// </summary>
    /// <param name="monitor">The monitor</param>
    /// <returns></returns>
    public static int GetRefreshRate(int monitor)
    {
        return Raylib.GetMonitorRefreshRate(monitor);
    }

    /// <summary>
    /// Get the human-readable, UTF-8 encoded name of the specified monitor
    /// </summary>
    /// <param name="monitor"></param>
    /// <returns></returns>
    public static string GetName(int monitor)
    {
        return Raylib.GetMonitorName_(monitor);
    }
}
