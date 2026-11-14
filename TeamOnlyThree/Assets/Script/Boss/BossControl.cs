using UnityEngine;
using KIM;

public class BossControl : MonoBehaviour
{
    [SerializeField] private float minX = -4f;

    [SerializeField] private float maxX = 4f;

    [SerializeField] private float targetX = 0f;

    [SerializeField] private float bossMoveSpeedOrigin = 5f;

    [SerializeField] private float bossMoveSpeed = 0f;

    [SerializeField] private bool isMove = false;

    public void BossMovemont()
    {
        //Vector3 pos = transform.position;
        targetX = Random.Range(minX, maxX);
        //if (targetX < pos.x)
        //{
        //    bossMoveSpeed = -1f * bossMoveSpeedOrigin * Time.deltaTime;
        //}
        //if (targetX > pos.x)
        //{
        //    bossMoveSpeed = bossMoveSpeedOrigin * Time.deltaTime;
        //}
        //if (targetX == pos.x)
        //{
        //    BossMovemont();
        //}
        isMove = true;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BossMovemont();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMove) return;

        Vector3 pos = transform.position;

        pos.x = Mathf.MoveTowards(pos.x, targetX, bossMoveSpeedOrigin * Time.deltaTime);
        transform.position = pos;

        if (Mathf.Approximately(pos.x, targetX))   // 도착 {Mathf.Approximately(n, m) n과 m에서 아주 작은 오차는 같다고 봐 줘요.}
        {
            isMove = false;
            GetComponent<BossPatternVerticalBeam>().StartBossPatternVerticalBeam();
        }

        //if (targetX > 0)
        //{
        //    if (targetX <= pos.x)
        //    {
        //        pos.x = targetX;
        //        isMove = false;
        //        GetComponent<BossPatternVerticalBeam>().StartBossPatternVerticalBeam();
        //    }
        //}
        //if (targetX < 0)
        //{
        //    if (targetX >= pos.x)
        //    {
        //        pos.x = targetX;
        //        isMove = false;
        //        GetComponent<BossPatternVerticalBeam>().StartBossPatternVerticalBeam();
        //    }
        //}
        //if (targetX == 0)
        //{
        //    if (bossMoveSpeed < 0)
        //    {
        //        if (targetX >= pos.x)
        //        {
        //            pos.x = targetX;
        //            isMove = false;
        //            GetComponent<BossPatternVerticalBeam>().StartBossPatternVerticalBeam();
        //        }
        //    }
        //    if (bossMoveSpeed > 0)
        //    {
        //        if (targetX <= pos.x)
        //        {
        //            pos.x = targetX;
        //            isMove = false;
        //            GetComponent<BossPatternVerticalBeam>().StartBossPatternVerticalBeam();
        //        }
        //    }
        //}
        //pos.x += bossMoveSpeed;
        //transform.position = pos;
    }
}

