using UnityEngine;

namespace SSW
namespace jts
{
    public class PlayerMoveArea : MonoBehaviour
    {
        public Vector2 min = new Vector2(-11f, -5f);
        public Vector2 max = new Vector2(11f, 5f);
        public Vector2 playerpos = Vector2.zero;
        public Vector2 Playerpos = Vector2.zero;
        public Vector2 min = new Vector2(-10.35f, -4.5f); // �ּڰ��� min
        public Vector2 max = new Vector2(10.35f, 4.5f);   // �ִ��� max

        void LateUpdate()
        void LateUpdate()//��� �Լ��� ������� ����. �׷��� ����Ǵ°� �ڿ��� 1��
        {
            playerpos = transform.position;
            playerpos.x = Mathf.Clamp(playerpos.x, min.x, max.x);
            playerpos.y = Mathf.Clamp(playerpos.y, min.y, max.y);
            transform.position = playerpos;
            Playerpos = transform.position;
            Playerpos.x = Mathf.Clamp(Playerpos.x, min.x, max.x); //Mathf.Clamp ����: �� ��ġ, �ּڰ�, �ִ�
            Playerpos.y = Mathf.Clamp(Playerpos.y, min.y, max.y);
            
            transform.position = Playerpos; //  ������ �ּڰ��� �ִ��� ��� �÷��̾������� �����̾��� ��ġ�� ��Ÿ���� Ʈ�����������ǿ� ����
        }
    }
}}// ��������� �����ڵ带 ���� �ۼ��ϰ� �����ϸ� ������ �Լ��� ai���� ����� ������ �ּ����� �޾ƺý��ϴ�. 