using UnityEngine;

namespace Unity2DBasics
{
    public static class BoxCollider2DHelper
    {
        public static Rect toRect(BoxCollider2D boxCollider)
        {
            Transform transform = boxCollider.transform;
            Vector2 position = boxCollider.transform.position;
            Vector2 scale = boxCollider.transform.localScale;
            float x;
            if (transform.localEulerAngles.y == 0)
                x = position.x + boxCollider.offset.x * scale.x - boxCollider.size.x / 2 * scale.x;
            else
                x = position.x - boxCollider.offset.x * scale.x - boxCollider.size.x / 2 * scale.x;

            float y = position.y + boxCollider.offset.y * scale.y - boxCollider.size.y / 2 * scale.y;

            return new Rect(x, y, boxCollider.size.x * scale.x, boxCollider.size.y * scale.y);
        }
    }
}