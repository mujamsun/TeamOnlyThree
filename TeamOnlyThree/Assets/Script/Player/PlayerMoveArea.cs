using UnityEngine;

namespace SSW
{
    public class PlayerMoveArea : MonoBehaviour
    {
        public Vector2 min = new Vector2(-10.35f, -4.5f);
        public Vector2 max = new Vector2(10.35f, 4.5f);
        public Vector2 playerpos = Vector2.zero;

        void LateUpdate()
        {
            playerpos = transform.position;
            playerpos.x = Mathf.Clamp(playerpos.x, min.x, max.x);
            playerpos.y = Mathf.Clamp(playerpos.y, min.y, max.y);
            transform.position = playerpos;
        }
    }
}