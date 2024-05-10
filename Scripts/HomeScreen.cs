using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class HomeScreen : MonoBehaviour
{
    void Start()
    {
        ScoreTracker.player_score = 0;
    }
    void Update()
    {
        
    }

    public void LoadGameScreen()
    {
        Debug.Log("LoadGameScreen() has been activated");
        StartCoroutine(LoadSceneAfterDelay("Load Game Screen"));
        //SceneTransitions.load_game = true;
        // StartCoroutine(LoadSceneAfterDelay("Transition Screen"));
        // TransitionScreen.sceneName = "Load Game Screen";
    }

    public void InstructionsScreen()
    {
        Debug.Log("InstructionsScreen() has been activated");
        StartCoroutine(LoadSceneAfterDelay("Instructions Screen"));
    }

    public void SettingsScreen()
    {
        Debug.Log("SettingsScreen() has been activated");
        StartCoroutine(LoadSceneAfterDelay("Settings Screen"));
    }

    // Coroutine to wait before loading a scene
    IEnumerator LoadSceneAfterDelay(string sceneName)
    {
        yield return new WaitForSeconds(0.2f); // Wait for 1 second
        SceneManager.LoadScene(sceneName);
    }

    // Existing Quit method...
    public void Quit()
    {
        Debug.Log("Quit() has been activated");
        // Consider adding a delay here if you want, though usually not needed for quit actions.
        Application.Quit();
    }
}


