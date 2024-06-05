using Raylib_cs;
using System.Numerics;
using RaylibMaterial = Raylib_cs.Material;

namespace Pina.Core;

public static class Graphics
{
    /// <summary>
    /// Set texture and rectangle to be used on shapes drawing
    /// </summary>
    /// <param name="texture">The texture</param>
    /// <param name="source">The rectangle source</param>
    public static void SetShapesTexture(Texture2D texture, Rectangle source)
    {
        Raylib.SetShapesTexture(texture, source);
    }

    /// <summary>
    /// Set background color (framebuffer clear color)
    /// </summary>
    /// <param name="color">The color</param>
    public static void ClearBackground(Color color)
    {
        Raylib.ClearBackground(color);
    }

    /// <summary>
    /// Setup canvas (framebuffer) to start drawing
    /// </summary>
    public static void BeginDrawing()
    {
        Raylib.BeginDrawing();
    }

    /// <summary>
    /// End canvas drawing and swap buffers (double buffering)
    /// </summary>
    public static void EndDrawing()
    {
        Raylib.EndDrawing();
    }

    /// <summary>
    /// Begin 2D mode with custom camera (2D)
    /// </summary>
    /// <param name="camera">The camera</param>
    public static void BeginMode2D(Camera2D camera)
    {
        Raylib.BeginMode2D(camera);
    }

    /// <summary>
    /// Ends 2D mode with custom camera
    /// </summary>
    public static void EndMode2D()
    {
        Raylib.EndMode2D();
    }

    /// <summary>
    /// Begin 3D mode with custom camera (3D)
    /// </summary>
    /// <param name="camera">The camera</param>
    public static void BeginMode3D(Camera3D camera)
    {
        Raylib.BeginMode3D(camera);
    }

    /// <summary>
    /// Ends 3D mode and returns to default 2D orthographic mode
    /// </summary>
    public static void EndMode3D()
    {
        Raylib.EndMode3D();
    }

    /// <summary>
    /// Begin drawing to render texture
    /// </summary>
    /// <param name="target"></param>
    public static void BeginTextureMode(RenderTexture2D target)
    {
        Raylib.BeginTextureMode(target);
    }

    /// <summary>
    /// Ends drawing to render texture
    /// </summary>
    public static void EndTextureMode()
    {
        Raylib.EndTextureMode();
    }

    /// <summary>
    /// Begin custom shader drawing
    /// </summary>
    /// <param name="shader">The shader</param>
    public static void BeginShaderMode(Shader shader)
    {
        Raylib.BeginShaderMode(shader);
    }

    /// <summary>
    /// End custom shader drawing (use default shader)
    /// </summary>
    public static void EndShaderMode()
    {
        Raylib.EndShaderMode();
    }

    /// <summary>
    /// Begin blending mode (alpha, additive, multiplied, subtract, custom)
    /// </summary>
    /// <param name="blendMode">The blend mode</param>
    public static void BeginBlendMode(BlendMode blendMode)
    {
        Raylib.BeginBlendMode(blendMode);
    }

    /// <summary>
    /// End blending mode (reset to default: alpha blending)
    /// </summary>
    public static void EndBlendMode()
    {
        Raylib.EndBlendMode();
    }

    /// <summary>
    /// Begin scissor mode (define screen area for following drawing)
    /// </summary>
    public static void BeginScissorMode(int x, int y, int width, int height)
    {
        Raylib.BeginScissorMode(x, y, width, height);
    }

    /// <summary>
    /// End scissor mode
    /// </summary>
    public static void EndScissorMode()
    {
        Raylib.EndScissorMode();
    }

    /// <summary>
    /// Begin stereo rendering (requires VR simulator)
    /// </summary>
    /// <param name="vrStereoConfig">The vr stereo config</param>
    public static void BeginVrStereoMode(VrStereoConfig vrStereoConfig)
    {
        Raylib.BeginVrStereoMode(vrStereoConfig);
    }

    /// <summary>
    /// End stereo rendering (requires VR simulator)
    /// </summary>
    public static void EndVrStereoMode()
    {
        Raylib.EndVrStereoMode();
    }

    /// <summary>
    /// Draw a pixel
    /// </summary>
    /// <param name="posX">The X position</param>
    /// <param name="posY">The Y position</param>
    /// <param name="color">The color</param>
    public static void DrawPixel(int posX, int posY, Color color)
    {
        Raylib.DrawPixel(posX, posY, color);
    }

    /// <summary>
    /// Draw a pixel (Vector version)
    /// </summary>
    /// <param name="position">The position</param>
    /// <param name="color">The color</param>
    public static void DrawPixelV(Vector2 position, Color color)
    {
        Raylib.DrawPixelV(position, color);
    }

    /// <summary>
    /// Draw a line
    /// </summary>
    /// <param name="startPosX">The start X position</param>
    /// <param name="startPosY">The start Y position</param>
    /// <param name="endPosX">The end X position</param>
    /// <param name="endPosY">The end Y position</param>
    /// <param name="color">The color</param>
    public static void DrawLine(int startPosX, int startPosY, int endPosX, int endPosY, Color color)
    {
        Raylib.DrawLine(startPosX, startPosY, endPosX, endPosY, color);
    }

    /// <summary>
    /// Draw a line (using gl lines)
    /// </summary>
    /// <param name="startPos">The start position</param>
    /// <param name="endPos">The end position</param>
    /// <param name="color">The color</param>
    public static void DrawLineV(Vector2 startPos, Vector2 endPos, Color color)
    {
        Raylib.DrawLineV(startPos, endPos, color);
    }

    /// <summary>
    /// Draw a line (using triangles/quads)
    /// </summary>
    /// <param name="startPos">The start position</param>
    /// <param name="endPos">The end position</param>
    /// <param name="thick">The line thickness</param>
    /// <param name="color">The color</param>
    public static void DrawLineEx(Vector2 startPos, Vector2 endPos, float thick, Color color)
    {
        Raylib.DrawLineEx(startPos, endPos, thick, color);
    }

