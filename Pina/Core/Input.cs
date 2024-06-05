using Raylib_cs;
using System.Numerics;

namespace Pina.Core;


public static class Input
{
    /// <summary>
    /// Mouse X position
    public static int MouseX
    {
        get
        {
            return Raylib.GetMouseX();
        }
    }

    /// <summary>
    /// Mouse Y position
    /// </summary>
    public static int MouseY
    {
        get
        {
            return Raylib.GetMouseY();
        }
    }

    /// <summary>
    /// Check if a key has been pressed once
    /// </summary>
    /// <param name="key">The key to check</param>
    /// <returns>True if the key has been pressed once, otherwise false</returns>
    public static bool IsKeyPressed(KeyboardKey key)
    {
        return Raylib.IsKeyPressed(key);
    }

    /// <summary>
    /// Check if a key has been pressed again (Only PLATFORM_DESKTOP)
    /// </summary>
    /// <param name="key">The key to check</param>
    /// <returns>True if the key has been pressed again, otherwise false</returns>
    public static bool IsKeyPressedRepeat(KeyboardKey key)
    {
        return Raylib.IsKeyPressedRepeat(key);
    }

    /// <summary>
    /// Check if a key is being pressed
    /// </summary>
    /// <param name="key">The key to check</param>
    /// <returns>True if the key is being pressed, otherwise false</returns>
    public static bool IsKeyDown(KeyboardKey key)
    {
        return Raylib.IsKeyDown(key);
    }

    /// <summary>
    /// Check if a key has been released once
    /// </summary>
    /// <param name="key">The key to check</param>
    /// <returns>True if the key has been released once, otherwise false</returns>
    public static bool IsKeyReleased(KeyboardKey key)
    {
        return Raylib.IsKeyReleased(key);
    }

    /// <summary>
    /// Check if a key is NOT being pressed
    /// </summary>
    /// <param name="key">The key to check</param>
    /// <returns>True if the key is NOT being pressed, otherwise false</returns>
    public static bool IsKeyUp(KeyboardKey key)
    {
        return Raylib.IsKeyUp(key);
    }

    /// <summary>
    /// Get key pressed (keycode), call it multiple times for keys queued, returns 0 when the queue is empty
    /// </summary>
    /// <returns>The keycode of the pressed key, or 0 if the queue is empty</returns>
    public static int GetKeyPressed()
    {
        return Raylib.GetKeyPressed();
    }

    /// <summary>
    /// Get char pressed (unicode), call it multiple times for chars queued, returns 0 when the queue is empty
    /// </summary>
    /// <returns>The unicode value of the pressed character, or 0 if the queue is empty</returns>
    public static int GetCharPressed()
    {
        return Raylib.GetCharPressed();
    }

    /// <summary>
    /// Set a custom key to exit program (default is ESC)
    /// </summary>
    /// <param name="key">The custom key to set as exit key</param>
    public static void SetExitKey(KeyboardKey key)
    {
        Raylib.SetExitKey(key);
    }

    /// <summary>
    /// Check if a gamepad is available
    /// </summary>
    /// <param name="gamepad">The gamepad to check</param>
    /// <returns>True if the gamepad is available, otherwise false</returns>
    public static bool IsGamepadAvailable(int gamepad)
    {
        return Raylib.IsGamepadAvailable(gamepad);
    }

    /// <summary>
    /// Get gamepad internal name id
    /// </summary>
    /// <param name="gamepad">The gamepad</param>
    /// <returns>The internal name id of the gamepad</returns>
    public static string GetGamepadName(int gamepad)
    {
        return Raylib.GetGamepadName_(gamepad);
    }

    /// <summary>
    /// Check if a gamepad button has been pressed once
    /// </summary>
    /// <param name="gamepad">The gamepad</param>
    /// <param name="button">The button to check</param>
    /// <returns>True if the gamepad button has been pressed once, otherwise false</returns>
    public static bool IsGamepadButtonPressed(int gamepad, GamepadButton button)
    {
        return Raylib.IsGamepadButtonPressed(gamepad, button);
    }

    /// <summary>
    /// Check if a gamepad button is being pressed
    /// </summary>
    /// <param name="gamepad">The gamepad</param>
    /// <param name="button">The button to check</param>
    /// <returns>True if the gamepad button is being pressed, otherwise false</returns>
    public static bool IsGamepadButtonDown(int gamepad, GamepadButton button)
    {
        return Raylib.IsGamepadButtonDown(gamepad, button);
    }

