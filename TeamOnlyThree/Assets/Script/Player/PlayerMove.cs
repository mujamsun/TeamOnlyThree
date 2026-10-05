using UnityEngine;
using UnityEngine.InputSystem;
namespace KIM
{
    
    

    public class PlayerMove : MonoBehaviour
    {
        [Header("이동속도 설정")]

        public float speed = 5f;

        void Update()
        {
            // 키보드가 연결되어 있지 않을 때 발생하는 에러 방지
            if (Keyboard.current == null) return;


            float deltaM = speed * Time.deltaTime;


            Vector2 moveDelta = Vector2.zero;

            // [W] 키
            if (Keyboard.current.wKey.isPressed)
            {
                moveDelta.y += deltaM;
            }

            // [S] 키
            if (Keyboard.current.sKey.isPressed)
            {
                moveDelta.y -= deltaM;
            }

            // [A] 키
            if (Keyboard.current.aKey.isPressed)
            {
                moveDelta.x -= deltaM;
            }

            // [D] 키
            if (Keyboard.current.dKey.isPressed)
            {
                moveDelta.x += deltaM;
            }


            transform.Translate(moveDelta);
        }
    }
}