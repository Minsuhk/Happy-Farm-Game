using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class SettingsScreen : MonoBehaviour
{
    public Text VolumeDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        UpdateVolumeText();
    }
    public void VolumeUp(){
        if (MusicTest.volvol <= 1.0f){
            MusicTest.volvol += 0.1f;
        } else {
            MusicTest.volvol = 1.0f;
        }
        UpdateVolumeText();
    }
    public void VolumeDown(){
        if (MusicTest.volvol >= 0.0f){
            MusicTest.volvol -= 0.1f;
        }else{
            MusicTest.volvol = 0.0f;
        }
        UpdateVolumeText();
    }
    void UpdateVolumeText(){
        float tempVol = MusicTest.volvol;
        tempVol *= 100;
        if (tempVol < 0){
            tempVol = 0;
        }
        VolumeDisplay.text = "Volume: " + tempVol.ToString("F1") + "%";
    }
    public void ToggleMusic(){
        MusicTest.isPlaying = !MusicTest.isPlaying;
    }
    public void ToggleClick(){
        ButtonSound.click_sound = !ButtonSound.click_sound;
    }
    public void HomeScreen(){
        Debug.Log("HomeScreen() has been activated");
        StartCoroutine(LoadSceneAfterDelay("Home Screen"));
    }
    IEnumerator LoadSceneAfterDelay(string sceneName)
    {
        yield return new WaitForSeconds(0.2f); // Wait for 1 second
        SceneManager.LoadScene(sceneName);
    }
}
