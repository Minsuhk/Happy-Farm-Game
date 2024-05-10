using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.IO;
using UnityEngine.UIElements;
using JetBrains.Annotations;
using System;
using TMPro;

public class LoadGameScreen : MonoBehaviour
{
    public static string filename = "/save1.txt";
    void Start(){}
    void Update(){}
    public void file1(){
        //LevelSelectScreen.filename = "/save1.txt";
        LevelSelectScreen.playerID = "player_one";
        Debug.Log("file1() has been activated");
        // StartCoroutine(LoadSceneAfterDelay("Level Select Screen"));
        StartCoroutine(LoadSceneAfterDelay("Character Select Screen"));
    }
    public void file2(){
        //LevelSelectScreen.filename = "/save2.txt";
        LevelSelectScreen.playerID = "player_two";
        Debug.Log("file2() has been activated");
        StartCoroutine(LoadSceneAfterDelay("Character Select Screen"));
    }
    public void file3(){
        //LevelSelectScreen.filename = "/save3.txt";
        LevelSelectScreen.playerID = "player_three";
        Debug.Log("file3() has been activated");
        StartCoroutine(LoadSceneAfterDelay("Character Select Screen"));
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