using UnityEngine;
using System.Collections;
using SSW;

namespace KIM
{
    public class BossPatternVerticalBeam : MonoBehaviour
    {

        public GameObject warningLaser;  // 예비 레이저 오브젝트
        public GameObject actualLaser;   // 진짜 레이저 오브젝트

        public float warningTime = 1.5f; // 예비 레이저 시간 (1.5초)
        public float fireTime = 1.5f;    // 레이저 발사 시간 (1.5초)
        public float coolTime = 3.0f;    // 다음 공격까지 쉴 시간

        void Start()
        {
            warningLaser.SetActive(false);
            actualLaser.SetActive(false);
        }

        public void StartBossPatternVerticalBeam()
        {
            StartCoroutine(BossPatternVerticalBeamReal());
        }

        IEnumerator BossPatternVerticalBeamReal()         // ① 반환형이 IEnumerator
        {
            warningLaser.SetActive(true);
            yield return new WaitForSeconds(warningTime); // ② 여기서 1.5초 멈춤
            warningLaser.SetActive(false);

            actualLaser.SetActive(true);
            yield return new WaitForSeconds(fireTime);    // 또 1.5초 멈춤
            actualLaser.SetActive(false);

            // 3. 보스 이동 호출
            GetComponent<BossControl>().BossMovemont();
        }
    }
}