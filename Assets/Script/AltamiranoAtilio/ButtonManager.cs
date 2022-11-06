using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public AudioSource sound;
    public AudioClip soundButton;
    
    //Metodo que le da audio al botton de los Menus.
    public void AudioButton()
    {
        sound.clip = soundButton;
        sound.enabled = false;
        sound.enabled = true;
    }
}
