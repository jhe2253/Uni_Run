using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coine : MonoBehaviour
{

    public GameObject[] coin;

    private void OnEnable()

    {


        for (int i = 0; i < coin.Length; i++)
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

        }
    }
    // Start is called before the first frame update

}