    /// <summary>
    /// Draw lines sequence (using gl lines)
    /// </summary>
    /// <param name="points">The points</param>
    /// <param name="pointCount">The point count</param>
    /// <param name="color">The color</param>
    public static void DrawLineStrip(Vector2[] points, int pointCount, Color color)
    {
        Raylib.DrawLineStrip(points, pointCount, color);
    }

    /// <summary>
    /// Draw line segment cubic-bezier in-out interpolation
    /// </summary>
    /// <param name="startPos">The start position</param>
    /// <param name="endPos">The end position</param>
    /// <param name="thick">The line thickness</param>
    /// <param name="color">The color</param>
    public static void DrawLineBezier(Vector2 startPos, Vector2 endPos, float thick, Color color)
    {
        Raylib.DrawLineBezier(startPos, endPos, thick, color);
    }

    /// <summary>
    /// Draw a color-filled circle
    /// </summary>
    /// <param name="centerX">The X center</param>
    /// <param name="centerY">The Y center</param>
    /// <param name="radius">The radius</param>
    /// <param name="color">The color</param>
    public static void DrawCircle(int centerX, int centerY, float radius, Color color)
    {
        Raylib.DrawCircle(centerX, centerY, radius, color);
    }

    /// <summary>
    /// Draw a piece of a circle
    /// </summary>
    /// <param name="center">The center</param>
    /// <param name="radius">The radius</param>
    /// <param name="startAngle">The start angle</param>
    /// <param name="endAngle">The end angle</param>
    /// <param name="segments">The number of segments</param>
    /// <param name="color">The color</param>
    public static void DrawCircleSector(Vector2 center, float radius, float startAngle, float endAngle, int segments, Color color)
    {
        Raylib.DrawCircleSector(center, radius, startAngle, endAngle, segments, color);
    }

    /// <summary>
    /// Draw circle sector outline
    /// </summary>
    /// <param name="center">The center</param>
    /// <param name="radius">The radius</param>
    /// <param name="startAngle">The start angle</param>
    /// <param name="endAngle">The end angle</param>
    /// <param name="segments">The number of segments</param>
    /// <param name="color">The color</param>
    public static void DrawCircleSectorLines(Vector2 center, float radius, float startAngle, float endAngle, int segments, Color color)
    {
        Raylib.DrawCircleSectorLines(center, radius, startAngle, endAngle, segments, color);
    }

    /// <summary>
    /// Draw a gradient-filled circle
    /// </summary>
    /// <param name="centerX">The X center</param>
    /// <param name="centerY">The Y center</param>
    /// <param name="radius">The radius</param>
    /// <param name="color1">The start color</param>
    /// <param name="color2">The end color</param>
    public static void DrawCircleGradient(int centerX, int centerY, float radius, Color color1, Color color2)
    {
        Raylib.DrawCircleGradient(centerX, centerY, radius, color1, color2);
    }

    /// <summary>
    /// Draw a color-filled circle (Vector version)
    /// </summary>
    /// <param name="center">The center</param>
    /// <param name="radius">The radius</param>
    /// <param name="color">The color</param>
    public static void DrawCircleV(Vector2 center, float radius, Color color)
    {
        Raylib.DrawCircleV(center, radius, color);
    }

    /// <summary>
    /// Draw circle outline
    /// </summary>
    /// <param name="centerX">The X center</param>
    /// <param name="centerY">The Y center</param>
    /// <param name="radius">The radius</param>
    /// <param name="color">The color</param>
    public static void DrawCircleLines(int centerX, int centerY, float radius, Color color)
    {
        Raylib.DrawCircleLines(centerX, centerY, radius, color);
    }

    /// <summary>
    /// Draw circle outline (Vector version)
    /// </summary>
    /// <param name="center">The center</param>
    /// <param name="radius">The radius</param>
    /// <param name="color">The color</param>
    public static void DrawCircleLinesV(Vector2 center, float radius, Color color)
    {
        Raylib.DrawCircleLinesV(center, radius, color);
    }

    /// <summary>
    /// Draw ellipse
    /// </summary>
    /// <param name="centerX">The X center</param>
    /// <param name="centerY">The Y center</param>
    /// <param name="radiusH">The horizontal radius</param>
    /// <param name="radiusV">The vertical radius</param>
    /// <param name="color">The color</param>
    public static void DrawEllipse(int centerX, int centerY, float radiusH, float radiusV, Color color)
    {
        Raylib.DrawEllipse(centerX, centerY, radiusH, radiusV, color);
    }

    /// <summary>
    /// Draw ellipse outline
    /// </summary>
    /// <param name="centerX">The X center</param>
    /// <param name="centerY">The Y center</param>
    /// <param name="radiusH">The horizontal radius</param>
    /// <param name="radiusV">The vertical radius</param>
    /// <param name="color">The color</param>
    public static void DrawEllipseLines(int centerX, int centerY, float radiusH, float radiusV, Color color)
    {
        Raylib.DrawEllipseLines(centerX, centerY, radiusH, radiusV, color);
    }

    /// <summary>
    /// Draw ring
    /// </summary>
    /// <param name="center">The center</param>
    /// <param name="innerRadius">The inner radius</param>
    /// <param name="outerRadius">The outer radius</param>
    /// <param name="startAngle">The start angle</param>
    /// <param name="endAngle">The end angle</param>
    /// <param name="segments">The number of segments</param>
    /// <param name="color">The color</param>
    public static void DrawRing(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color)
    {
        Raylib.DrawRing(center, innerRadius, outerRadius, startAngle, endAngle, segments, color);
    }

    /// <summary>
    /// Draw ring outline
    /// </summary>
    /// <param name="center">The center</param>
    /// <param name="innerRadius">The inner radius</param>
    /// <param name="outerRadius">The outer radius</param>
    /// <param name="startAngle">The start angle</param>
    /// <param name="endAngle">The end angle</param>
    /// <param name="segments">The number of segments</param>
    /// <param name="color">The color</param>
    public static void DrawRingLines(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color)
    {
        Raylib.DrawRingLines(center, innerRadius, outerRadius, startAngle, endAngle, segments, color);
    }

