using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonFX : MonoBehaviour
{
    public AudioSource myFX;
    public AudioClip clickFX;

    public void ClickSound()
    {
        myFX.PlayOneShot(clickFX);
    }
}
