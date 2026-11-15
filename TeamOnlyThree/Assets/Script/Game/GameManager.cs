using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static float playerHp = 100f;
    public static float bossHp = 500f;

    [Header("결과 UI 패널 연결")]
    public GameObject victoryUI; // 승리 UI
    public GameObject defeatUI;  // 패배 UI

    private bool isGameEnd = false;

    void Start()
    {
        // 게임 시작/재시작 시 초기화
        Time.timeScale = 1f;
        isGameEnd = false;
        playerHp = 100f;
        bossHp = 500f;
    }

    void Update()
    {
        if (isGameEnd) return;

        // 매 틱(프레임)마다 체력 확인
        if (playerHp <= 0 || bossHp <= 0)
        {
            GameEnd();
        }
    }

    void GameEnd()
    {
        isGameEnd = true;
        Time.timeScale = 0f;

        // 판정에 맞는 UI 활성화
        if (bossHp <= 0)
        {
            victoryUI.SetActive(true); // 보스 사망 -> 승리
        }
        else
        {
            defeatUI.SetActive(true);  // 플레이어 사망 -> 패배
        }
    }
}
