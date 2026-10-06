using UnityEngine;

public class playermove : MonoBehaviour
{
    public float speed = 5f;
    Vector2 moveDelta = Vector2.zero;

    void Update()
    {
        float deltaM = speed * Time.deltaTime;

        // 패키지 설치 없이 유니티 기본 기능으로 D키 입력 체크
        if (Input.GetKey(KeyCode.D))
        {
            moveDelta.x += deltaM;
            // 실제로 오브젝트를 움직이려면:
            transform.Translate(Vector3.right * deltaM);
        }
    }
}