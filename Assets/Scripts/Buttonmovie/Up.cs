using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Up : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool ispressed = false;
    public GameObject player;
    Vector3 moveDirection;
    public float speedV;
    void Start ()
    {
        speedV = (5f);
    }
    void Update()
    {
        if (ispressed)
        {
            //player.transform.Translate(0, 0, 0.2f);
            player.transform.Translate(0, 0, -speedV * Time.deltaTime);

        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }
}