    /// <summary>
    /// Draw a color-filled rectangle
    /// </summary>
    /// <param name="posX">The X position</param>
    /// <param name="posY">The Y position</param>
    /// <param name="width">The width</param>
    /// <param name="height">The height</param>
    /// <param name="color">The color</param>
    public static void DrawRectangle(int posX, int posY, int width, int height, Color color)
    {
        Raylib.DrawRectangle(posX, posY, width, height, color);
    }

    /// <summary>
    /// Draw a color-filled rectangle (Vector version)
    /// </summary>
    /// <param name="position">The position</param>
    /// <param name="size">The size</param>
    /// <param name="color">The color</param>
    public static void DrawRectangleV(Vector2 position, Vector2 size, Color color)
    {
        Raylib.DrawRectangleV(position, size, color);
    }

    /// <summary>
    /// Draw a color-filled rectangle
    /// </summary>
    /// <param name="rec">The rectangle</param>
    /// <param name="color">The color</param>
    public static void DrawRectangleRec(Rectangle rec, Color color)
    {
        Raylib.DrawRectangleRec(rec, color);
    }

    /// <summary>
    /// Draw a color-filled rectangle with pro parameters
    /// </summary>
    /// <param name="rec">The rectangle</param>
    /// <param name="origin">The origin</param>
    /// <param name="rotation">The rotation</param>
    /// <param name="color">The color</param>
    public static void DrawRectanglePro(Rectangle rec, Vector2 origin, float rotation, Color color)
    {
        Raylib.DrawRectanglePro(rec, origin, rotation, color);
    }

    /// <summary>
    /// Draw a vertical-gradient-filled rectangle
    /// </summary>
    /// <param name="posX">The X position</param>
    /// <param name="posY">The Y position</param>
    /// <param name="width">The width</param>
    /// <param name="height">The height</param>
    /// <param name="color1">The start color</param>
    /// <param name="color2">The end color</param>
    public static void DrawRectangleGradientV(int posX, int posY, int width, int height, Color color1, Color color2)
    {
        Raylib.DrawRectangleGradientV(posX, posY, width, height, color1, color2);
    }

    /// <summary>
    /// Draw a horizontal-gradient-filled rectangle
    /// </summary>
    /// <param name="posX">The X position</param>
    /// <param name="posY">The Y position</param>
    /// <param name="width">The width</param>
    /// <param name="height">The height</param>
    /// <param name="color1">The start color</param>
    /// <param name="color2">The end color</param>
    public static void DrawRectangleGradientH(int posX, int posY, int width, int height, Color color1, Color color2)
    {
        Raylib.DrawRectangleGradientH(posX, posY, width, height, color1, color2);
    }

    /// <summary>
    /// Draw a gradient-filled rectangle with custom vertex colors
    /// </summary>
    /// <param name="rec">The rectangle</param>
    /// <param name="col1">The top-left color</param>
    /// <param name="col2">The top-right color</param>
    /// <param name="col3">The bottom-right color</param>
    /// <param name="col4">The bottom-left color</param>
    public static void DrawRectangleGradientEx(Rectangle rec, Color col1, Color col2, Color col3, Color col4)
    {
        Raylib.DrawRectangleGradientEx(rec, col1, col2, col3, col4);
    }

    /// <summary>
    /// Draw rectangle outline
    /// </summary>
    /// <param name="posX">The X position</param>
    /// <param name="posY">The Y position</param>
    /// <param name="width">The width</param>
    /// <param name="height">The height</param>
    /// <param name="color">The color</param>
    public static void DrawRectangleLines(int posX, int posY, int width, int height, Color color)
    {
        Raylib.DrawRectangleLines(posX, posY, width, height, color);
    }

    /// <summary>
    /// Draw rectangle outline with extended parameters
    /// </summary>
    /// <param name="rec">The rectangle</param>
    /// <param name="lineThick">The line thickness</param>
    /// <param name="color">The color</param>
    public static void DrawRectangleLinesEx(Rectangle rec, float lineThick, Color color)
    {
        Raylib.DrawRectangleLinesEx(rec, lineThick, color);
    }

    /// <summary>
    /// Draw rectangle with rounded edges
    /// </summary>
    /// <param name="rec">The rectangle</param>
    /// <param name="roundness">The roundness</param>
    /// <param name="segments">The number of segments</param>
    /// <param name="color">The color</param>
    public static void DrawRectangleRounded(Rectangle rec, float roundness, int segments, Color color)
    {
        Raylib.DrawRectangleRounded(rec, roundness, segments, color);
    }

    /// <summary>
    /// Draw rectangle with rounded edges outline
    /// </summary>
    /// <param name="rec">The rectangle</param>
    /// <param name="roundness">The roundness</param>
    /// <param name="segments">The number of segments</param>
    /// <param name="lineThick">The line thickness</param>
    /// <param name="color">The color</param>
    public static void DrawRectangleRoundedLines(Rectangle rec, float roundness, int segments, float lineThick, Color color)
    {
        Raylib.DrawRectangleRoundedLines(rec, roundness, segments, lineThick, color);
    }

    /// <summary>
    /// Draw a color-filled triangle (vertex in counter-clockwise order!)
    /// </summary>
    /// <param name="v1">The first vertex</param>
    /// <param name="v2">The second vertex</param>
    /// <param name="v3">The third vertex</param>
    /// <param name="color">The color</param>
    public static void DrawTriangle(Vector2 v1, Vector2 v2, Vector2 v3, Color color)
    {
        Raylib.DrawTriangle(v1, v2, v3, color);
    }

    /// <summary>
    /// Draw triangle outline (vertex in counter-clockwise order!)
    /// </summary>
    /// <param name="v1">The first vertex</param>
    /// <param name="v2">The second vertex</param>
    /// <param name="v3">The third vertex</param>
    /// <param name="color">The color</param>
    public static void DrawTriangleLines(Vector2 v1, Vector2 v2, Vector2 v3, Color color)
    {
        Raylib.DrawTriangleLines(v1, v2, v3, color);
    }

