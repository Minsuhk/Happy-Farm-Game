using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using Unity.VisualScripting;

public class CharacterSelectScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CharacterActive.firstCharacter = false;
        CharacterActive.secondCharacter = false;
        ScoreTracker.score_multiplier = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FarmerPicked(){
        Debug.Log("FARMER HAS BEEN PICKED");
        CharacterActive.firstCharacter = true;
        StartCoroutine(LoadSceneAfterDelay("Level Select Screen"));
    }

    public void Farmer1Picked(){
        Debug.Log("FARMER1 HAS BEEN PICKED");
        CharacterActive.secondCharacter = true;
        ScoreTracker.score_multiplier = 2;
        StartCoroutine(LoadSceneAfterDelay("Level Select Screen"));
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
