using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
//using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicTest : MonoBehaviour
{
    public static MusicTest meowmeow;
    public static bool isPlaying = true;
    public static float volvol = 0.1f;
    void Awake(){
        if (meowmeow != null){
            Destroy(gameObject);
        }else{
            meowmeow = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<AudioSource>().volume = volvol; // Set the volume

        if (isPlaying && !GetComponent<AudioSource>().isPlaying){
            GetComponent<AudioSource>().Play();
        }else if (!isPlaying && GetComponent<AudioSource>().isPlaying){
            GetComponent<AudioSource>().Pause();
        }
    }

}
