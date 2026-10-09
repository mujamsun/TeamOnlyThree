using System.Collections;
using UnityEngine;
using JTS;

namespace KIM
{
    public class BossPattern01 : MonoBehaviour
    {

        public GameObject warningLaser; // 예비 레이저 오브젝트
        public GameObject actualLaser;  // 진짜 레이저 오브젝트

        public float warningTime = 1.5f; // 예비 레이저 시간 (1.5초)
        public float fireTime = 1.5f;    // 레이저 발사 시간 (1.5초)
        public float coolTime = 3.0f;    // 다음 공격까지 쉴 시간

        void Start()
        {
            warningLaser.SetActive(false);
            actualLaser.SetActive(false);
        }

        public void Pattern01()
        {
            // 1. 예비 레이저 1.5초 켜기
            warningLaser.SetActive(true);
            new WaitForSeconds(warningTime);
            warningLaser.SetActive(false);

            // 2. 진짜 레이저 1.5초 켜기
            actualLaser.SetActive(true);
            new WaitForSeconds(fireTime);
            actualLaser.SetActive(false);

            // 3. 보스 이동 호출
            GetComponent<BossMove>().BossMovemont();
        }
    }
}