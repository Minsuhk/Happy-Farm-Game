using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using Unity.VisualScripting;

public class GameOverScreen : MonoBehaviour
{
    public GameObject next_level_button;

    // Text displayed on the game over screen changes depending on the level and if the player succeeded or not
    public Text game_over_text;
    public static string sceneName = "meow";//deafult value
    
    // indicates if the player paused the game
    bool pause = false;

    // keeps track of the level the player is on
    public static int level = 1;

    void Start()
    {
        game_over_text.text = "";
    }

    void Update()
    {
        if (pause == false){
            if (LevelSelectScreen.playerID == "player_one"){
                if (level == 5 && LevelSelectScreen.player_one_clear_L1 == true && 
                LevelSelectScreen.player_one_clear_L2 == true && 
                LevelSelectScreen.player_one_clear_L3 == true && 
                LevelSelectScreen.player_one_clear_L4 == true &&
                LevelSelectScreen.player_one_clear_L5 == true &&
                LevelSelectScreen.true_finish == true) {
                    // Displays when player completes all 5 levels
                    game_over_text.text = "Congrats! You helped save the fruit on the farm!";
                    LevelSelectScreen.true_finish = false;
                }
                // Checks if a player reached the score goal and it is not the last level
                else if (ScoreTracker.player_score >= 10 && level < 5)
                {
                    game_over_text.text = "Congrats! You can move to the next level!";
                    next_level_button.SetActive(true);
                } 
                else if (ScoreTracker.player_score < 10)
                {
                    // Displays when player didn't reach score goal
                    game_over_text.text = "Aw you didn't collect enough fruits, make sure to collect the non-eaten ones! Replay to try again!";
                    // Hides access to next level
                    next_level_button.SetActive(false);
                }
            }else if (LevelSelectScreen.playerID == "player_two"){
                if (level == 5 && LevelSelectScreen.player_two_clear_L1 == true && 
                LevelSelectScreen.player_two_clear_L2 == true && 
                LevelSelectScreen.player_two_clear_L3 == true && 
                LevelSelectScreen.player_two_clear_L4 == true && 
                LevelSelectScreen.player_two_clear_L5 == true && 
                LevelSelectScreen.true_finish == true) {
                    // Displays when player completes all 5 levels
                    game_over_text.text = "Congrats! You helped save the fruit on the farm!";
                    LevelSelectScreen.true_finish = false;
                }
                // Checks if a player reached the score goal and it is not the last level
                else if (ScoreTracker.player_score >= 10 && level < 5)
                {
                    game_over_text.text = "Congrats! You can move to the next level!";
                    next_level_button.SetActive(true);
                } 
                else if (ScoreTracker.player_score < 10)
                {
                    // Displays when player didn't reach score goal
                    game_over_text.text = "Aw you didn't collect enough fruits, make sure to collect the non-eaten ones! Replay to try again!";
                    // Hides access to next level
                    next_level_button.SetActive(false);
                }
            }else if (LevelSelectScreen.playerID == "player_three"){
                if (level == 5 && LevelSelectScreen.player_three_clear_L1 == true && 
                LevelSelectScreen.player_three_clear_L2 == true && 
                LevelSelectScreen.player_three_clear_L3 == true && 
                LevelSelectScreen.player_three_clear_L4 == true && 
                LevelSelectScreen.player_three_clear_L5 == true && 
                LevelSelectScreen.true_finish == true) {
                    // Displays when player completes all 3 levels
                    game_over_text.text = "Congrats! You helped save the fruit on the farm!";
                    LevelSelectScreen.true_finish = false;
                }
                // Checks if a player reached the score goal and it is not the last level
                else if (ScoreTracker.player_score >= 10 && level < 5)
                {
                    game_over_text.text = "Congrats! You can move to the next level!";
                    next_level_button.SetActive(true);
                } 
                else if (ScoreTracker.player_score < 10)
                {
                    // Displays when player didn't reach score goal
                    game_over_text.text = "Aw you didn't collect enough fruits, make sure to collect the non-eaten ones! Replay to try again!";
                    // Hides access to next level
                    next_level_button.SetActive(false);
                }          
            }
            // if (level == 3 && LevelSelectScreen.clear_L1 == true && LevelSelectScreen.clear_L2 == true && LevelSelectScreen.clear_L3 == true && LevelSelectScreen.true_finish == true) {
            //     // Displays when player completes all 3 levels
            //     game_over_text.text = "Congrats! You helped save the fruit on the farm!";
            //     LevelSelectScreen.true_finish = false;
            // }
            // // Checks if a player reached the score goal and it is not the last level
            // else if (ScoreTracker.player_score >= 10 && level < 3)
            // {
            //     game_over_text.text = "Congrats! You can move to the next level!";
            //     next_level_button.SetActive(true);
            // } 
            // else if (ScoreTracker.player_score < 1)
            // {
            //     // Displays when player didn't reach score goal
            //     game_over_text.text = "Aw you didn't collect enough fruits, make sure to collect the non-eaten ones! Replay to try again!";
            //     // Hides access to next level
            //     next_level_button.SetActive(false);
            // }
        }
    }
    public void HomeScreen(){
        Debug.Log("HomeScreen() has been activated");
        pause = false;
        StartCoroutine(LoadSceneAfterDelay("Home Screen"));
    }
    public void LevelSelect()
    {
        Debug.Log("LevelSelect() has been activated");
        pause = false;
        StartCoroutine(LoadSceneAfterDelay("Level Select Screen"));
        
    }
    public void NextLevel(){
        Debug.Log("NextLevel() has been activated");
        // Load the next scene index after a delay
        // All game level scene names need to follow this format
        if (level < 5) {
            level += 1;
            Debug.Log("Level" + level + " Screen");
            StartCoroutine(LoadSceneAfterDelay("Level" + level + " Screen"));
        }
    }
    public void ReplayLevel(){
        Debug.Log("ReplayLevel() has been activated");
        pause = false; 
    
        Debug.Log("Replaying level " + level);
        // Load the previous scene index after a delay
        StartCoroutine(LoadSceneAfterDelay("Level" + level + " Screen"));
    }
    IEnumerator LoadSceneAfterDelay(string sceneName)
    {
        yield return new WaitForSeconds(0.2f); // Wait for 1 second
        SceneManager.LoadScene(sceneName);
    }
}