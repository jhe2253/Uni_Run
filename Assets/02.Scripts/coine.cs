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
            // ���� ������ ��ֹ��� 1/3�� Ȯ���� Ȱ��ȭ
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
