using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class ButtonSound : MonoBehaviour
{
    public AudioSource button_sound;
    public AudioClip sfx;
    public static bool click_sound = true;
    void Start()
    {
        
    }
    void Update()
    {

    }
    public void click(){
        Debug.Log("click() has been activated");
        if (click_sound){
            button_sound.clip = sfx;
            button_sound.Play();
        }
    }
}