    /// <summary>
    /// Check if a gamepad button has been released once
    /// </summary>
    /// <param name="gamepad">The gamepad</param>
    /// <param name="button">The button to check</param>
    /// <returns>True if the gamepad button has been released once, otherwise false</returns>
    public static bool IsGamepadButtonReleased(int gamepad, GamepadButton button)
    {
        return Raylib.IsGamepadButtonReleased(gamepad, button);
    }

    /// <summary>
    /// Check if a gamepad button is NOT being pressed
    /// </summary>
    /// <param name="gamepad">The gamepad</param>
    /// <param name="button">The button to check</param>
    /// <returns>True if the gamepad button is NOT being pressed, otherwise false</returns>
    public static bool IsGamepadButtonUp(int gamepad, GamepadButton button)
    {
        return Raylib.IsGamepadButtonUp(gamepad, button);
    }

    /// <summary>
    /// Get the last gamepad button pressed
    /// </summary>
    /// <returns>The keycode of the last gamepad button pressed</returns>
    public static int GetGamepadButtonPressed()
    {
        return Raylib.GetGamepadButtonPressed();
    }

    /// <summary>
    /// Get gamepad axis count for a gamepad
    /// </summary>
    /// <param name="gamepad">The gamepad</param>
    /// <returns>The number of axes for the gamepad</returns>
    public static int GetGamepadAxisCount(int gamepad)
    {
        return Raylib.GetGamepadAxisCount(gamepad);
    }

    /// <summary>
    /// Get axis movement value for a gamepad axis
    /// </summary>
    /// <param name="gamepad">The gamepad</param>
    /// <param name="axis">The axis to check</param>
    /// <returns>The axis movement value</returns>
    public static float GetGamepadAxisMovement(int gamepad, GamepadAxis axis)
    {
        return Raylib.GetGamepadAxisMovement(gamepad, axis);
    }

    /// <summary>
    /// Set internal gamepad mappings (SDL_GameControllerDB)
    /// </summary>
    /// <param name="mappings">The internal gamepad mappings to set</param>
    /// <returns>The number of mappings applied</returns>
    public static int SetGamepadMappings(string mappings)
    {
        return Raylib.SetGamepadMappings(mappings);
    }

    /// <summary>
    /// Check if a mouse button has been pressed once
    /// </summary>
    /// <param name="button">The button to check</param>
    /// <returns>True if the mouse button has been pressed once, otherwise false</returns>
    public static bool IsMouseButtonPressed(MouseButton button)
    {
        return Raylib.IsMouseButtonPressed(button);
    }

    /// <summary>
    /// Check if a mouse button is being pressed
    /// </summary>
    /// <param name="button">The button to check</param>
    /// <returns>True if the mouse button is being pressed, otherwise false</returns>
    public static bool IsMouseButtonDown(MouseButton button)
    {
        return Raylib.IsMouseButtonDown(button);
    }

    /// <summary>
    /// Check if a mouse button has been released once
    /// </summary>
    /// <param name="button">The button to check</param>
    /// <returns>True if the mouse button has been released once, otherwise false</returns>
    public static bool IsMouseButtonReleased(MouseButton button)
    {
        return Raylib.IsMouseButtonReleased(button);
    }

    /// <summary>
    /// Check if a mouse button is NOT being pressed
    /// </summary>
    /// <param name="button">The button to check</param>
    /// <returns>True if the mouse button is NOT being pressed, otherwise false</returns>
    public static bool IsMouseButtonUp(MouseButton button)
    {
        return Raylib.IsMouseButtonUp(button);
    }

    /// <summary>
    /// Get mouse position XY
    /// </summary>
    /// <returns>The mouse position as a Vector2</returns>
    public static Vector2 GetMousePosition()
    {
        return Raylib.GetMousePosition();
    }

    /// <summary>
    /// Get mouse delta between frames
    /// </summary>
    /// <returns>The mouse delta as a Vector2</returns>
    public static Vector2 GetMouseDelta()
    {
        return Raylib.GetMouseDelta();
    }

    /// <summary>
    /// Set mouse position XY
    /// </summary>
    /// <param name="x">The X position to set</param>
    /// <param name="y">The Y position to set</param>
    public static void SetMousePosition(int x, int y)
    {
        Raylib.SetMousePosition(x, y);
    }

    /// <summary>
    /// Set mouse offset
    /// </summary>
    /// <param name="offsetX">The X offset to set</param>
    /// <param name="offsetY">The Y offset to set</param>
    public static void SetMouseOffset(int offsetX, int offsetY)
    {
        Raylib.SetMouseOffset(offsetX, offsetY);
    }

