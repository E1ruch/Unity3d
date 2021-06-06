using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
    //Главное меню. Старт 
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //Выход
    public void ExitGame()
    {
        Application.Quit();
    }
   
    public void Donate()
    {
        Application.OpenURL("https://sobe.ru/na/na_razvitie_proekta_8zm0");
    }
}
