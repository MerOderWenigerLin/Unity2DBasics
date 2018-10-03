using UnityEngine;

namespace Unity2DBasics
{
    public static class DebugHelper
    {
        public static void drawPoint(Vector2 point, Color color)
        {
            Debug.DrawRay(point, Vector2.up, color);
            Debug.DrawRay(point, Vector2.down, color);
            Debug.DrawRay(point, Vector2.right, color);
            Debug.DrawRay(point, Vector2.left, color);
        }

        public static void drawRectPoints(Rect rect, Color color)
        {
            drawPoint(rect.position, color);
            rect.y = rect.yMax;
            drawPoint(rect.position, color);
            rect.x = rect.xMax;
            drawPoint(rect.position, color);
            rect.y = rect.y - rect.height;
            drawPoint(rect.position, color);
        }
    }
}
