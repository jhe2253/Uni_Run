using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coine2 : MonoBehaviour
{
    public GameObject[] coins;
    private bool stepped = false;

    private void OnEnable()

    {
        stepped = false;

        /*for (int i = 0; i < coin.Length; i++)
        {
            // ���� ������ ��ֹ��� 1/3�� Ȯ���� Ȱ��ȭ
            if (Random.Range(0, 3) == 0)
            {
                coin[i].SetActive(true);

            }
            else
            {
                coin[i].SetActive(false);
            }

        }*/
        int i = Random.Range(0, 3);
        coins[i].SetActive(true);
    }
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �÷��̾� ĳ���Ͱ� �ڽ��� ����� �� ������ �߰��ϴ� ó��
        // �浹�� ������ �±װ� Player�̰� ������ �÷��̾� ĳ���Ͱ� ���� �ʾҴٸ�
        if (collision.collider.tag == "Player" && !stepped)
        {
            //������ �߰��ϰ� ���� ���¸� ������ ����
            stepped = true;
            GameManager.instance.Addcoin(1);

        }
    }
}