    /// <summary>
    /// Draw a triangle fan defined by points (first vertex is the center)
    /// </summary>
    /// <param name="points">The points</param>
    /// <param name="pointCount">The point count</param>
    /// <param name="color">The color</param>
    public static void DrawTriangleFan(Vector2[] points, int pointCount, Color color)
    {
        Raylib.DrawTriangleFan(points, pointCount, color);
    }

    /// <summary>
    /// Draw a triangle strip defined by points
    /// </summary>
    /// <param name="points">The points</param>
    /// <param name="pointCount">The point count</param>
    /// <param name="color">The color</param>
    public static void DrawTriangleStrip(Vector2[] points, int pointCount, Color color)
    {
        Raylib.DrawTriangleStrip(points, pointCount, color);
    }

    /// <summary>
    /// Draw a regular polygon (Vector version)
    /// </summary>
    /// <param name="center">The center</param>
    /// <param name="sides">The number of sides</param>
    /// <param name="radius">The radius</param>
    /// <param name="rotation">The rotation</param>
    /// <param name="color">The color</param>
    public static void DrawPoly(Vector2 center, int sides, float radius, float rotation, Color color)
    {
        Raylib.DrawPoly(center, sides, radius, rotation, color);
    }

    /// <summary>
    /// Draw a polygon outline of n sides
    /// </summary>
    /// <param name="center">The center</param>
    /// <param name="sides">The number of sides</param>
    /// <param name="radius">The radius</param>
    /// <param name="rotation">The rotation</param>
    /// <param name="color">The color</param>
    public static void DrawPolyLines(Vector2 center, int sides, float radius, float rotation, Color color)
    {
        Raylib.DrawPolyLines(center, sides, radius, rotation, color);
    }

    /// <summary>
    /// Draw a polygon outline of n sides with extended parameters
    /// </summary>
    /// <param name="center">The center</param>
    /// <param name="sides">The number of sides</param>
    /// <param name="radius">The radius</param>
    /// <param name="rotation">The rotation</param>
    /// <param name="lineThick">The line thickness</param>
    /// <param name="color">The color</param>
    public static void DrawPolyLinesEx(Vector2 center, int sides, float radius, float rotation, float lineThick, Color color)
    {
        Raylib.DrawPolyLinesEx(center, sides, radius, rotation, lineThick, color);
    }

    /// <summary>
    /// Draw spline: Linear, minimum 2 points
    /// </summary>
    /// <param name="points">The points</param>
    /// <param name="pointCount">The point count</param>
    /// <param name="thick">The line thickness</param>
    /// <param name="color">The color</param>
    public static void DrawSplineLinear(Vector2[] points, int pointCount, float thick, Color color)
    {
        Raylib.DrawSplineLinear(points, pointCount, thick, color);
    }

    /// <summary>
    /// Draw spline: B-Spline, minimum 4 points
    /// </summary>
    /// <param name="points">The points</param>
    /// <param name="pointCount">The point count</param>
    /// <param name="thick">The line thickness</param>
    /// <param name="color">The color</param>
    public static void DrawSplineBasis(Vector2[] points, int pointCount, float thick, Color color)
    {
        Raylib.DrawSplineBasis(points, pointCount, thick, color);
    }

    /// <summary>
    /// Draw spline: Catmull-Rom, minimum 4 points
    /// </summary>
    /// <param name="points">The points</param>
    /// <param name="pointCount">The point count</param>
    /// <param name="thick">The line thickness</param>
    /// <param name="color">The color</param>
    public static void DrawSplineCatmullRom(Vector2[] points, int pointCount, float thick, Color color)
    {
        Raylib.DrawSplineCatmullRom(points, pointCount, thick, color);
    }

    /// <summary>
    /// Draw spline: Quadratic Bezier, minimum 3 points (1 control point): [p1, c2, p3, c4...]
    /// </summary>
    /// <param name="points">The points</param>
    /// <param name="pointCount">The point count</param>
    /// <param name="thick">The line thickness</param>
    /// <param name="color">The color</param>
    public static void DrawSplineBezierQuadratic(Vector2[] points, int pointCount, float thick, Color color)
    {
        Raylib.DrawSplineBezierQuadratic(points, pointCount, thick, color);
    }

    /// <summary>
    /// Draw spline: Cubic Bezier, minimum 4 points (2 control points): [p1, c2, c3, p4, c5, c6...]
    /// </summary>
    /// <param name="points">The points</param>
    /// <param name="pointCount">The point count</param>
    /// <param name="thick">The line thickness</param>
    /// <param name="color">The color</param>
    public static void DrawSplineBezierCubic(Vector2[] points, int pointCount, float thick, Color color)
    {
        Raylib.DrawSplineBezierCubic(points, pointCount, thick, color);
    }

    /// <summary>
    /// Draw spline segment: Linear, 2 points
    /// </summary>
    /// <param name="p1">The first point</param>
    /// <param name="p2">The second point</param>
    /// <param name="thick">The line thickness</param>
    /// <param name="color">The color</param>
    public static void DrawSplineSegmentLinear(Vector2 p1, Vector2 p2, float thick, Color color)
    {
        Raylib.DrawSplineSegmentLinear(p1, p2, thick, color);
    }

    /// <summary>
    /// Draw spline segment: B-Spline, 4 points
    /// </summary>
    /// <param name="p1">The first point</param>
    /// <param name="p2">The second point</param>
    /// <param name="p3">The third point</param>
    /// <param name="p4">The fourth point</param>
    /// <param name="thick">The line thickness</param>
    /// <param name="color">The color</param>
    public static void DrawSplineSegmentBasis(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float thick, Color color)
    {
        Raylib.DrawSplineSegmentBasis(p1, p2, p3, p4, thick, color);
    }