    /// <summary>
    /// Set mouse scaling
    /// </summary>
    /// <param name="scaleX">The X scale factor to set</param>
    /// <param name="scaleY">The Y scale factor to set</param>
    public static void SetMouseScale(float scaleX, float scaleY)
    {
        Raylib.SetMouseScale(scaleX, scaleY);
    }

    /// <summary>
    /// Get mouse wheel movement for X or Y, whichever is larger
    /// </summary>
    /// <returns>The mouse wheel movement value</returns>
    public static float GetMouseWheelMove()
    {
        return Raylib.GetMouseWheelMove();
    }

    /// <summary>
    /// Get mouse wheel movement for both X and Y
    /// </summary>
    /// <returns>The mouse wheel movement as a Vector2</returns>
    public static Vector2 GetMouseWheelMoveV()
    {
        return Raylib.GetMouseWheelMoveV();
    }

    /// <summary>
    /// Set mouse cursor
    /// </summary>
    /// <param name="cursor">The mouse cursor to set</param>
    public static void SetMouseCursor(MouseCursor cursor)
    {
        Raylib.SetMouseCursor(cursor);
    }

    /// <summary>
    /// Get touch position X for touch point 0 (relative to screen size)
    /// </summary>
    /// <returns>The touch position X for touch point 0 (relative to screen size)</returns>
    public static int GetTouchX()
    {
        return Raylib.GetTouchX();
    }

    /// <summary>
    /// Get touch position Y for touch point 0 (relative to screen size)
    /// </summary>
    /// <returns>The touch position Y for touch point 0 (relative to screen size)</returns>
    public static int GetTouchY()
    {
        return Raylib.GetTouchY();
    }

    /// <summary>
    /// Get touch position XY for a touch point index (relative to screen size)
    /// </summary>
    /// <param name="index">The index of the touch point</param>
    /// <returns>The touch position XY for the specified touch point index (relative to screen size)</returns>
    public static Vector2 GetTouchPosition(int index)
    {
        return Raylib.GetTouchPosition(index);
    }

    /// <summary>
    /// Get touch point identifier for given index
    /// </summary>
    /// <param name="index">The index of the touch point</param>
    /// <returns>The identifier of the touch point for the specified index</returns>
    public static int GetTouchPointId(int index)
    {
        return Raylib.GetTouchPointId(index);
    }

    /// <summary>
    /// Get number of touch points
    /// </summary>
    /// <returns>The number of touch points</returns>
    public static int GetTouchPointCount()
    {
        return Raylib.GetTouchPointCount();
    }

    /// <summary>
    /// Enable a set of gestures using flags
    /// </summary>
    /// <param name="flags">The flags representing the gestures to enable</param>
    public static void SetGesturesEnabled(Gesture flags)
    {
        Raylib.SetGesturesEnabled(flags);
    }

    /// <summary>
    /// Check if a gesture have been detected
    /// </summary>
    /// <param name="gesture">The gesture to check</param>
    /// <returns>True if the gesture has been detected, false otherwise</returns>
    public static bool IsGestureDetected(Gesture gesture)
    {
        return Raylib.IsGestureDetected(gesture);
    }

    /// <summary>
    /// Get latest detected gesture
    /// </summary>
    /// <returns>The latest detected gesture</returns>
    public static Gesture GetGestureDetected()
    {
        return Raylib.GetGestureDetected();
    }

    /// <summary>
    /// Get gesture hold time in milliseconds
    /// </summary>
    /// <returns>The gesture hold time in milliseconds</returns>
    public static float GetGestureHoldDuration()
    {
        return Raylib.GetGestureHoldDuration();
    }

    /// <summary>
    /// Get gesture drag vector
    /// </summary>
    /// <returns>The gesture drag vector</returns>
    public static Vector2 GetGestureDragVector()
    {
        return Raylib.GetGestureDragVector();
    }

    /// <summary>
    /// Get gesture drag angle
    /// </summary>
    /// <returns>The gesture drag angle</returns>
    public static float GetGestureDragAngle()
    {
        return Raylib.GetGestureDragAngle();
    }

    /// <summary>
    /// Get gesture pinch delta
    /// </summary>
    /// <returns>The gesture pinch delta</returns>
    public static Vector2 GetGesturePinchVector()
    {
        return Raylib.GetGesturePinchVector();
    }

    /// <summary>
    /// Get gesture pinch angle
    /// </summary>
    /// <returns>The gesture pinch angle</returns>
    public static float GetGesturePinchAngle()
    {
        return Raylib.GetGesturePinchAngle();
    }
}