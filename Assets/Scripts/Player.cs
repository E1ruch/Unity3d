using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Player : MonoBehaviour
//Настройки управления нашим кубом
{
    [SerializeField]
    KeyCode keyOne;
    [SerializeField]
    KeyCode keyTwo;
    [SerializeField]
    Vector3 moveDirection;
    [SerializeField]private bl_Joystick Joystick;//Joystick reference for assign in inspector

    [SerializeField] private float Speed = 5;


    private void Update()
    {
        //Step #2
        //Change Input.GetAxis (or the input that you using) to Joystick.Vertical or Joystick.Horizontal
        float v = Joystick.Vertical; //get the vertical value of joystick
        float h = Joystick.Horizontal;//get the horizontal value of joystick

        //in case you using keys instead of axis (due keys are bool and not float) you can do this:
        bool isKeyPressed = (Joystick.Horizontal > 0) ? true : false;

        //ready!, you not need more.
        Vector3 translate = (new Vector3(h, 0, 0) * Time.deltaTime) * Speed;
        transform.Translate(translate);


        //if (Input.GetKey(keyOne))
        //{
        //    GetComponent<Rigidbody>().velocity += moveDirection;
        //}
        //if (Input.GetKey(keyTwo))
        //{
        //    GetComponent<Rigidbody>().velocity -= moveDirection;
        //}
    }
    //Перезапуск уровня
    public void Resetlvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    //Следующий уровень
    public void NextLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //Настройки финиша куба

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))

        {
            Camera.main.GetComponent<UImanager>().Win();

            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