    /// <summary>
    /// Draw spline segment: Catmull-Rom, 4 points
    /// </summary>
    /// <param name="p1">The first point</param>
    /// <param name="p2">The second point</param>
    /// <param name="p3">The third point</param>
    /// <param name="p4">The fourth point</param>
    /// <param name="thick">The line thickness</param>
    /// <param name="color">The color</param>
    public static void DrawSplineSegmentCatmullRom(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float thick, Color color)
    {
        Raylib.DrawSplineSegmentCatmullRom(p1, p2, p3, p4, thick, color);
    }

    /// <summary>
    /// Draw spline segment: Quadratic Bezier, 2 points, 1 control point
    /// </summary>
    /// <param name="p1">The first point</param>
    /// <param name="c2">The control point</param>
    /// <param name="p3">The second point</param>
    /// <param name="thick">The line thickness</param>
    /// <param name="color">The color</param>
    public static void DrawSplineSegmentBezierQuadratic(Vector2 p1, Vector2 c2, Vector2 p3, float thick, Color color)
    {
        Raylib.DrawSplineSegmentBezierQuadratic(p1, c2, p3, thick, color);
    }

    /// <summary>
    /// Draw spline segment: Cubic Bezier, 3 points, 2 control points
    /// </summary>
    /// <param name="p1">The first point</param>
    /// <param name="c2">The first control point</param>
    /// <param name="c3">The second control point</param>
    /// <param name="p4">The second point</param>
    /// <param name="thick">The line thickness</param>
    /// <param name="color">The color</param>
    public static void DrawSplineSegmentBezierCubic(Vector2 p1, Vector2 c2, Vector2 c3, Vector2 p4, float thick, Color color)
    {
        Raylib.DrawSplineSegmentBezierCubic(p1, c2, c3, p4, thick, color);
    }

    /// <summary>
    /// Draw a Texture2D
    /// </summary>
    /// <param name="texture">The texture</param>
    /// <param name="posX">The X position</param>
    /// <param name="posY">The Y position</param>
    /// <param name="tint">The tint color</param>
    public static void DrawTexture(Texture2D texture, int posX, int posY, Color tint)
    {
        Raylib.DrawTexture(texture, posX, posY, tint);
    }

    /// <summary>
    /// Draw a Texture2D with position defined as Vector2
    /// </summary>
    /// <param name="texture">The texture</param>
    /// <param name="position">The position</param>
    /// <param name="tint">The tint color</param>
    public static void DrawTextureV(Texture2D texture, Vector2 position, Color tint)
    {
        Raylib.DrawTextureV(texture, position, tint);
    }

    /// <summary>
    /// Draw a Texture2D with extended parameters
    /// </summary>
    /// <param name="texture">The texture</param>
    /// <param name="position">The position</param>
    /// <param name="rotation">The rotation (in radians)</param>
    /// <param name="scale">The scale factor</param>
    /// <param name="tint">The tint color</param>
    public static void DrawTextureEx(Texture2D texture, Vector2 position, float rotation, float scale, Color tint)
    {
        Raylib.DrawTextureEx(texture, position, rotation, scale, tint);
    }

    /// <summary>
    /// Draw a part of a texture defined by a rectangle
    /// </summary>
    /// <param name="texture">The texture</param>
    /// <param name="source">The source rectangle</param>
    /// <param name="position">The position</param>
    /// <param name="tint">The tint color</param>
    public static void DrawTextureRec(Texture2D texture, Rectangle source, Vector2 position, Color tint)
    {
        Raylib.DrawTextureRec(texture, source, position, tint);
    }

    /// <summary>
    /// Draw a part of a texture defined by a rectangle with 'pro' parameters
    /// </summary>
    /// <param name="texture">The texture</param>
    /// <param name="source">The source rectangle</param>
    /// <param name="dest">The destination rectangle</param>
    /// <param name="origin">The origin of rotation</param>
    /// <param name="rotation">The rotation (in radians)</param>
    /// <param name="tint">The tint color</param>
    public static void DrawTexturePro(Texture2D texture, Rectangle source, Rectangle dest, Vector2 origin, float rotation, Color tint)
    {
        Raylib.DrawTexturePro(texture, source, dest, origin, rotation, tint);
    }

    /// <summary>
    /// Draws a texture (or part of it) that stretches or shrinks nicely
    /// </summary>
    /// <param name="texture">The texture</param>
    /// <param name="nPatchInfo">The NPatchInfo</param>
    /// <param name="dest">The destination rectangle</param>
    /// <param name="origin">The origin of rotation</param>
    /// <param name="rotation">The rotation (in radians)</param>
    /// <param name="tint">The tint color</param>
    public static void DrawTextureNPatch(Texture2D texture, NPatchInfo nPatchInfo, Rectangle dest, Vector2 origin, float rotation, Color tint)
    {
        Raylib.DrawTextureNPatch(texture, nPatchInfo, dest, origin, rotation, tint);
    }

    /// <summary>
    /// Draw current FPS
    /// </summary>
    /// <param name="posX">The X position</param>
    /// <param name="posY">The Y position</param>
    public static void DrawFPS(int posX, int posY)
    {
        Raylib.DrawFPS(posX, posY);
    }

    /// <summary>
    /// Draw text (using default font)
    /// </summary>
    /// <param name="text">The text to draw</param>
    /// <param name="posX">The X position</param>
    /// <param name="posY">The Y position</param>
    /// <param name="fontSize">The font size</param>
    /// <param name="color">The text color</param>
    public static void DrawText(string text, int posX, int posY, int fontSize, Color color)
    {
        Raylib.DrawText(text, posX, posY, fontSize, color);
    }

    /// <summary>
    /// Draw text using font and additional parameters
    /// </summary>
    /// <param name="font">The font</param>
    /// <param name="text">The text to draw</param>
    /// <param name="position">The position</param>
    /// <param name="fontSize">The font size</param>
    /// <param name="spacing">The spacing</param>
    /// <param name="tint">The text tint color</param>
    public static void DrawTextEx(Font font, string text, Vector2 position, float fontSize, float spacing, Color tint)
    {
        Raylib.DrawTextEx(font, text, position, fontSize, spacing, tint);
    }

