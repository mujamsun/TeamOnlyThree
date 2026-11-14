using KIM;
using System.Collections;
using UnityEngine;

namespace SSW
{
    // 보스의 반복을 맡아요: 이동 -> 패턴 -> 이동 -> 패턴 ...
    // 기존 BossMove와 BossPattern01이 서로를 부르는 구조는 이걸로 대신해요.
    public class BossController : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;
        [SerializeField] private float minX;
        [SerializeField] private float maxX;

       
    }
}
