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
            playerpos.x = maxX; 
        }

        if (minX > playerpos.x)
        {
            playerpos.x = minX;
        }

        if (maxY < playerpos.y)
        {
            playerpos.y = maxY;
        }

        if (minY > playerpos.y)
        {
            playerpos.y = minY;
        }
    }
}