    /// <summary>
    /// Draw text using Font and pro parameters (rotation)
    /// </summary>
    /// <param name="font">The font</param>
    /// <param name="text">The text to draw</param>
    /// <param name="position">The position</param>
    /// <param name="origin">The origin</param>
    /// <param name="rotation">The rotation (in radians)</param>
    /// <param name="fontSize">The font size</param>
    /// <param name="spacing">The spacing</param>
    /// <param name="tint">The text tint color</param>
    public static void DrawTextPro(Font font, string text, Vector2 position, Vector2 origin, float rotation, float fontSize, float spacing, Color tint)
    {
        Raylib.DrawTextPro(font, text, position, origin, rotation, fontSize, spacing, tint);
    }

    /// <summary>
    /// Draw one character (codepoint)
    /// </summary>
    /// <param name="font">The font</param>
    /// <param name="codepoint">The codepoint</param>
    /// <param name="position">The position</param>
    /// <param name="fontSize">The font size</param>
    /// <param name="tint">The text tint color</param>
    public static void DrawTextCodepoint(Font font, int codepoint, Vector2 position, float fontSize, Color tint)
    {
        Raylib.DrawTextCodepoint(font, codepoint, position, fontSize, tint);
    }

    /// <summary>
    /// Draw multiple characters (codepoints)
    /// </summary>
    /// <param name="font">The font</param>
    /// <param name="codepoints">The array of codepoints</param>
    /// <param name="codepointCount">The number of codepoints</param>
    /// <param name="position">The position</param>
    /// <param name="fontSize">The font size</param>
    /// <param name="spacing">The spacing</param>
    /// <param name="tint">The text tint color</param>
    public unsafe static void DrawTextCodepoints(Font font, int* codepoints, int codepointCount, Vector2 position, float fontSize, float spacing, Color tint)
    {
        Raylib.DrawTextCodepoints(font, codepoints, codepointCount, position, fontSize, spacing, tint);
    }

    /// <summary>
    /// Draw a line in 3D world space
    /// </summary>
    /// <param name="startPos">The start position of the line</param>
    /// <param name="endPos">The end position of the line</param>
    /// <param name="color">The color of the line</param>
    public static void DrawLine3D(Vector3 startPos, Vector3 endPos, Color color)
    {
        Raylib.DrawLine3D(startPos, endPos, color);
    }

    /// <summary>
    /// Draw a point in 3D space, actually a small line
    /// </summary>
    /// <param name="position">The position of the point</param>
    /// <param name="color">The color of the point</param>
    public static void DrawPoint3D(Vector3 position, Color color)
    {
        Raylib.DrawPoint3D(position, color);
    }

    /// <summary>
    /// Draw a circle in 3D world space
    /// </summary>
    /// <param name="center">The center of the circle</param>
    /// <param name="radius">The radius of the circle</param>
    /// <param name="rotationAxis">The rotation axis of the circle</param>
    /// <param name="rotationAngle">The rotation angle of the circle</param>
    /// <param name="color">The color of the circle</param>
    public static void DrawCircle3D(Vector3 center, float radius, Vector3 rotationAxis, float rotationAngle, Color color)
    {
        Raylib.DrawCircle3D(center, radius, rotationAxis, rotationAngle, color);
    }

    /// <summary>
    /// Draw a color-filled triangle in 3D world space
    /// </summary>
    /// <param name="v1">Vertex 1 of the triangle</param>
    /// <param name="v2">Vertex 2 of the triangle</param>
    /// <param name="v3">Vertex 3 of the triangle</param>
    /// <param name="color">The color of the triangle</param>
    public static void DrawTriangle3D(Vector3 v1, Vector3 v2, Vector3 v3, Color color)
    {
        Raylib.DrawTriangle3D(v1, v2, v3, color);
    }

    /// <summary>
    /// Draw a triangle strip defined by points in 3D world space
    /// </summary>
    /// <param name="points">The array of points defining the triangle strip</param>
    /// <param name="pointCount">The number of points in the array</param>
    /// <param name="color">The color of the triangle strip</param>
    public static void DrawTriangleStrip3D(Vector3[] points, int pointCount, Color color)
    {
        Raylib.DrawTriangleStrip3D(points, pointCount, color);
    }

    /// <summary>
    /// Draw a cube in 3D world space
    /// </summary>
    /// <param name="position">The position of the cube</param>
    /// <param name="width">The width of the cube</param>
    /// <param name="height">The height of the cube</param>
    /// <param name="length">The length of the cube</param>
    /// <param name="color">The color of the cube</param>
    public static void DrawCube(Vector3 position, float width, float height, float length, Color color)
    {
        Raylib.DrawCube(position, width, height, length, color);
    }

    /// <summary>
    /// Draw a cube in 3D world space (Vector version)
    /// </summary>
    /// <param name="position">The position of the cube</param>
    /// <param name="size">The size of the cube</param>
    /// <param name="color">The color of the cube</param>
    public static void DrawCubeV(Vector3 position, Vector3 size, Color color)
    {
        Raylib.DrawCubeV(position, size, color);
    }

    /// <summary>
    /// Draw the wires of a cube in 3D world space
    /// </summary>
    /// <param name="position">The position of the cube</param>
    /// <param name="width">The width of the cube</param>
    /// <param name="height">The height of the cube</param>
    /// <param name="length">The length of the cube</param>
    /// <param name="color">The color of the cube wires</param>
    public static void DrawCubeWires(Vector3 position, float width, float height, float length, Color color)
    {
        Raylib.DrawCubeWires(position, width, height, length, color);
    }

    /// <summary>
    /// Draw the wires of a cube in 3D world space (Vector version)
    /// </summary>
    /// <param name="position">The position of the cube</param>
    /// <param name="size">The size of the cube</param>
    /// <param name="color">The color of the cube wires</param>
    public static void DrawCubeWiresV(Vector3 position, Vector3 size, Color color)
    {
        Raylib.DrawCubeWiresV(position, size, color);
    }

