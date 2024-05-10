using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using System.IO;
using System;
using Unity.VisualScripting;

public class LevelSelectScreen : MonoBehaviour
{
    private string filePath;
    public static bool player_one_clear_L1 = false, player_one_clear_L2 = false, player_one_clear_L3 = false, player_one_clear_L4 = false, player_one_clear_L5 = false;
    public static bool player_two_clear_L1 = false, player_two_clear_L2 = false, player_two_clear_L3 = false, player_two_clear_L4 = false, player_two_clear_L5 = false;
    public static bool player_three_clear_L1 = false, player_three_clear_L2 = false, player_three_clear_L3 = false, player_three_clear_L4 = false, player_three_clear_L5 = false;
    public static string playerID = "player_one"; // Default player ID
    // public static bool clear_L1 = false;
    // public static bool clear_L2 = false;
    // public static bool clear_L3 = false;
    public static bool true_finish = false;
    public GameObject L2_button;
    public GameObject L3_button;
    public GameObject L4_button;
    public GameObject L5_button;

    public void Start()
    {
        ScoreTracker.player_score = 0;
        //LoadPlayerProgress();
        filePath = Application.persistentDataPath + "/" + playerID + ".txt";
        UpdateLevelButtons();
    }
    public void Update(){}
    public void SavePlayerProgress()
    {
        if (playerID == "player_one"){
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.WriteLine(player_one_clear_L1 ? 1 : 0);
                writer.WriteLine(player_one_clear_L2 ? 1 : 0);
                writer.WriteLine(player_one_clear_L3 ? 1 : 0);
                writer.WriteLine(player_one_clear_L4 ? 1 : 0);
                writer.WriteLine(player_one_clear_L5 ? 1 : 0);
                writer.WriteLine(MusicTest.volvol.ToString("F1"));
                //writer.WriteLine(GameOverScreen.level);
            }
            Debug.Log("Player progress saved to " + filePath);
        }else if (playerID == "player_two"){
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.WriteLine(player_two_clear_L1 ? 1 : 0);
                writer.WriteLine(player_two_clear_L2 ? 1 : 0);
                writer.WriteLine(player_two_clear_L3 ? 1 : 0);
                writer.WriteLine(player_two_clear_L4 ? 1 : 0);
                writer.WriteLine(player_two_clear_L5 ? 1 : 0);
                writer.WriteLine(MusicTest.volvol.ToString("F1"));
                //writer.WriteLine(GameOverScreen.level);
            }
            Debug.Log("Player progress saved to " + filePath);           
        }else if (playerID == "player_three"){
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.WriteLine(player_three_clear_L1 ? 1 : 0);
                writer.WriteLine(player_three_clear_L2 ? 1 : 0);
                writer.WriteLine(player_three_clear_L3 ? 1 : 0);
                writer.WriteLine(player_three_clear_L4 ? 1 : 0);
                writer.WriteLine(player_three_clear_L5 ? 1 : 0);
                writer.WriteLine(MusicTest.volvol.ToString("F1"));
                //writer.WriteLine(GameOverScreen.level);
            }
            Debug.Log("Player progress saved to " + filePath);
        }
        // Using StreamWriter to write the progress to "player-one.txt"
        // using (StreamWriter writer = new StreamWriter(filePath, false))
        // {
        //     writer.WriteLine(clear_L1 ? 1 : 0);
        //     writer.WriteLine(clear_L2 ? 1 : 0);
        //     writer.WriteLine(clear_L3 ? 1 : 0);
        //     writer.WriteLine(MusicTest.volvol.ToString("F1"));
        //     //writer.WriteLine(GameOverScreen.level);
        // }
        // Debug.Log("Player progress saved to " + filePath);
    }
    // public void LoadPlayerProgress()
    // {
    //     // Check if the player progress file exists before trying to read it
    //     if (File.Exists(filePath))
    //     {
    //         string[] lines = File.ReadAllLines(filePath);
    //         if (lines.Length >= 3)
    //         {
    //             // Parsing the string values back to bool and updating the level clear status
    //             clear_L1 = lines[0] == "1";
    //             clear_L2 = lines[1] == "1";
    //             clear_L3 = lines[2] == "1";
    //         }
    //         else
    //         {
    //             Debug.LogError("Player progress file found but does not contain enough data.");
    //         }
    //     }
    //     else
    //     {
    //         Debug.Log("No player progress file found. Starting with default values.");
    //     }

    //     // After loading, update the level buttons accordingly
    //     UpdateLevelButtons();
    // }
    public void LoadPlayerProgress()
    {
        // Check if the player progress file exists before trying to read it
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            if (playerID == "player_one"){
                if (lines.Length >= 4) // Updated to 4 since we now have an additional float value to read
                {
                    // Parsing the string values back to bool and updating the level clear status
                    player_one_clear_L1 = lines[0] == "1";
                    player_one_clear_L2 = lines[1] == "1";
                    player_one_clear_L3 = lines[2] == "1";
                    player_one_clear_L4 = lines[3] == "1";
                    player_one_clear_L5 = lines[4] == "1";

                    // Loading and parsing the volvol value
                    float volvolValue;
                    if (float.TryParse(lines[5], out volvolValue)) // Assuming the volvol is stored in the fourth line
                    {
                        MusicTest.volvol = volvolValue;
                    }
                    else
                    {
                        Debug.LogError("Failed to parse volvol from the file.");
                    }
                }
                else
                {
                    Debug.LogError("Player progress file found but does not contain enough data.");
                }
            }else if (playerID == "player_two"){
                if (lines.Length >= 4) // Updated to 4 since we now have an additional float value to read
                {
                    // Parsing the string values back to bool and updating the level clear status
                    player_two_clear_L1 = lines[0] == "1";
                    player_two_clear_L2 = lines[1] == "1";
                    player_two_clear_L3 = lines[2] == "1";
                    player_two_clear_L4 = lines[3] == "1";
                    player_two_clear_L5 = lines[4] == "1";
                    // Loading and parsing the volvol value
                    float volvolValue;
                    if (float.TryParse(lines[5], out volvolValue)) // Assuming the volvol is stored in the fourth line
                    {
                        MusicTest.volvol = volvolValue;
                    }
                    else
                    {
                        Debug.LogError("Failed to parse volvol from the file.");
                    }
                }
                else
                {
                    Debug.LogError("Player progress file found but does not contain enough data.");
                }
            }else if (playerID == "player_three"){
                if (lines.Length >= 4) // Updated to 4 since we now have an additional float value to read
                {
                    // Parsing the string values back to bool and updating the level clear status
                    player_three_clear_L1 = lines[0] == "1";
                    player_three_clear_L2 = lines[1] == "1";
                    player_three_clear_L3 = lines[2] == "1";
                    player_three_clear_L4 = lines[3] == "1";
                    player_three_clear_L5 = lines[4] == "1";
                    // Loading and parsing the volvol value
                    float volvolValue;
                    if (float.TryParse(lines[5], out volvolValue)) // Assuming the volvol is stored in the fourth line
                    {
                        MusicTest.volvol = volvolValue;
                    }
                    else
                    {
                        Debug.LogError("Failed to parse volvol from the file.");
                    }
                }
                else
                {
                    Debug.LogError("Player progress file found but does not contain enough data.");
                }
            }
            // if (lines.Length >= 4) // Updated to 4 since we now have an additional float value to read
            // {
            //     // Parsing the string values back to bool and updating the level clear status
            //     clear_L1 = lines[0] == "1";
            //     clear_L2 = lines[1] == "1";
            //     clear_L3 = lines[2] == "1";

            //     // Loading and parsing the volvol value
            //     float volvolValue;
            //     if (float.TryParse(lines[3], out volvolValue)) // Assuming the volvol is stored in the fourth line
            //     {
            //         MusicTest.volvol = volvolValue;
            //     }
            //     else
            //     {
            //         Debug.LogError("Failed to parse volvol from the file.");
            //     }
            // }
            // else
            // {
            //     Debug.LogError("Player progress file found but does not contain enough data.");
            // }
        }
        else
        {
            Debug.Log("No player progress file found. Starting with default values.");
        }

        // After loading, update the level buttons accordingly
        UpdateLevelButtons();
    }


    void UpdateLevelButtons()
    {
        if (playerID == "player_one"){
            if (L2_button != null) L2_button.SetActive(player_one_clear_L1);
            if (L3_button != null) L3_button.SetActive(player_one_clear_L2);
            if (L4_button != null) L4_button.SetActive(player_one_clear_L3);
            if (L5_button != null) L5_button.SetActive(player_one_clear_L4);
        }else if(playerID == "player_two"){
            if (L2_button != null) L2_button.SetActive(player_two_clear_L1);
            if (L3_button != null) L3_button.SetActive(player_two_clear_L2);
            if (L4_button != null) L4_button.SetActive(player_two_clear_L3);
            if (L5_button != null) L5_button.SetActive(player_two_clear_L4);
        }else if (playerID == "player_three"){
            if (L2_button != null) L2_button.SetActive(player_three_clear_L1);
            if (L3_button != null) L3_button.SetActive(player_three_clear_L2);
            if (L4_button != null) L4_button.SetActive(player_three_clear_L3);
            if (L5_button != null) L5_button.SetActive(player_three_clear_L4);
        }
        // if (L2_button != null) L2_button.SetActive(clear_L1);
        // if (L3_button != null) L3_button.SetActive(clear_L2);
    }


    /////////////////////////////////////////////////////////////////////////
    public void L1(){
        GameOverScreen.level = 1;
        true_finish = false;
        Debug.Log("L1() has been activated");
        StartCoroutine(LoadSceneAfterDelay("Level1 Screen"));
    }
    public void L2(){
        GameOverScreen.level = 2;
        true_finish = false;
        Debug.Log("L2() has been activated");
        StartCoroutine(LoadSceneAfterDelay("Level2 Screen"));
    }
    public void L3(){
        GameOverScreen.level = 3;
        true_finish = false;
        Debug.Log("L3() has been activated");
        StartCoroutine(LoadSceneAfterDelay("Level3 Screen"));
    }
    public void L4(){
        GameOverScreen.level = 4;
        true_finish = false;
        Debug.Log("L4() has been activated");
        StartCoroutine(LoadSceneAfterDelay("Level4 Screen"));
    }
    public void L5(){
        GameOverScreen.level = 5;
        //true_finish = false;
        Debug.Log("L5() has been activated");
        StartCoroutine(LoadSceneAfterDelay("Level5 Screen"));
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
