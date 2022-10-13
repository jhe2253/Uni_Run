using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject Play;

    public void step()
    {
        Time.timeScale = 0; //게임 일시정지
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
