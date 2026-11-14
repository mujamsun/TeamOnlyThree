using KIM;
using UnityEngine;

namespace SSW
{
    public class BossMove : MonoBehaviour
    {
        [SerializeField] private float minY = -4f;   // 랜덤 범위 최소값
        [SerializeField] private float maxY = 4f;    // 랜덤 범위 최대값
        [SerializeField] private float speed = 3f;   // 초당 이동량

        private float targetY;
        private float direction;   // +1 위로, -1 아래로
        private bool isMoving;

        // 이 함수를 호출하면 새 목표 Y를 뽑고 이동 시작
        public void BossMovemont()
    {
        targetY = Random.Range(minY, maxY);
        direction = Mathf.Sign(targetY - transform.position.y);
        isMoving = true;
    }

    private void Update()
        {
            if (!isMoving) return;

            Vector3 pos = transform.position;           // X, Z는 그대로 유지
            pos.y += direction * speed * Time.deltaTime;

            // 목표에 도달했거나 넘어섰는지 확인
            bool reached = (direction > 0 && pos.y >= targetY) ||
                           (direction < 0 && pos.y <= targetY);

            if (reached)
            {
                pos.y = targetY;        // 목표 위치로 고정
                transform.position = pos;
                isMoving = false;
                // GetComponent<BossPatternVerticalBeam>().Pattern01();
                return;
            }

            transform.position = pos;
        }
    }
}
