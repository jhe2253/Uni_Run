using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject Play;

    public void step()
    {
        Time.timeScale = 0; //���� �Ͻ�����
        menuPanel.SetActive(true);

    }
    public void go()
    {

        Time.timeScale = 1;
        menuPanel.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
