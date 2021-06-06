using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Left : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool ispressed = false;
    public GameObject player;
    Vector3 moveDirection;

    void Update()
    {
        if (ispressed)
        {
            player.transform.Translate(0.1f, 0, 0);
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