    /// <summary>
    /// Draw a sphere in 3D world space
    /// </summary>
    /// <param name="centerPos">The center position of the sphere</param>
    /// <param name="radius">The radius of the sphere</param>
    /// <param name="color">The color of the sphere</param>
    public static void DrawSphere(Vector3 centerPos, float radius, Color color)
    {
        Raylib.DrawSphere(centerPos, radius, color);
    }

    /// <summary>
    /// Draw a sphere in 3D world space with extended parameters
    /// </summary>
    /// <param name="centerPos">The center position of the sphere</param>
    /// <param name="radius">The radius of the sphere</param>
    /// <param name="rings">The number of rings</param>
    /// <param name="slices">The number of slices</param>
    /// <param name="color">The color of the sphere</param>
    public static void DrawSphereEx(Vector3 centerPos, float radius, int rings, int slices, Color color)
    {
        Raylib.DrawSphereEx(centerPos, radius, rings, slices, color);
    }

    /// <summary>
    /// Draw the wires of a sphere in 3D world space
    /// </summary>
    /// <param name="centerPos">The center position of the sphere</param>
    /// <param name="radius">The radius of the sphere</param>
    /// <param name="rings">The number of rings</param>
    /// <param name="slices">The number of slices</param>
    /// <param name="color">The color of the sphere wires</param>
    public static void DrawSphereWires(Vector3 centerPos, float radius, int rings, int slices, Color color)
    {
        Raylib.DrawSphereWires(centerPos, radius, rings, slices, color);
    }

    /// <summary>
    /// Draw a cylinder or cone in 3D world space
    /// </summary>
    /// <param name="position">The position of the cylinder or cone</param>
    /// <param name="radiusTop">The top radius of the cylinder</param>
    /// <param name="radiusBottom">The bottom radius of the cylinder</param>
    /// <param name="height">The height of the cylinder</param>
    /// <param name="slices">The number of sides</param>
    /// <param name="color">The color of the cylinder or cone</param>
    public static void DrawCylinder(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color)
    {
        Raylib.DrawCylinder(position, radiusTop, radiusBottom, height, slices, color);
    }

    /// <summary>
    /// Draw a cylinder with extended parameters in 3D world space
    /// </summary>
    /// <param name="startPos">The position of the base of the cylinder</param>
    /// <param name="endPos">The position of the top of the cylinder</param>
    /// <param name="startRadius">The radius of the base of the cylinder</param>
    /// <param name="endRadius">The radius of the top of the cylinder</param>
    /// <param name="sides">The number of sides</param>
    /// <param name="color">The color of the cylinder</param>
    public static void DrawCylinderEx(Vector3 startPos, Vector3 endPos, float startRadius, float endRadius, int sides, Color color)
    {
        Raylib.DrawCylinderEx(startPos, endPos, startRadius, endRadius, sides, color);
    }

    /// <summary>
    /// Draw the wires of a cylinder or cone in 3D world space
    /// </summary>
    /// <param name="position">The position of the cylinder or cone</param>
    /// <param name="radiusTop">The top radius of the cylinder</param>
    /// <param name="radiusBottom">The bottom radius of the cylinder</param>
    /// <param name="height">The height of the cylinder</param>
    /// <param name="slices">The number of sides</param>
    /// <param name="color">The color of the cylinder or cone wires</param>
    public static void DrawCylinderWires(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color)
    {
        Raylib.DrawCylinderWires(position, radiusTop, radiusBottom, height, slices, color);
    }

    /// <summary>
    /// Draw the wires of a cylinder or cone with extended parameters in 3D world space
    /// </summary>
    /// <param name="startPos">The position of the base of the cylinder</param>
    /// <param name="endPos">The position of the top of the cylinder</param>
    /// <param name="startRadius">The radius of the base of the cylinder</param>
    /// <param name="endRadius">The radius of the top of the cylinder</param>
    /// <param name="sides">The number of sides</param>
    /// <param name="color">The color of the cylinder or cone wires</param>
    public static void DrawCylinderWiresEx(Vector3 startPos, Vector3 endPos, float startRadius, float endRadius, int sides, Color color)
    {
        Raylib.DrawCylinderWiresEx(startPos, endPos, startRadius, endRadius, sides, color);
    }

    /// <summary>
    /// Draw a capsule in 3D world space
    /// </summary>
    /// <param name="startPos">The position of the base of the capsule</param>
    /// <param name="endPos">The position of the top of the capsule</param>
    /// <param name="radius">The radius of the capsule</param>
    /// <param name="slices">The number of sides along the latitude</param>
    /// <param name="rings">The number of sides along the longitude</param>
    /// <param name="color">The color of the capsule</param>
    public static void DrawCapsule(Vector3 startPos, Vector3 endPos, float radius, int slices, int rings, Color color)
    {
        Raylib.DrawCapsule(startPos, endPos, radius, slices, rings, color);
    }

    /// <summary>
    /// Draw the wires of a capsule in 3D world space
    /// </summary>
    /// <param name="startPos">The position of the base of the capsule</param>
    /// <param name="endPos">The position of the top of the capsule</param>
    /// <param name="radius">The radius of the capsule</param>
    /// <param name="slices">The number of sides along the latitude</param>
    /// <param name="rings">The number of sides along the longitude</param>
    /// <param name="color">The color of the capsule wires</param>
    public static void DrawCapsuleWires(Vector3 startPos, Vector3 endPos, float radius, int slices, int rings, Color color)
    {
        Raylib.DrawCapsuleWires(startPos, endPos, radius, slices, rings, color);
    }

    /// <summary>
    /// Draw a plane in 3D world space
    /// </summary>
    /// <param name="centerPos">The center position of the plane</param>
    /// <param name="size">The size of the plane</param>
    /// <param name="color">The color of the plane</param>
    public static void DrawPlane(Vector3 centerPos, Vector2 size, Color color)
    {
        Raylib.DrawPlane(centerPos, size, color);
    }

