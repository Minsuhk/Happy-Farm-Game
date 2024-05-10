using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class HomeMusic : MonoBehaviour
{
    public AudioSource home_music;
    public AudioClip music;
    public static bool isPlaying = true;
    public static float volvol = 0.5f;
    void Awake(){
        DontDestroyOnLoad(home_music);
        DontDestroyOnLoad(music);
    }
    /*
    make sure the controller adn the audio sources are dontdestroyed together so
    i can manage it instead of having it continuously play while being 
    untouchable

    maybe have them all attached together as a prefab 
    */
    void Start()
    {
        home_music.volume = volvol;
        home_music.clip = music;
        if (!isPlaying){
            home_music.Stop();
        }else{
            home_music.Play();
        }
    }
    void Update()
    {

    }
}