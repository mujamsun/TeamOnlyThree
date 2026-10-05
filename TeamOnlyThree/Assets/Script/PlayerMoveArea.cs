using UnityEngine;

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
            speed = 0;
            return;
        }

        if (minX > playerpos.x)
        {
            speed = 0;
            return;
        }

        if (maxY < playerpos.y)
        {
            speed = 0;
            return;
        }

        if (minY > playerpos.y)
        {
            speed = 0;
            return;
        }
    }
}
