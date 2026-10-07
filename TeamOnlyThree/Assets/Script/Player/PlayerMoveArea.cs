using KIM;
using UnityEngine;

namespace JTS
{
    public class PlayerMoveArea : MonoBehaviour
    {
        public float minX = -11f;
        public float maxX = 11f;
        public float minY = -5f;
        public float maxY = 5f;
        public Vector2 playerpos;

        void Update()
        {
            playerpos = transform.position;
            if (maxX < playerpos.x)
            {
                GetComponent<PlayerMove>().speed = 0f;
                return;
            }

            if (minX > playerpos.x)
            {
                GetComponent<PlayerMove>().speed = 0f;
                return;
            }

            if (maxY < playerpos.y)
            {
                GetComponent<PlayerMove>().speed = 0f;
                return;
            }

            if (minY > playerpos.y)
            {
                GetComponent<PlayerMove>().speed = 0f;
                return;
            }
        }
    }
}