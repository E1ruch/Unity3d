using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    [SerializeField] private GameObject PanelPause;

    [SerializeField] private GameObject PanelWin;

    [SerializeField] private GameObject PanelLose;

    //�����
    public void PauseON ()
    {
        PanelPause.SetActive(true);
        Time.timeScale = 0;
    }
    public void PauseOff()
    {
        PanelPause.SetActive(false);
        Time.timeScale = 1;
    }
    //����� ���� � �������
    public void Win ()
    {
        PanelWin.SetActive(true);
        Time.timeScale = 0;
    }
    //����� ���� � ����������
    public void Lose()
    {
        PanelLose.SetActive(true);
    }
}
