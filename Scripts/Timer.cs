using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;


public class Timer : MonoBehaviour
{
    // sets time to start at 60 seconds
    public float timeValue = 60;
    public Text timeText;
    public bool timerIsRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        ScoreTracker.player_score = 0;
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (timerIsRunning)
        {
            if(timeValue > 0) {
            // decreases the time per second
            timeValue -= Time.deltaTime;
            } else {
                timeValue = 0;
                timerIsRunning = false;
                
                // Transition to Game Over Screen when timer reaches zero
                GameOverScreen.sceneName = SceneManager.GetActiveScene().name;
                Debug.Log("GameOverScreen has been activated");
                if (LevelSelectScreen.playerID == "player_one"){
                    if (ScoreTracker.player_score >= 10 && GameOverScreen.sceneName == "Level1 Screen"){
                        LevelSelectScreen.player_one_clear_L1 = true;
                    } 
                    else if (ScoreTracker.player_score >= 10 && GameOverScreen.sceneName == "Level2 Screen"){
                        LevelSelectScreen.player_one_clear_L2 = true;
                        LevelSelectScreen.player_one_clear_L1 = true;
                    }
                    else if(ScoreTracker.player_score >= 10 && GameOverScreen.sceneName == "Level3 Screen"){
                        LevelSelectScreen.player_one_clear_L3 = true;
                        LevelSelectScreen.player_one_clear_L2 = true;
                        LevelSelectScreen.player_one_clear_L1 = true;
                    }
                    else if(ScoreTracker.player_score >= 10 && GameOverScreen.sceneName == "Level4 Screen"){
                        LevelSelectScreen.player_one_clear_L4 = true;
                        LevelSelectScreen.player_one_clear_L3 = true;
                        LevelSelectScreen.player_one_clear_L2 = true;
                        LevelSelectScreen.player_one_clear_L1 = true;
                    }
                    else if(ScoreTracker.player_score >= 10 && GameOverScreen.sceneName == "Level5 Screen"){
                        LevelSelectScreen.player_one_clear_L5 = true;
                        LevelSelectScreen.player_one_clear_L4 = true;
                        LevelSelectScreen.player_one_clear_L3 = true;
                        LevelSelectScreen.player_one_clear_L2 = true;
                        LevelSelectScreen.player_one_clear_L1 = true;
                        LevelSelectScreen.true_finish = true;
                    }
                }else if(LevelSelectScreen.playerID == "player_two"){
                    if (ScoreTracker.player_score >= 10 && GameOverScreen.sceneName == "Level1 Screen"){
                        LevelSelectScreen.player_two_clear_L1 = true;
                    } 
                    else if (ScoreTracker.player_score >= 10 && GameOverScreen.sceneName == "Level2 Screen"){
                        LevelSelectScreen.player_two_clear_L2 = true;
                        LevelSelectScreen.player_two_clear_L1 = true;
                    }
                    else if(ScoreTracker.player_score >= 10 && GameOverScreen.sceneName == "Level3 Screen"){
                        LevelSelectScreen.player_two_clear_L3 = true;
                        LevelSelectScreen.player_two_clear_L2 = true;
                        LevelSelectScreen.player_two_clear_L1 = true;
                    }
                    else if(ScoreTracker.player_score >= 10 && GameOverScreen.sceneName == "Level4 Screen"){
                        LevelSelectScreen.player_two_clear_L4 = true;
                        LevelSelectScreen.player_two_clear_L3 = true;
                        LevelSelectScreen.player_two_clear_L2 = true;
                        LevelSelectScreen.player_two_clear_L1 = true;
                    }
                    else if(ScoreTracker.player_score >= 10 && GameOverScreen.sceneName == "Level5 Screen"){
                        LevelSelectScreen.player_two_clear_L5 = true;
                        LevelSelectScreen.player_two_clear_L4 = true;
                        LevelSelectScreen.player_two_clear_L3 = true;
                        LevelSelectScreen.player_two_clear_L2 = true;
                        LevelSelectScreen.player_two_clear_L1 = true;
                        LevelSelectScreen.true_finish = true;
                    }
                }else if(LevelSelectScreen.playerID == "player_three"){
                    if (ScoreTracker.player_score >= 10 && GameOverScreen.sceneName == "Level1 Screen"){
                        LevelSelectScreen.player_three_clear_L1 = true;
                    } 
                    else if (ScoreTracker.player_score >= 10 && GameOverScreen.sceneName == "Level2 Screen"){
                        LevelSelectScreen.player_three_clear_L2 = true;
                        LevelSelectScreen.player_three_clear_L1 = true;
                    }
                    else if(ScoreTracker.player_score >= 10 && GameOverScreen.sceneName == "Level3 Screen"){
                        LevelSelectScreen.player_three_clear_L3 = true;
                        LevelSelectScreen.player_three_clear_L2 = true;
                        LevelSelectScreen.player_three_clear_L1 = true;
                    }
                    else if(ScoreTracker.player_score >= 10 && GameOverScreen.sceneName == "Level4 Screen"){
                        LevelSelectScreen.player_three_clear_L4 = true;
                        LevelSelectScreen.player_three_clear_L3 = true;
                        LevelSelectScreen.player_three_clear_L2 = true;
                        LevelSelectScreen.player_three_clear_L1 = true;
                    }
                    else if(ScoreTracker.player_score >= 10 && GameOverScreen.sceneName == "Level5 Screen"){
                        LevelSelectScreen.player_three_clear_L5 = true;
                        LevelSelectScreen.player_three_clear_L4 = true;
                        LevelSelectScreen.player_three_clear_L3 = true;
                        LevelSelectScreen.player_three_clear_L2 = true;
                        LevelSelectScreen.player_three_clear_L1 = true;
                        LevelSelectScreen.true_finish = true;
                    }
                }
                // if (ScoreTracker.player_score >= 10 && GameOverScreen.sceneName == "Level1 Screen"){
                //     LevelSelectScreen.clear_L1 = true;
                // } 
                // else if (ScoreTracker.player_score >= 10 && GameOverScreen.sceneName == "Level2 Screen"){
                //     LevelSelectScreen.clear_L2 = true;
                //     LevelSelectScreen.clear_L1 = true;
                // }
                // else if(ScoreTracker.player_score >= 10 && GameOverScreen.sceneName == "Level3 Screen"){
                //     LevelSelectScreen.clear_L3 = true;
                //     LevelSelectScreen.clear_L2 = true;
                //     LevelSelectScreen.clear_L1 = true;
                //     LevelSelectScreen.true_finish = true;
                // }

                SceneManager.LoadScene("Game Over Screen");
                
            }
        }
        
        // updates the text of the timer
        displayTime(timeValue);
    }

    void displayTime(float timeToDisplay) {
        // makes sure the timer stops at 0 and doesn't go into the negatives
        if(timeToDisplay < 0) {
            timeToDisplay = 0;
        }

        // converts to minutes and seconds format
        float minutes = Mathf.FloorToInt(timeToDisplay/60);
        float seconds = Mathf.FloorToInt(timeToDisplay%60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
