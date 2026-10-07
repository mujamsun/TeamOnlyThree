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


            Vector2 inputDir = Vector2.zero;

            // [W] 키 또는 [위쪽 화살표] 키
            if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
            {
                inputDir.y += 1f;
            }

            // [S] 키 또는 [아래쪽 화살표] 키
            if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
            {
                inputDir.y -= 1f;
            }

            // [A] 키 또는 [왼쪽 화살표] 키
            if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
            {
                inputDir.x -= 1f;
            }

            // [D] 키 또는 [오른쪽 화살표] 키
            if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
            {
                inputDir.x += 1f;
            }


            Vector2 moveDir = inputDir.normalized;


            Vector2 moveDelta = moveDir * (speed * Time.deltaTime);


            transform.Translate(moveDelta);
        }
    }
}