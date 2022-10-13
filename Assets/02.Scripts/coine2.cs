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
            // 현재 순번의 장애물을 1/3의 확률로 활성화
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
        // 플레이어 캐릭터가 자신을 밟았을 때 점수를 추가하는 처리
        // 충돌한 상대방의 태그가 Player이고 이전에 플레이어 캐릭터가 밟지 않았다면
        if (collision.collider.tag == "Player" && !stepped)
        {
            //점수를 추가하고 밞힘 상태를 참으로 변경
            stepped = true;
            GameManager.instance.Addcoin(1);

        }
    }
}