    /// <summary>
    /// Draw a ray line in 3D world space
    /// </summary>
    /// <param name="ray">The ray to draw</param>
    /// <param name="color">The color of the ray</param>
    public static void DrawRay(Ray ray, Color color)
    {
        Raylib.DrawRay(ray, color);
    }

    /// <summary>
    /// Draw a grid in 3D world space
    /// </summary>
    /// <param name="slices">The number of slices of the grid</param>
    /// <param name="spacing">The spacing between grid lines</param>
    public static void DrawGrid(int slices, float spacing)
    {
        Raylib.DrawGrid(slices, spacing);
    }

    /// <summary>
    /// Draw a model (with texture if set)
    /// </summary>
    /// <param name="model">The model to draw</param>
    /// <param name="position">The position where the model will be drawn</param>
    /// <param name="scale">The scale of the model</param>
    /// <param name="tint">The color tint of the model</param>
    public static void DrawModel(Model model, Vector3 position, float scale, Color tint)
    {
        Raylib.DrawModel(model, position, scale, tint);
    }

    /// <summary>
    /// Draw a model with extended parameters
    /// </summary>
    /// <param name="model">The model to draw</param>
    /// <param name="position">The position where the model will be drawn</param>
    /// <param name="rotationAxis">The rotation axis</param>
    /// <param name="rotationAngle">The rotation angle</param>
    /// <param name="scale">The scale of the model</param>
    /// <param name="tint">The color tint of the model</param>
    public static void DrawModelEx(Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color tint)
    {
        Raylib.DrawModelEx(model, position, rotationAxis, rotationAngle, scale, tint);
    }

    /// <summary>
    /// Draw a model wires (with texture if set)
    /// </summary>
    /// <param name="model">The model to draw</param>
    /// <param name="position">The position where the model will be drawn</param>
    /// <param name="scale">The scale of the model</param>
    /// <param name="tint">The color tint of the model</param>
    public static void DrawModelWires(Model model, Vector3 position, float scale, Color tint)
    {
        Raylib.DrawModelWires(model, position, scale, tint);
    }

    /// <summary>
    /// Draw a model wires (with texture if set) with extended parameters
    /// </summary>
    /// <param name="model">The model to draw</param>
    /// <param name="position">The position where the model will be drawn</param>
    /// <param name="rotationAxis">The rotation axis</param>
    /// <param name="rotationAngle">The rotation angle</param>
    /// <param name="scale">The scale of the model</param>
    /// <param name="tint">The color tint of the model</param>
    public static void DrawModelWiresEx(Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color tint)
    {
        Raylib.DrawModelWiresEx(model, position, rotationAxis, rotationAngle, scale, tint);
    }

    /// <summary>
    /// Draw bounding box (wires)
    /// </summary>
    /// <param name="box">The bounding box to draw</param>
    /// <param name="color">The color of the bounding box</param>
    public static void DrawBoundingBox(BoundingBox box, Color color)
    {
        Raylib.DrawBoundingBox(box, color);
    }

    /// <summary>
    /// Draw a billboard texture
    /// </summary>
    /// <param name="camera">The camera to use for drawing</param>
    /// <param name="texture">The texture to draw</param>
    /// <param name="position">The position where the billboard will be drawn</param>
    /// <param name="size">The size of the billboard</param>
    /// <param name="tint">The color tint of the billboard</param>
    public static void DrawBillboard(Camera3D camera, Texture2D texture, Vector3 position, float size, Color tint)
    {
        Raylib.DrawBillboard(camera, texture, position, size, tint);
    }

    /// <summary>
    /// Draw a billboard texture defined by source
    /// </summary>
    /// <param name="camera">The camera to use for drawing</param>
    /// <param name="texture">The texture to draw</param>
    /// <param name="source">The source rectangle defining the portion of the texture to draw</param>
    /// <param name="position">The position where the billboard will be drawn</param>
    /// <param name="size">The size of the billboard</param>
    /// <param name="tint">The color tint of the billboard</param>
    public static void DrawBillboardRec(Camera3D camera, Texture2D texture, Rectangle source, Vector3 position, Vector2 size, Color tint)
    {
        Raylib.DrawBillboardRec(camera, texture, source, position, size, tint);
    }

    /// <summary>
    /// Draw a billboard texture defined by source and rotation
    /// </summary>
    /// <param name="camera">The camera to use for drawing</param>
    /// <param name="texture">The texture to draw</param>
    /// <param name="source">The source rectangle defining the portion of the texture to draw</param>
    /// <param name="position">The position where the billboard will be drawn</param>
    /// <param name="up">The up vector for billboard orientation</param>
    /// <param name="size">The size of the billboard</param>
    /// <param name="origin">The origin of the rotation</param>
    /// <param name="rotation">The rotation angle</param>
    /// <param name="tint">The color tint of the billboard</param>
    public static void DrawBillboardPro(Camera3D camera, Texture2D texture, Rectangle source, Vector3 position, Vector3 up, Vector2 size, Vector2 origin, float rotation, Color tint)
    {
        Raylib.DrawBillboardPro(camera, texture, source, position, up, size, origin, rotation, tint);
    }

    /// <summary>
    /// Draw a 3D mesh with material and transform
    /// </summary>
    /// <param name="mesh">The mesh to draw</param>
    /// <param name="material">The material of the mesh</param>
    /// <param name="transform">The transformation matrix</param>
    public static void DrawMesh(Mesh mesh, RaylibMaterial material, Matrix4x4 transform)
    {
        Raylib.DrawMesh(mesh, material, transform);
    }

    /// <summary>
    /// Draw multiple mesh instances with material and different transforms
    /// </summary>
    /// <param name="mesh">The mesh to draw</param>
    /// <param name="material">The material of the mesh</param>
    /// <param name="transforms">The array of transformation matrices</param>
    /// <param name="instances">The number of instances to draw</param>
    public unsafe static void DrawMeshInstanced(Mesh mesh, RaylibMaterial material, Matrix4x4* transforms, int instances)
    {
        Raylib.DrawMeshInstanced(mesh, material, transforms, instances);
    }
}