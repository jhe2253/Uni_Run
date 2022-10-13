using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager instance; // �̱����� �Ҵ��� ���� ����

    public bool isGameover = false; // ���ӿ��� ����
    public Text scoreText; // ������ ����� UI �ؽ�Ʈ
    public Text coinText;
    public GameObject gameoverUi; // ���ӿ��� �� Ȱ��ȭ�� UI ���� ������Ʈ

    private int score = 0; // ���� ����
    private int coins = 0;

    // ���� ���۰� ���ÿ� �̱����� ����
    private void Awake()
    {
        // �̱��� ���� instance�� ��� �ִ°�?
        if(instance == null)
        {
            // instance�� ��� �ִٸ�(null) �װ��� �ڱ� �ڽ��� �Ҵ�
            instance = this;
        }
        else
        {
            // instance�� �̹� �ٸ� GameManager ������Ʈ�� �Ҵ�Ǿ� �ִ� ���

            // ���� �ΰ� �̻��� GameManger ������Ʈ�� �����Ѵٴ� �ǹ�
            // �̱��� ������Ʈ�� �ϳ��� �����ؾ� �ϹǷ� �ڽ��� ���� ������Ʈ�� �ı�
            Debug.LogWarning("���� �ΰ� �̻��� ���� �ų����� �����մϴ�!");
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // ���ӿ��� ���¿��� ������ ������� �� �ְ� �ϴ� ó��
        if(isGameover && Input.GetMouseButtonDown(0))
        {
            // ���ӿ��� ���¿��� ���콺 ���� ��ư�� Ŭ���ϸ� ���� �� �����
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    // ������ ������Ű�� �޼���
    public void AddScore(int newScore)
    {
        if (!isGameover)
        {
            // ������ ����
            score += newScore;
            scoreText.text = "Score : " + score;
        }
    }
    public void Addcoin(int newcoin)
    {
        if (!isGameover)
        {
            // ������ ����
            coins += newcoin;
            coinText.text = "" + coins;
        }
    }
    // �÷��̾� ĳ���� ��ֽ� ���ӿ����� �����ϴ� �޼���
    public void OnPlayerDead()
    {
        isGameover = true;
        gameoverUi.SetActive(true);
    }
}
